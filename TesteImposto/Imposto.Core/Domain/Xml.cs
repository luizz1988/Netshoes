using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Imposto.Core.Domain
{
    public class Xml
    {
        #region Metodo

        /// <summary>
        /// Efetua o Export do Pedido para xml
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static bool Exportar(Pedido pedido)
        {


            try
            {
              //Obtenho caminho configurado no app.config
                FileStream stream = new FileStream(string.Concat(ConfigurationManager.AppSettings.Get("UrlXml"),pedido.NomeCliente), FileMode.Create);
                XmlSerializer serializador = new XmlSerializer(typeof(Pedido));
                serializador.Serialize(stream, pedido);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
