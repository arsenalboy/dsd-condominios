using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

//using VisitasService.Dominio;
using Architects.Dominio;
using VisitasService.ProxyResidente;
using System.Xml.Linq;

namespace VisitasService
{   
    [ServiceContract]
    public interface IVisitaService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes", ResponseFormat = WebMessageFormat.Json)]
        List<VisitanteBE> ListarVisitantes_JSON();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/xml", ResponseFormat = WebMessageFormat.Xml)]
        List<VisitanteBE> ListarVisitantes_XML();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes?NroDoc={numdocumento}",
            ResponseFormat = WebMessageFormat.Json)]
        VisitanteBE BuscarVisitantePorNumDocumento_JSON(string numDocumento);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/xml?NroDoc={numdocumento}",
            ResponseFormat = WebMessageFormat.Xml)]
        VisitanteBE BuscarVisitantePorNumDocumento_XML(string numDocumento);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/Nombre/{nombre}",
            ResponseFormat = WebMessageFormat.Json)]
        List<VisitanteBE> BuscarVisitantesPorNombre_JSON(string nombre);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/xml/Nombre/{nombre}",
            ResponseFormat = WebMessageFormat.Xml)]
        List<VisitanteBE> BuscarVisitantesPorNombre_XML(string nombre);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/ID/{visitanteID}", ResponseFormat = WebMessageFormat.Json)]
        VisitanteBE ObtenerVisitantePorID_JSON(string visitanteID);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/xml/ID/{visitanteID}", ResponseFormat = WebMessageFormat.Xml)]
        VisitanteBE ObtenerVisitantePorID_XML(string visitanteID);
              
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/Fecha/{fechaVisita}",
            ResponseFormat = WebMessageFormat.Json)]
        List<VisitanteBE> BuscarVisitantesPorFechaVisita_JSON(string fechaVisita);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/xml/Fecha/{fechaVisita}",
            ResponseFormat = WebMessageFormat.Xml)]
        List<VisitanteBE> BuscarVisitantesPorFechaVisita_XML(string fechaVisita);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/Residente/{nroDocumento}",
            ResponseFormat = WebMessageFormat.Json)]
        List<VisitanteBE> BuscarVisitantesPorResidente_JSON(string nroDocumento);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/xml/Residente/{nroDocumento}",
            ResponseFormat = WebMessageFormat.Xml)]
        List<VisitanteBE> BuscarVisitantesPorResidente_XML(string nroDocumento);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/{page}?size={size}",
            ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<VisitanteBE> ListarVisitantesPaginado(string page, int size);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Visitantes/{nroDocumento},{fechaVisita},{nroDocResidente}",
            ResponseFormat = WebMessageFormat.Json)]
        List<VisitanteBE> BuscarVisitantesPorVariosFiltros(string nroDocumento, string fechaVisita, string nroDocResidente);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Visitantes", BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        VisitanteBE AgregarVisitante(XElement dataVisitante);        
    }
}
