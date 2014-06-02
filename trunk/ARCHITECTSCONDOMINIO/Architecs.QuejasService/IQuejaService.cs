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
        [WebInvoke(Method="POST", UriTemplate="Quejas",ResponseFormat=WebMessageFormat.Xml)]
        Queja CrearQueja(Queja QuejaCrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Quejas/Todos/{FechaIni},{FechaFin}", ResponseFormat = WebMessageFormat.Xml)]
        List<Queja> ListarQuejas(string FechaIni, string FechaFin);
    }
}
