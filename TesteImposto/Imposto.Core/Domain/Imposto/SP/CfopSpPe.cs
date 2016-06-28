using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Imposto.SP
{
    class CfopSpPe : ImpostoCfop
    {
        public ImpostoCfop Proximo { get; set; }
        public string ObtemCfop(Pedido pedido)
        {
            if ((pedido.EstadoOrigem == "SP") && (pedido.EstadoDestino == "PE"))
            {
                return "6.001";
            }

            return Proximo.ObtemCfop(pedido);
        }
    }
}
