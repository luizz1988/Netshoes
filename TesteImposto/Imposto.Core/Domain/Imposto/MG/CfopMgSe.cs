﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Imposto.MG
{
    class CfopMgSe : ImpostoCfop
    {
        public ImpostoCfop Proximo { get; set; }
        public string ObtemCfop(Pedido pedido)
        {
            if ((pedido.EstadoOrigem == "MG") && (pedido.EstadoDestino == "SE"))
            {
                return "6.007";
            }

            return Proximo.ObtemCfop(pedido);
        }


    }
}
