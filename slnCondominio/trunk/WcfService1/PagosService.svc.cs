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
        /// <summary>
        /// Registra Una Cuota para una vivienda del Condominio
        /// </summary>
        /// <param name="C_Periodo"></param>
        /// <param name="N_IdVivienda"></param>
        /// <param name="N_IdTipoPago"></param>
        /// <param name="N_Importe"></param>
        /// <param name="D_FecVncto"></param>
        /// <returns></returns>
        public RetornaMensaje RegistrarCuota(string C_Periodo, int N_IdVivienda, int N_IdTipoPago, decimal N_Importe, DateTime D_FecVncto)
        {
            RetornaMensaje retornaMensaje = new RetornaMensaje();
            try
            {
                CuotaBL cuotaBL = new CuotaBL();
                Cuota cuota = new Cuota
                {
                    C_Periodo = C_Periodo,
                    N_IdVivienda = N_IdVivienda,
                    N_IdTipoPago = N_IdTipoPago,
                    N_Importe = N_Importe,
                    D_FecVncto = D_FecVncto
                };
                retornaMensaje.CodigoRetorno = cuotaBL.Registrar(cuota);
                retornaMensaje.Mensage = string.Format(resMensajes.msjGuardadoOK, "Cuota");
            }
            catch (Exception exception)
            {
                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje { Mensage = string.Format(resMensajes.msjNoRegistrado, "Cuota"), 
                                          CodigoError = exception.GetHashCode().ToString() 
                                        }
                    ,new FaultReason(exception.Message));
            }
            return retornaMensaje;
        }

        /// <summary>
        /// Actualiza un registro de cuota de una vivienda del Condominio
        /// </summary>
        /// <param name="pIdCuota"></param>
        /// <param name="pPeriodo"></param>
        /// <param name="pIdVivienda"></param>
        /// <param name="pIdTipoPago"></param>
        /// <param name="pImporte"></param>
        /// <param name="pFecVncto"></param>
        /// <returns></returns>
        public RetornaMensaje ActualizarCuota(int pIdCuota, string pPeriodo, int pIdVivienda, int pIdTipoPago, decimal pImporte, DateTime pFecVncto)
        {
            RetornaMensaje retornaMensaje = new RetornaMensaje();
            try
            {
                CuotaBL cuotaBL = new CuotaBL();
                Cuota cuota = new Cuota
                {
                    N_IdCuota = pIdCuota,
                    C_Periodo = pPeriodo,
                    N_IdVivienda = pIdVivienda,
                    N_IdTipoPago = pIdTipoPago,
                    N_Importe = pImporte,
                    D_FecVncto = pFecVncto
                };
                retornaMensaje.CodigoRetorno = cuotaBL.Actualizar(cuota);
                retornaMensaje.Mensage = string.Format(resMensajes.msjGuardadoOK, "Cuota");
            }
            catch (Exception exception)
            {
                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoRegistrado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString()
                    }
                    , new FaultReason(exception.Message));
            }
            return retornaMensaje;
        }

        /// <summary>
        /// Permita el listado de Cuotas
        /// </summary>
        /// <param name="pPeriodo"></param>
        /// <returns></returns>
        public List<Cuota> ListarCuota(string pPeriodo)
        {
            List<Cuota> lstCuota = new List<Cuota>();
            try
            {
                CuotaBL cuotaBL = new CuotaBL();
                lstCuota = cuotaBL.Listar(pPeriodo);
            }
            catch (Exception exception)
            {

                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoListado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString()
                    }
                    , new FaultReason(exception.Message));
            }
            return lstCuota;
        }

        /// <summary>
        /// Permite buscar cuota por Id de registro
        /// </summary>
        /// <param name="pIdCuota"></param>
        /// <returns></returns>
        public Cuota BuscarCuota(int pIdCuota)
        {
            Cuota cuota = new Cuota();
            try
            {
                CuotaBL cuotaBL = new CuotaBL();
                cuota = cuotaBL.Buscar(pIdCuota);
            }
            catch (Exception exception)
            {
                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoBuscado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString()
                    }
                    , new FaultReason(exception.Message));
            }
            return cuota;
        }

        /// <summary>
        /// Permite eliminar Cuota por Id de Registro
        /// </summary>
        /// <param name="pIdCuota"></param>
        /// <returns></returns>
        public RetornaMensaje EliminarCuota(int pIdCuota)
        {
            RetornaMensaje retornaMensaje = new RetornaMensaje();
            try
            {
                CuotaBL cuotaBL = new CuotaBL();
                Cuota cuotaEliminar = new Cuota();
                cuotaEliminar = cuotaBL.Buscar(pIdCuota);
                if (cuotaEliminar.N_IdCuota > 0)
                {
                    cuotaBL.Eliminar(pIdCuota);
                    retornaMensaje.CodigoRetorno = 0;
                    retornaMensaje.Mensage = string.Format(resMensajes.msjEliminadoOK, "Cuota");
                }
                else
                {
                    retornaMensaje.CodigoRetorno = -1;
                    retornaMensaje.Mensage = string.Format(resMensajes.msjNoBuscado, "Cuota");
                }
            }
            catch (Exception exception)
            {
                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoEliminado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString()
                    }
                    , new FaultReason(exception.Message));
            }
            return retornaMensaje;
        }

        #endregion

    }

}