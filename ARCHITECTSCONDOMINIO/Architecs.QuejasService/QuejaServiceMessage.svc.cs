using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architecs.QuejasService.Persistencia;
using Architecs.QuejasService.Dominio;

namespace Architecs.QuejasService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "QuejaServiceMessage" en el código, en svc y en el archivo de configuración a la vez.
    public class QuejaServiceMessage : IQuejaServiceMessage
    {
        private QuejaDAO ObjQUejaDAO = new QuejaDAO();
        public Queja CrearQuejaMensaje(Queja QuejaCrear)
        {
            return ObjQUejaDAO.MensajeEncola(QuejaCrear);
        }

        public int InsertaQuejaEnCola()
        {
            return ObjQUejaDAO.InsertaQuejaEnCola();
        }
    }
}
