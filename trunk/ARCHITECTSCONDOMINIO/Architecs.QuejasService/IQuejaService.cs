using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using Architecs.QuejasService.Dominio;

namespace Architecs.QuejasService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IQuejaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IQuejaService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Quejas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Queja CrearQueja(Queja QuejaCrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Quejas/Todos/{FechaIni},{FechaFin},{C_Tipo}", ResponseFormat = WebMessageFormat.Json)]
        List<Queja> ListarQuejas(string FechaIni, string FechaFin, string C_Tipo);

        [OperationContract]
        [WebInvoke(Method = "UPDATE", UriTemplate = "Quejas/{N_IdQueja},{B_Estado}", RequestFormat = WebMessageFormat.Json)]
        void Actualizar(string N_IdQueja, string B_Estado);
    }
}
