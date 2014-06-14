using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Dominio;
using VisitasService.Persistencia;
using VisitasService.ProxyResidente;
using System.Globalization;
using System.Net;
using System.ServiceModel.Web;
using System.Xml.Linq;

namespace VisitasService
{    
    public class VisitaService : IVisitaService
    {
        IVisitanteDA objDA = new VisitanteDA();

        public List<VisitanteBE> ListarVisitantes_JSON()
        {
            return objDA.ListarVisitantes().ToList();
        }

        public List<VisitanteBE> ListarVisitantes_XML()
        {
            return objDA.ListarVisitantes().ToList();
        } 

        public VisitanteBE BuscarVisitantePorNumDocumento_JSON(string numDocumento)
        {
            List<VisitanteBE> listaVisitantes = null;
            VisitanteBE result = null;

            listaVisitantes = new List<VisitanteBE>(objDA.ListarVisitantes());

            var nvis = from l in listaVisitantes
                       where l.C_NumDocumento == numDocumento
                       select l;

            foreach (var item in nvis)
            {
                result = new VisitanteBE();
                result.N_IdVisitante = item.N_IdVisitante;
                result.C_NumDocumento = item.C_NumDocumento;
                result.C_Nombre = item.C_Nombre;
                result.D_FecVisita = item.D_FecVisita;
                result.B_Estado = item.B_Estado;
                result.O_ResidenteBE = item.O_ResidenteBE;                
            }

            return result;
        }

        public VisitanteBE BuscarVisitantePorNumDocumento_XML(string numDocumento)
        {
            return BuscarVisitantePorNumDocumento_JSON(numDocumento);
        }

        public List<VisitanteBE> BuscarVisitantesPorNombre_JSON(string nombre)
        {
            return objDA.BuscarVisitantes("", nombre, null, 0).ToList();
        }

        public List<VisitanteBE> BuscarVisitantesPorNombre_XML(string nombre)
        {
            return objDA.BuscarVisitantes("", nombre, null, 0).ToList();
        }

        public VisitanteBE ObtenerVisitantePorID_JSON(string visitanteID)
        {
            List<VisitanteBE> listaVisitantes = null;
            VisitanteBE result = null;
            
            try
            {
                int vlnVisitanteID = Int32.TryParse(visitanteID, out vlnVisitanteID) ? Int32.Parse(visitanteID) : 0;

                if (vlnVisitanteID == 0)                
                    throw new WebFaultException<string>("ID de Visitante no existe", HttpStatusCode.InternalServerError);                

                listaVisitantes = new List<VisitanteBE>(objDA.ListarVisitantes());

                var nvis = from l in listaVisitantes
                           where l.N_IdVisitante == vlnVisitanteID
                           select l;

                foreach (var item in nvis)
                {
                    result = new VisitanteBE();
                    result.N_IdVisitante = item.N_IdVisitante;
                    result.C_NumDocumento = item.C_NumDocumento;
                    result.C_Nombre = item.C_Nombre;
                    result.D_FecVisita = item.D_FecVisita;
                    result.B_Estado = item.B_Estado;
                    result.O_ResidenteBE = item.O_ResidenteBE;
                }

                return result;
            }
            catch (WebFaultException ex)
            {                
                throw ex;
            }            
        }

        public VisitanteBE ObtenerVisitantePorID_XML(string visitanteID)
        {
            try
            {
                return ObtenerVisitantePorID_JSON(visitanteID);
            }
            catch (WebFaultException ex)
            {                
                throw ex;
            }            
        }

        /// <summary>
        /// Busca Visitantes por fecha de Visita
        /// </summary>
        /// <param name="fechaVisita">(yyyy-MM-dd) o (yyyy-dd-MM) o (dd-MM-yyyy) o (MM-dd-yyyy)</param>
        /// <returns></returns>
        public List<VisitanteBE> BuscarVisitantesPorFechaVisita_JSON(string fechaVisita)
        {
            const DateTimeStyles style = DateTimeStyles.AllowWhiteSpaces;
            DateTime dtTemp= DateTime.Now.Date;
            DateTime? dtFechaVisita = null;

            try
            {
                if (DateTime.TryParseExact(fechaVisita, "yyyy-MM-dd", CultureInfo.InvariantCulture, style, out dtTemp)
               || DateTime.TryParseExact(fechaVisita, "yyyy-dd-MM", CultureInfo.InvariantCulture, style, out dtTemp)
               || DateTime.TryParseExact(fechaVisita, "dd-MM-yyyy", CultureInfo.InvariantCulture, style, out dtTemp)
               || DateTime.TryParseExact(fechaVisita, "MM-dd-yyyy", CultureInfo.InvariantCulture, style, out dtTemp))
                    dtFechaVisita = dtTemp;

                if (dtFechaVisita.HasValue)
                    return objDA.BuscarVisitantes("", "", dtFechaVisita, 0).ToList();
                else
                    throw new WebFaultException<string>("Formato de Fecha Incorrecto", HttpStatusCode.InternalServerError);
            }
            catch (WebFaultException)
            {
                throw new WebFaultException<string>("Formato de Fecha Incorrecto", HttpStatusCode.InternalServerError);
            }        
        }

        /// <summary>
        /// Busca Visitantes por fecha de Visita
        /// </summary>
        /// <param name="fechaVisita">(yyyy-MM-dd) o (yyyy-dd-MM) o (dd-MM-yyyy) o (MM-dd-yyyy)</param>
        /// <returns></returns>
        public List<VisitanteBE> BuscarVisitantesPorFechaVisita_XML(string fechaVisita)
        {
            try
            {
                return BuscarVisitantesPorFechaVisita_JSON(fechaVisita);
            }
            catch (WebFaultException ex)
            {                
                throw ex;
            }            
        }

        public List<VisitanteBE> BuscarVisitantesPorVariosFiltros(string nroDocumento, string fechaVisita, string nroDocResidente)
        {
            ResidenteServiceClient client = new ResidenteServiceClient();
            const DateTimeStyles style = DateTimeStyles.AllowWhiteSpaces;
            DateTime dtTemp = DateTime.Now.Date;
            DateTime? dtFechaVisita = null;
            List<VisitanteBE> VisitantesEncontrados = new List<VisitanteBE>();

            try
            {
                Architects.Dominio.ResidenteBE residente = GetEntity(client.ObtenerResidentePorNroDocumento(nroDocResidente));

               if (DateTime.TryParseExact(fechaVisita, "yyyy-MM-dd", CultureInfo.InvariantCulture, style, out dtTemp)
               || DateTime.TryParseExact(fechaVisita, "yyyy-dd-MM", CultureInfo.InvariantCulture, style, out dtTemp)
               || DateTime.TryParseExact(fechaVisita, "dd-MM-yyyy", CultureInfo.InvariantCulture, style, out dtTemp)
               || DateTime.TryParseExact(fechaVisita, "MM-dd-yyyy", CultureInfo.InvariantCulture, style, out dtTemp))
                    dtFechaVisita = dtTemp;

                if (!dtFechaVisita.HasValue)
                    throw new WebFaultException<string>("Formato de Fecha Incorrecto", HttpStatusCode.InternalServerError);                                

                if (residente != null)
                    VisitantesEncontrados = new List<VisitanteBE>(objDA.BuscarVisitantes(nroDocumento
                        , "", dtFechaVisita, residente.N_IdResidente));

                for (int i = 0; i < VisitantesEncontrados.Count; i++)
                {
                    VisitantesEncontrados[i].O_ResidenteBE = residente;
                }

                return VisitantesEncontrados;
            }
            catch (WebFaultException ex)
            {
                throw ex;
            }
        }

        public List<VisitanteBE> BuscarVisitantesPorResidente_JSON(string NroDocumento)
        {
            ResidenteServiceClient client = new ResidenteServiceClient();

            try
            {
                Architects.Dominio.ResidenteBE residente = GetEntity(client.ObtenerResidentePorNroDocumento(NroDocumento));

                List<VisitanteBE> VisitantesEncontrados = new List<VisitanteBE>();

                if (residente != null)
                    VisitantesEncontrados = new List<VisitanteBE>(objDA.BuscarVisitantes("", "", null, residente.N_IdResidente));

                for (int i = 0; i < VisitantesEncontrados.Count; i++)
                {
                    VisitantesEncontrados[i].O_ResidenteBE = residente;
                }

                return VisitantesEncontrados;
            }
            catch (WebFaultException ex)
            {                
                throw ex;
            }           
        }

        public List<VisitanteBE> BuscarVisitantesPorResidente_XML(string NroDocumento)
        {
            try
            {
                return BuscarVisitantesPorResidente_JSON(NroDocumento);
            }
            catch (WebFaultException ex)
            {
                throw ex;
            }
        }

        public VisitanteBE AgregarVisitante(XElement dataVisitante)
        {
            ResidenteServiceClient client = new ResidenteServiceClient();
            VisitanteBE visitante =  new VisitanteBE();
            //IDictionary<string, string> lista = new Dictionary<string, string>();
            
            try
            {
                //IEnumerable<XElement> childList = from el in dataVisitante.Elements() select el;
                //foreach (XElement e in childList)                
                //    lista.Add(e.Name.ToString(), e.Value);                

                visitante.C_NumDocumento = dataVisitante.Element("C_NumDocumento").Value;
                visitante.C_Nombre = dataVisitante.Element("C_Nombre").Value;
                visitante.D_FecVisita = DateTime.ParseExact(dataVisitante.Element("D_FecVisita").Value,
                        "yyyy-MM-dd", CultureInfo.InvariantCulture);
                visitante.O_ResidenteBE.C_NumDocume = dataVisitante.Element("O_ResidenteBE").Element("C_NumDocume").Value;
                
                Architects.Dominio.ResidenteBE residente = GetEntity(client.ObtenerResidentePorNroDocumento(visitante.O_ResidenteBE.C_NumDocume));
                visitante.O_ResidenteBE = residente;

                int NewID = objDA.AgregarVisitante(visitante);
                return ObtenerVisitantePorID_JSON(NewID.ToString());
            }
            catch (WebFaultException ex)
            {
                throw ex;
            }            
        }

        public IEnumerable<VisitanteBE> ListarVisitantesPaginado(string page, int size)
        {
            List<VisitanteBE> listaVisitantes = new List<VisitanteBE>();
            int nPage = 0;

            if (Int32.TryParse(page, out nPage))
                listaVisitantes = new List<VisitanteBE>(objDA.ListarVisitantes());
            else
                throw new WebFaultException<string>("valor de página no válida", HttpStatusCode.InternalServerError);

            return listaVisitantes.OrderBy(c => c.N_IdVisitante).Skip(nPage * size).Take(size);
        }

        private static Architects.Dominio.ResidenteBE GetEntity(ProxyResidente.ResidenteBE dataContract)
        {
            Architects.Dominio.ResidenteBE entResidente = new Architects.Dominio.ResidenteBE();
            entResidente.N_IdResidente = dataContract.N_IdResidente;
            entResidente.C_NumDocume = dataContract.C_NumDocume;
            entResidente.C_Nombre = dataContract.C_Nombre;
            entResidente.C_Apellidos = dataContract.C_Apellidos;
            entResidente.D_FecNacimi = dataContract.D_FecNacimi;
            entResidente.B_Estado = dataContract.B_Estado;
            entResidente.C_Correo = dataContract.C_Correo;
            entResidente.C_Clave = dataContract.C_Clave;
            entResidente.N_TipoDoc = dataContract.N_TipoDoc;
            return entResidente;
        }

        private static ProxyResidente.ResidenteBE GetDataContract(Architects.Dominio.ResidenteBE Entity)
        {
            ProxyResidente.ResidenteBE dataContract = new ProxyResidente.ResidenteBE();
            dataContract.N_IdResidente = Entity.N_IdResidente;
            dataContract.C_NumDocume = Entity.C_NumDocume;
            dataContract.C_Nombre = Entity.C_Nombre;
            dataContract.C_Apellidos = Entity.C_Apellidos;
            dataContract.D_FecNacimi = Entity.D_FecNacimi;
            dataContract.B_Estado = Entity.B_Estado;
            dataContract.C_Correo = Entity.C_Correo;
            dataContract.C_Clave = Entity.C_Clave;
            dataContract.N_TipoDoc = Entity.N_TipoDoc;
            return dataContract;
        }
    }
}
