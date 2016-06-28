using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Imposto.IPI
{
    public static class IPI
    {
        public static Double CalculaAliquotaIpi(bool brinde)
        {

            if (brinde)
            {
                return 0;
            }

            return 0.10;
        }

        public static Double CalculaValorIpi(double baseCalculoIpi, double aliquotaIpi)
        {
            return baseCalculoIpi * aliquotaIpi;
        
        }


    }
}
