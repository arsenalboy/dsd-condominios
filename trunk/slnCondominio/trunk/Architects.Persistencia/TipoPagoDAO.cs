using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Architects.Dominio;
using System.Data.SqlClient;
using System.Data;

namespace Architects.Persistencia
{
    public class TipoPagoDAO //: BaseDAO<TipoPago, int>
    {
        string CadenaConexionSQL;
        SqlConnection objconeccion;

        public TipoPagoDAO(string cadenaconexion)
        {
            CadenaConexionSQL = cadenaconexion;
        }
        public TipoPagoDAO()
        {
            CadenaConexionSQL = Utilitario.CadenaConeccion();
        }

        public List<TipoPago> Listar()
        {
            List<TipoPago> lstTipoPago = new List<TipoPago>();
            try
            {

                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(CadenaConexionSQL))
                {
                    var resul = SQLDC.dsd_mnt_S_TipoPago();
                    foreach (var item in resul)
                    {
                        lstTipoPago.Add(new TipoPago()
                        {
                            N_IdTipoPago = item.N_IdTipoPago,
                            C_Descripcion = item.C_Descripcion,
                            B_Estado = item.B_Estado
                        });
                    }   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } 
            return lstTipoPago;
        }

        public TipoPago Buscar(int codTipoPago)
        {
            TipoPago tipoPago = new TipoPago();
            try
            {

                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(CadenaConexionSQL))
                {
                    var resul = SQLDC.dsd_mnt_S_TipoPagoId(codTipoPago);
                    foreach (var item in resul)
                    {
                        tipoPago =new TipoPago()
                        {
                            N_IdTipoPago = item.N_IdTipoPago,
                            C_Descripcion = item.C_Descripcion,
                            B_Estado = item.B_Estado
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tipoPago;
        }

        public int Registrar(TipoPago tipoPago)
        {
            int? codigoRetorno = null;
            try
            {
                using (DBMLPagosDataContext SQLDC = new DBMLPagosDataContext(CadenaConexionSQL))
                {
                    SQLDC.dsd_mnt_I_TipoPago(ref codigoRetorno, tipoPago.C_Descripcion, tipoPago.B_Estado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno == null ? 0 : codigoRetorno.Value;
        }
    }
}
