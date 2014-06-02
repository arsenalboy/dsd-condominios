using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Architecs.ViviendasService.Persistencia;
using Architects.Dominio;
using System.Net;

namespace Architecs.ViviendasService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    public class ViviendasService : IViviendasService
    {
        private ViviendaDAO viviendaDAO = null;
        private RetornaMensaje retornaMensaje = null;

        public RetornaMensaje CrearVivienda(ViviendaBE viviendaCrear)
        {
            //List<ViviendaBE> lstViviendaBuscar = null;
            try
            {
                retornaMensaje = new RetornaMensaje();
                viviendaDAO = new ViviendaDAO();
                //lstViviendaBuscar = viviendaDAO.Buscar(viviendaCrear);
                //if (lstViviendaBuscar.Count == 0)
                //{
                    retornaMensaje.CodigoRetorno = viviendaDAO.Registrar(viviendaCrear);
                    retornaMensaje.Mensage = string.Format(resMensajes.msjGuardadoOK, "Vivienda");
                    retornaMensaje.Exito = true;
                //}
                //else
                //{
                //    RetornaMensaje mensajeError = new RetornaMensaje
                //    {
                //        CodigoRetorno = -1,
                //        Mensage = string.Format(resMensajes.msjYaExiste, "Vivienda"),
                //        Exito = false,
                //    };
                //    throw new WebFaultException<RetornaMensaje>(mensajeError, HttpStatusCode.InternalServerError);
                //}
            }
            catch (Exception exception)
            {
            
                 RetornaMensaje mensajeError = new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoRegistrado + " - " + exception.Message, "Vivienda"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = false
                    };
                 throw new WebFaultException<RetornaMensaje>(mensajeError, HttpStatusCode.InternalServerError);
                    
            }
            return retornaMensaje;
        }

        public ViviendaBE ObtenerVivienda(string codVivienda)
        {
            ViviendaBE vivienda = new ViviendaBE();
            try
            {
                retornaMensaje = new RetornaMensaje(); 
                viviendaDAO = new ViviendaDAO();
                vivienda = viviendaDAO.Buscar(Convert.ToInt32(codVivienda));
            }
            catch (Exception exception)
            {
                RetornaMensaje mensajeError = new RetornaMensaje
                    {
                         Mensage = string.Format(resMensajes.msjNoBuscado, "Vivienda"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = false
                    };
                throw new WebFaultException<RetornaMensaje>(mensajeError, HttpStatusCode.InternalServerError);
            }
            return vivienda;
        }


        public List<ViviendaBE> ListarVivienda()
        {
            List<ViviendaBE> lstCuota = new List<ViviendaBE>();
            try
            {
                viviendaDAO = new ViviendaDAO();

                lstCuota = viviendaDAO.Listar(null, null);
            }
            catch (Exception exception)
            {

                throw new FaultException<RetornaMensaje>
                    (new RetornaMensaje
                    {
                        Mensage = string.Format(resMensajes.msjNoListado, "Vivienda"),
                        CodigoError = exception.GetHashCode().ToString(),
                        Exito = true
                    }
                    , new FaultReason(exception.Message));
            }
            return lstCuota;
        }

    }
}
