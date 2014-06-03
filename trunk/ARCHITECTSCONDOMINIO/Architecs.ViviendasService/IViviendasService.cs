using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Architects.Dominio;

namespace Architecs.ViviendasService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IViviendasService
    {

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Viviendas", ResponseFormat = WebMessageFormat.Json)]
        RetornaMensaje CrearVivienda(ViviendaBE viviendaCrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Viviendas/{N_IdVivienda}", ResponseFormat = WebMessageFormat.Json)]
        ViviendaBE ObtenerVivienda(string N_IdVivienda);

        [OperationContract]
        [WebInvoke(
              Method = "PUT"
            , UriTemplate = "Viviendas/{N_IdVivienda}"
            , RequestFormat = WebMessageFormat.Json
            , ResponseFormat = WebMessageFormat.Json
            , BodyStyle = WebMessageBodyStyle.Bare)]
        RetornaMensaje ModificarVivienda(string N_IdVivienda, ViviendaBE viviendaModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Viviendas/{N_IdVivienda}", ResponseFormat = WebMessageFormat.Json)]
        RetornaMensaje EliminarVivienda(string N_IdVivienda);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Viviendas/", ResponseFormat = WebMessageFormat.Json)]
        List<ViviendaBE> ListarVivienda();
    }


}
