using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Descontos
{
    public static class DescontosSudeste
    {
        /// <summary>
        /// Verifica se tem direito a desconto
        /// O correto seria aplicar padrao de projeto, potos de melhoria
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        public static double ObtemDesconto(string estado)
        {
            switch (estado)
            {
                case "SP":
                    return 0.10;
                    
                case "MG":
                    return 0.10;
                    
                case "RJ":
                    return 0.10;

                case "ES":
                    return 0.10;

            }

            return 0;

        
        }
    }
}
