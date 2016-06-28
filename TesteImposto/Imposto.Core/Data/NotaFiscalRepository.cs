using Imposto.Core.Domain;
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
    public static class NotaFiscalRepository
    {
        #region Metodos
        /// <summary>
        /// Insere Nota
        /// </summary>
        /// <param name="notaFiscal"></param>
        /// <returns></returns>
        public static int InsertNotaFiscal(NotaFiscal notaFiscal)
        {

            try
            {
                int id;
                 using (SqlConnection con = new SqlConnection(BaseDao.ObtemConectionString()))
                 {
                     using (SqlCommand cmd = new SqlCommand("P_NOTA_FISCAL", con))
                     {

                         cmd.CommandType = CommandType.StoredProcedure;
                         cmd.Parameters.AddWithValue("@pNumeroNotaFiscal", notaFiscal.NumeroNotaFiscal);
                         cmd.Parameters.AddWithValue("@pSerie", notaFiscal.Serie);
                         cmd.Parameters.AddWithValue("@pNomeCliente", notaFiscal.NomeCliente);
                         cmd.Parameters.AddWithValue("@pEstadoDestino", notaFiscal.EstadoDestino);
                         cmd.Parameters.AddWithValue("@pEstadoOrigem", notaFiscal.EstadoOrigem);
                         cmd.Parameters.Add("@pId", SqlDbType.Int);
                         cmd.Parameters["@pId"].Direction = ParameterDirection.Output;
                         
                         con.Open();
                         cmd.ExecuteNonQuery();
                         con.Close();

                          id = Convert.ToInt32(cmd.Parameters["@pId"].Value.ToString());
                         
                     }
                 }
                return id;
            }
            catch (Exception)
            {
                
                throw;
            }



        }

        /// <summary>
        /// Insere Item Nota
        /// </summary>
        /// <param name="notaFiscalItem"></param>
        public static  void InsertNotaFiscalItem(NotaFiscalItem notaFiscalItem)
        {

            try
            {

                using (SqlConnection con = new SqlConnection(BaseDao.ObtemConectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("P_NOTA_FISCAL_ITEM", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pIdNotaFiscal", notaFiscalItem.IdNotaFiscal);
                        cmd.Parameters.AddWithValue("@pCfop", notaFiscalItem.Cfop);
                        cmd.Parameters.AddWithValue("@pTipoIcms", notaFiscalItem.TipoIcms);
                        cmd.Parameters.AddWithValue("@pBaseIcms", notaFiscalItem.BaseIcms);
                        cmd.Parameters.AddWithValue("@pAliquotaIcms", notaFiscalItem.AliquotaIcms);

                        cmd.Parameters.AddWithValue("@pValorIcms", notaFiscalItem.ValorIcms);
                        cmd.Parameters.AddWithValue("@pNomeProduto", notaFiscalItem.NomeProduto);
                        cmd.Parameters.AddWithValue("@pCodigoProduto", notaFiscalItem.CodigoProduto);

                        cmd.Parameters.AddWithValue("@BaseIpi", notaFiscalItem.BaseIpi);
                        cmd.Parameters.AddWithValue("@ValorIpi", notaFiscalItem.ValorIpi);
                        cmd.Parameters.AddWithValue("@AliquotaIpi", notaFiscalItem.AliquotaIpi);

                        cmd.Parameters.Add("@pId",SqlDbType.Int);
                        cmd.Parameters["@pId"].Direction = ParameterDirection.Output;

                        con.Open();
                        int id = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }



        }
        #endregion
    }
}
