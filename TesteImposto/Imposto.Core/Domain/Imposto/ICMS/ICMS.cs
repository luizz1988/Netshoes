using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Imposto.ICMS
{
  public static class ICMS
    {
      public static string ObtemTipoIcms(Pedido pedido)
      {
          if (pedido.EstadoDestino == pedido.EstadoOrigem)
          {
              return  "60";

          }
          return  "10";
      }


      public static Double ObtemAliquotaIcms(Pedido pedido)
      {
                 
          if (pedido.EstadoDestino == pedido.EstadoOrigem)
          {
            return 0.18;
          }
          return  0.17;
      }

      public static Double CalculaBaseIcms(string cfop, double valorItemPedido)
      {

          if (cfop == "6.009")
          {
              return  valorItemPedido * 0.90; //redução de base
          }
          return valorItemPedido;
      }

      public static Double CalculaValorIcms(NotaFiscalItem notaFiscalItem)
      {
          return notaFiscalItem.BaseIcms * notaFiscalItem.AliquotaIcms;
      }

    }
}
