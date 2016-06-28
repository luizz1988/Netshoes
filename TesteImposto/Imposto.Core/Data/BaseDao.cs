using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Data
{
   public static class BaseDao
    {


       public static string ObtemConectionString()
       {
           return ConfigurationManager.ConnectionStrings["Conn"].ToString();
       }


    }
}
