﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Imposto.SP
{
    class CfopSpRj : ImpostoCfop
    {
        public ImpostoCfop Proximo { get; set; }
        public string ObtemCfop(Pedido pedido)
        {
            if ((pedido.EstadoOrigem == "SP") && (pedido.EstadoDestino == "RJ"))
            {
                return "6.000";
            }

            return Proximo.ObtemCfop(pedido);
        }
    }
}
