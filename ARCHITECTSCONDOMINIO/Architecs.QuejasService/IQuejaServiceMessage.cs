using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architecs.QuejasService.Dominio;

namespace Architecs.QuejasService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IQuejaServiceMessage" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IQuejaServiceMessage
    {
        //-----------------MESSAGE------------------------------
        [OperationContract]
        Queja CrearQuejaMensaje(Queja QuejaCrear);

        [OperationContract]
        int InsertaQuejaEnCola();
    }
}
