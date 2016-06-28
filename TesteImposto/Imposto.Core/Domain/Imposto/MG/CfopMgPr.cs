using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Imposto.MG
{
    class CfopMgPr : ImpostoCfop
    {
        public ImpostoCfop Proximo { get; set; }
        public string ObtemCfop(Pedido pedido)
        {
            if ((pedido.EstadoOrigem == "MG") && (pedido.EstadoDestino == "PR"))
            {
                return "6.004";
            }

            return Proximo.ObtemCfop(pedido);
        }


    }
}
