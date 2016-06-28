using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Imposto.SP
{
    class CfopSpMg : ImpostoCfop
    {
        public ImpostoCfop Proximo { get; set; }
        public string ObtemCfop(Pedido pedido)
        {
            if ((pedido.EstadoOrigem == "SP") && (pedido.EstadoDestino == "MG"))
            {
                return "6.002";
            }

            return Proximo.ObtemCfop(pedido);
        }
    }
}
