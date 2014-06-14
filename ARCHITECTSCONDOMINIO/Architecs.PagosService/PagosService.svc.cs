using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Architecs.PagosService.Persistencia;
using Architects.Dominio;
using System.Messaging;
using System.Configuration;

namespace Architecs.PagosService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PagosService" in code, svc and config file together.
    public class PagosService : IPagosService
    {
        TipoPagoDAO tipoPagoDAO = null;
        CuotaDAO cuotaDAO = null;
        RetornaMensaje retornaMensaje = null;

        #region Tabla: TipoPago

        public IList<TipoPago> ListarTipoPago()
        {
            tipoPagoDAO = new TipoPagoDAO();
            IList<TipoPago> lstTipoPago;
            lstTipoPago = tipoPagoDAO.Listar();
            return lstTipoPago;
        }

        public RetornaMensaje RegistrarTipoPago(string Descripcion)
        {
            try
            {
                retornaMensaje = new RetornaMensaje();
                tipoPagoDAO = new TipoPagoDAO();
                TipoPago tipoPago = new TipoPago();

                tipoPago.B_Estado = true;
                tipoPago.C_Descripcion = Descripcion;
                
                retornaMensaje.CodigoRetorno = tipoPagoDAO.Registrar(tipoPago);
                retornaMensaje.Mensage = string.Format(resMensajes.msjGuardadoOK, "Tipo de Pago");
                retornaMensaje.Exito = true;
            }
            catch (Exception exception)
            {
                throw new FaultException<RetornaMensaje>
                                   (new RetornaMensaje
                                   {
                                       Mensage = string.Format(resMensajes.msjNoRegistrado, "Tipo de Pago"),
                                       CodigoError = exception.GetHashCode().ToString(),
                                       Exito = false
                                   }
                                   , new FaultReason(exception.Message));
            }
            return retornaMensaje;
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
        public RetornaMensaje RegistrarCuota(string C_Periodo, int N_IdVivienda, double N_Importe, string D_FecVncto)
        {
            Cuota cuotaBuscar = null;
            try
            {
                retornaMensaje = new RetornaMensaje();
                cuotaDAO = new CuotaDAO();
                cuotaBuscar = cuotaDAO.Buscar(C_Periodo, N_IdVivienda);
                if (cuotaBuscar == null)
                {
                    Cuota cuota = new Cuota
                    {
                        C_Periodo = C_Periodo,
                        N_IdVivienda = N_IdVivienda,
                        N_Importe = Convert.ToDecimal(N_Importe),
                        D_FecVncto = Convert.ToDateTime(D_FecVncto)
                    };
                    retornaMensaje.CodigoRetorno = cuotaDAO.Registrar(cuota);
                    retornaMensaje.Mensage = string.Format(resMensajes.msjGuardadoOK, "Cuota");
                    retornaMensaje.Exito = true;
                }
                else
                {
                    retornaMensaje.CodigoRetorno = -1;
                    retornaMensaje.Mensage = string.Format(resMensajes.msjYaExiste, "Cuota");
                    retornaMensaje.Exito = false;
                }
            }
            catch (Exception exception)
            {
                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoRegistrado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = false
                    }
                    , new FaultReason(exception.Message));
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
        public RetornaMensaje ActualizarCuota(int pIdCuota, string pPeriodo, int pIdVivienda, double pImporte, string pFecVncto)
        {
            try
            {
                retornaMensaje = new RetornaMensaje();
                cuotaDAO = new CuotaDAO();
                Cuota cuotaBuscar = null;
                cuotaBuscar = cuotaDAO.Buscar(pPeriodo, pIdVivienda);
                if (cuotaBuscar != null)
                {
                    Cuota cuota = new Cuota
                    {
                        N_IdCuota = pIdCuota,
                        C_Periodo = pPeriodo,
                        N_IdVivienda = pIdVivienda,
                        N_Importe = Convert.ToDecimal(pImporte),
                        D_FecVncto = Convert.ToDateTime(pFecVncto)
                    };
                    retornaMensaje.CodigoRetorno = cuotaDAO.Actualizar(cuota);
                    retornaMensaje.Mensage = string.Format(resMensajes.msjGuardadoOK, "Cuota");
                    retornaMensaje.Exito = true;
                }
                else
                {
                    retornaMensaje.CodigoRetorno = -1;
                    retornaMensaje.Mensage = string.Format(resMensajes.msjYaExiste, "Cuota");
                    retornaMensaje.Exito = false;
                }
            }
            catch (Exception exception)
            {
                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoRegistrado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = false
                    }
                    , new FaultReason(exception.Message));
            }
            return retornaMensaje;
        }

        public RetornaMensaje PagarCuota(int pIdCuota, string pFecPago, string pNumDeposito, int pTipoPago)
        {
            retornaMensaje = new RetornaMensaje();
            try
            {
                try
                {
                    DateTime fechaPago = Convert.ToDateTime(pFecPago);
                }
                catch (Exception ex)
                {
                    retornaMensaje.CodigoRetorno = -1;
                    retornaMensaje.Mensage = string.Format("Firmato de fecha es INCORRECTO.", "Cuota");
                    retornaMensaje.Exito = false;
                    return retornaMensaje;
                }
                //** SE GUARDARA EL PAGO DEL CLIENTE EN UNA COLA DE MENSAJES.

                string rutaCola = ConfigurationManager.AppSettings["DireccionMSQColas"].ToString(); // @".\private$\CondominioCola";
                if (!MessageQueue.Exists(rutaCola))
                    MessageQueue.Create(rutaCola);
                MessageQueue cola = new MessageQueue(rutaCola);
                Message mensaje = new Message();
                mensaje.Label = "Nuevo Pago registrado de RESIDENTE ";
                mensaje.Body = new Cuota()
                {
                    D_FecPago = Convert.ToDateTime(pFecPago),
                    C_NumDeposito = pNumDeposito,
                    N_IdCuota = pIdCuota,
                    N_IdTipoPago = pTipoPago
                };
                cola.Send(mensaje);
                retornaMensaje.CodigoRetorno = 1;
                retornaMensaje.Mensage = string.Format(resMensajes.msjGuardadoOK+" , En cola para su validación.", "Cuota");
                retornaMensaje.Exito = true;

                //retornaMensaje = new RetornaMensaje();
                //cuotaDAO = new CuotaDAO();
                //Cuota cuotaBuscar = null;
                //cuotaBuscar = cuotaDAO.Buscar(pPeriodo, pIdVivienda);
                //if (cuotaBuscar != null)
                //{
                //    Cuota cuota = new Cuota
                //    {
                //        N_IdCuota = pIdCuota,
                //        C_Periodo = pPeriodo,
                //        N_IdVivienda = pIdVivienda,
                //        N_Importe = Convert.ToDecimal(pImporte),
                //        D_FecVncto = Convert.ToDateTime(pFecVncto)
                //    };
                //    retornaMensaje.CodigoRetorno = cuotaDAO.Actualizar(cuota);
                //    retornaMensaje.Mensage = string.Format(resMensajes.msjGuardadoOK, "Cuota");
                //    retornaMensaje.Exito = true;
                //}
                //else
                //{
                //    retornaMensaje.CodigoRetorno = -1;
                //    retornaMensaje.Mensage = string.Format(resMensajes.msjYaExiste, "Cuota");
                //    retornaMensaje.Exito = false;
                //}
            }
            catch (Exception exception)
            {
                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoRegistrado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = false
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
                cuotaDAO = new CuotaDAO();

                lstCuota = cuotaDAO.Listar(pPeriodo);
            }
            catch (Exception exception)
            {

                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoListado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = true
                    }
                    , new FaultReason(exception.Message));
            }
            return lstCuota;
        }


        public List<Cuota> ListarCuotaPorResidente(string pCorreoResidente)
        {
            List<Cuota> lstCuota = new List<Cuota>();
            try
            {
                cuotaDAO = new CuotaDAO();

                lstCuota = cuotaDAO.ListarPorResidente(pCorreoResidente);
            }
            catch (Exception exception)
            {

                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoListado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = true
                    }
                    , new FaultReason(exception.Message));
            }
            return lstCuota;
        }


        public List<Cuota> ListarCuotaMorosas(string pPeriodo)
        {
            List<Cuota> lstCuota = new List<Cuota>();
            try
            {
                cuotaDAO = new CuotaDAO();

                /* LEER LA COLA DE MENSAJES Y GUARDAR EN BASE DE DATOS */
                string rutaCola = ConfigurationManager.AppSettings["DireccionMSQColas"].ToString(); // @".\private$\CondominioCola";
                MessageQueue cola = new MessageQueue(rutaCola);
                int cantidadMensajes = cola.GetAllMessages().Count();
                if (cantidadMensajes > 0)
                    foreach (Message mensajeTodo in cola.GetAllMessages())
                    {
                        cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Cuota) });
                        Message mensaje = cola.Receive();
                        Cuota pagoCuota = (Cuota)mensaje.Body;

                        int cuotaRegistrado = -1;
                        cuotaRegistrado = cuotaDAO.PagarCuota(pagoCuota);
                    }

                /* FIN LEER LA COLA DE MENSAJES Y GUARDAR EN BASE DE DATOS */

                lstCuota = cuotaDAO.ListarMorosos(pPeriodo);
            }
            catch (Exception exception)
            {

                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoListado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = true
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
                cuotaDAO = new CuotaDAO();
                cuota = cuotaDAO.Buscar(pIdCuota);
            }
            catch (Exception exception)
            {
                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoBuscado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = false
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
            retornaMensaje = new RetornaMensaje();
            try
            {
                cuotaDAO = new CuotaDAO();
                Cuota cuotaEliminar = new Cuota();
                cuotaEliminar = cuotaDAO.Buscar(pIdCuota);
                if (cuotaEliminar.N_IdCuota > 0)
                {
                    cuotaDAO.Eliminar(pIdCuota);
                    retornaMensaje.CodigoRetorno = 0;
                    retornaMensaje.Mensage = string.Format(resMensajes.msjEliminadoOK, "Cuota");
                    retornaMensaje.Exito = true;
                }
                else
                {
                    retornaMensaje.CodigoRetorno = -1;
                    retornaMensaje.Mensage = string.Format(resMensajes.msjNoBuscado, "Cuota");
                    retornaMensaje.Exito = false;
                }
            }
            catch (Exception exception)
            {
                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoEliminado, "Cuota"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = false
                    }
                    , new FaultReason(exception.Message));
            }
            return retornaMensaje;
        }

        #endregion
    }
}
