using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Arquitects.Negocio;
using Architects.Dominio;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PagosService" in code, svc and config file together.
    public class PagosService : IPagosService
    {
        TipoPagoBL tipoPagoBL = new TipoPagoBL();
        #region Tabla: TipoPago


        public IList<TipoPago> ListarTipoPago()
        {
            IList<TipoPago> lstTipoPago;
            lstTipoPago=tipoPagoBL.Listar();
            return lstTipoPago;
        }

        public TipoPago RegistrarTipoPago(string Descripcion)
        {
            TipoPago tipoPago = new TipoPago();
            tipoPago.B_Estado = true;
            tipoPago.C_Descripcion = Descripcion;

            return tipoPagoBL.Registrar(tipoPago);
        }

        #endregion

        #region Tabla: Cuota

        public RetornaMensaje RegistrarCuota(string C_Periodo, int N_IdVivienda, int N_IdTipoPago, decimal N_Importe, DateTime D_FecVncto)
        {
            /* RetornaMensaje : Clase Contenedora del Error */
            RetornaMensaje retornaMensaje = new RetornaMensaje();
            CuotaBL cuotaBL = new CuotaBL();
            try
            {
                Cuota cuota = new Cuota
                {
                    C_Periodo = C_Periodo,
                    N_IdVivienda = N_IdVivienda,
                    N_IdTipoPago = N_IdTipoPago,
                    N_Importe = N_Importe,
                    D_FecVncto = D_FecVncto
                };
                retornaMensaje.CodigoRetorno = cuotaBL.Registrar(cuota);
                if (retornaMensaje.CodigoRetorno > 0)
                {
                    retornaMensaje.Mensage = resMensajes.msjGuardadoOK;
                }
            }
            catch (Exception exception)
            {
                retornaMensaje.Mensage = exception.Message;
                retornaMensaje.CodigoError = exception.GetHashCode().ToString();
                throw new FaultException<RetornaMensaje>(retornaMensaje);
            }
            return retornaMensaje;
        }

        #endregion
    }

}