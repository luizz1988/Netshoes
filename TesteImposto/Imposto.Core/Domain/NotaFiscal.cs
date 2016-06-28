using Imposto.Core.Data;
using Imposto.Core.Domain.Descontos;
using Imposto.Core.Domain.Imposto;
using Imposto.Core.Domain.Imposto.ICMS;
using Imposto.Core.Domain.Imposto.IPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain
{

    public class NotaFiscal
    {
        public int Id { get; set; }
        public int NumeroNotaFiscal { get; set; }
        public int Serie { get; set; }
        public string NomeCliente { get; set; }

        public string EstadoDestino { get; set; }
        public string EstadoOrigem { get; set; }
        public Double Desconto { get; set; }

        public IList<NotaFiscalItem> ItensDaNotaFiscal { get; set; }

        public NotaFiscal()
        {
            ItensDaNotaFiscal = new List<NotaFiscalItem>();
        }

        public void EmitirNotaFiscal(Pedido pedido)
        {
            this.NumeroNotaFiscal = 99999;
            this.Serie = new Random().Next(Int32.MaxValue);
            this.NomeCliente = pedido.NomeCliente;

            this.EstadoDestino = pedido.EstadoOrigem;
            this.EstadoOrigem = pedido.EstadoDestino;

            foreach (PedidoItem itemPedido in pedido.ItensDoPedido)
            {
                NotaFiscalItem notaFiscalItem = new NotaFiscalItem();

                //Uso padrao de Projeto Clain of Responsability, para resolver o problema de manutanção e sujeira de codigo
                CalculaCfop cfop = new CalculaCfop();
                notaFiscalItem.Cfop = cfop.ObtemCfop(pedido);

                //Centralizo para cada classe responsavel
                notaFiscalItem.AliquotaIcms = ICMS.ObtemAliquotaIcms(pedido);
                notaFiscalItem.TipoIcms = ICMS.ObtemTipoIcms(pedido);
                notaFiscalItem.BaseIcms = ICMS.CalculaBaseIcms(notaFiscalItem.Cfop, itemPedido.ValorItemPedido);
                notaFiscalItem.ValorIcms = ICMS.CalculaValorIcms(notaFiscalItem);

                if (itemPedido.Brinde)
                {
                    notaFiscalItem.TipoIcms = "60";
                    notaFiscalItem.AliquotaIcms = 0.18;
                    notaFiscalItem.ValorIcms = notaFiscalItem.BaseIcms * notaFiscalItem.AliquotaIcms;
                }
                notaFiscalItem.NomeProduto = itemPedido.NomeProduto;
                notaFiscalItem.CodigoProduto = itemPedido.CodigoProduto;

                // caulculo IPI
                notaFiscalItem.AliquotaIpi = IPI.CalculaAliquotaIpi(itemPedido.Brinde);
                notaFiscalItem.BaseIpi += itemPedido.ValorItemPedido;
                notaFiscalItem.ValorIpi = IPI.CalculaValorIpi(notaFiscalItem.BaseIpi, notaFiscalItem.AliquotaIpi);

                //Desconto Sudeste
                notaFiscalItem.Desconto = DescontosSudeste.ObtemDesconto(this.EstadoDestino);

                this.ItensDaNotaFiscal.Add(notaFiscalItem);
            }

            //Validação se persistiu xml com sucesso
            if (!Xml.Exportar(pedido))
            {
                throw new Exception("Problemas para gravar Xml");
            }

            // Salvando no Banco
            var idNota = NotaFiscalRepository.InsertNotaFiscal(this);

            foreach (var item in this.ItensDaNotaFiscal.ToList())
            {
                item.IdNotaFiscal = idNota;
                NotaFiscalRepository.InsertNotaFiscalItem(item);
            }

        }
    }
}
