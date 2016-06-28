using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Imposto.MG
{
    public class CfopMgPe : ImpostoCfop
    {
        public ImpostoCfop Proximo { get; set; }
        public string ObtemCfop(Pedido pedido)
        {
            if ((pedido.EstadoOrigem == "MG") && (pedido.EstadoDestino == "PE"))
            {
                return "6.001";
            }

            return Proximo.ObtemCfop(pedido);
        }
    }
}
