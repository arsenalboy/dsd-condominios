using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architecs.QuejasService.Dominio;
using Architecs.QuejasService.Persistencia;

namespace Architecs.QuejasService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "QuejaService" en el código, en svc y en el archivo de configuración a la vez.
    public class QuejaService : IQuejaService
    {
        private QuejaDAO ObjQUejaDAO = new QuejaDAO();

        public Queja CrearQueja(Queja QuejaCrear)
        {
            try
            {
                return ObjQUejaDAO.CreaQueja(QuejaCrear);
                //return ObjQUejaDAO.MensajeEncola(QuejaCrear);
            }
            catch (Exception)
            {
               //mandamos a la cola
                QuejaServiceMess.QuejaServiceMessageClient objquejaservice = new QuejaServiceMess.QuejaServiceMessageClient();
              
                QuejaServiceMess.Queja objqueja = new QuejaServiceMess.Queja();
                objqueja.N_IdQueja = QuejaCrear.N_IdQueja;
                objqueja.B_Estado = QuejaCrear.B_Estado;
                objqueja.C_Detalle = QuejaCrear.C_Detalle;
                objqueja.C_Motivo = QuejaCrear.C_Motivo;
                objqueja.C_Tipo = QuejaCrear.C_Tipo;
                objqueja.D_FecQueja = QuejaCrear.D_FecQueja;
                objqueja.D_FecRegistro = QuejaCrear.D_FecRegistro;
                objqueja.N_IdResidente = QuejaCrear.N_IdResidente;

                objqueja = objquejaservice.CrearQuejaMensaje(objqueja);

                return QuejaCrear;
            }
            
        }

        public List<Queja> ListarQuejas(string FechaIni, string FechaFin, string C_Tipo)
        {
            //antes que nada, recuperamos los mensaje y los almacenamos apra obtenerlos
            //////InsertaQuejaEnCola();
            return ObjQUejaDAO.listarQuejas(FechaIni, FechaFin, C_Tipo);
        }


        public void Actualizar(string N_IdQueja, string B_Estado)
        {
            ObjQUejaDAO.Actualizar(N_IdQueja, B_Estado);
        }


      
    }
}