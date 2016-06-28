    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain.Imposto
{
    public interface ImpostoCfop
    {
        string ObtemCfop(Pedido pedido);
        ImpostoCfop Proximo { get; set; }
    }
}
