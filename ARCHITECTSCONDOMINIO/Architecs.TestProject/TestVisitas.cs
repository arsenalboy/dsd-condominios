using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Architects.Dominio;
using System.Runtime.Serialization;

namespace Architects.TestProject
{   
    [TestClass]
    public class TestVisitas
    {
        [TestMethod]
        public void Test_ListarVisitantes()
        {            
            HttpWebRequest req = WebRequest.Create("http://localhost:62061/VisitaService.svc/Visitantes") as HttpWebRequest;
            req.Method = "GET";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());

            string visitantesJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            var visitanteDeserializado = js.Deserialize<List<VisitanteBE>>(visitantesJson);

            Assert.AreNotEqual(0, visitanteDeserializado.Count);            
        }

        [TestMethod]
        public void Test_BuscarVisitantePorNumDocumento()
        {
            string strNumDoc = "78763091";
            string strUri = string.Format("http://localhost:62061/VisitaService.svc/Visitantes?NroDoc={0}", 
                Uri.EscapeUriString(strNumDoc));
            HttpWebRequest req = WebRequest.Create(strUri) as HttpWebRequest;
            req.Method = "GET";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());

            string visitantesJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            VisitanteBE visitanteDeserializado = js.Deserialize<VisitanteBE>(visitantesJson);
            Assert.AreEqual(strNumDoc, visitanteDeserializado.C_NumDocumento);
        }

        [TestMethod]
        public void Test_BuscarVisitantesPorNombre()
        {
            string strNombre = "Gino Assereto";
            string strUri = string.Format("http://localhost:62061/VisitaService.svc/Visitantes/Nombre/{0}", 
                Uri.EscapeUriString(strNombre));
            HttpWebRequest req = WebRequest.Create(strUri) as HttpWebRequest;
            req.Method = "GET";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());

            string visitantesJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<VisitanteBE> visitanteDeserializado = js.Deserialize<List<VisitanteBE>>(visitantesJson);
            Assert.AreEqual(strNombre, visitanteDeserializado[0].C_Nombre);
        }

        [TestMethod]
        public void Test_ObtenerVisitantePorID()
        {
            string strID = "1N";
            string strUri = string.Format("http://localhost:62061/VisitaService.svc/Visitantes/ID/{0}", strID);
            HttpWebRequest req = WebRequest.Create(strUri) as HttpWebRequest;
            req.Method = "GET";

            try
            {
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());

                string visitantesJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                VisitanteBE visitanteDeserializado = js.Deserialize<VisitanteBE>(visitantesJson);
                Assert.AreEqual(strID, visitanteDeserializado.N_IdVisitante.ToString());
            }
            catch (WebException ex)
            {
                HttpStatusCode code = ((HttpWebResponse)ex.Response).StatusCode;
                string message = ((HttpWebResponse)ex.Response).StatusDescription;
                StreamReader reader = new StreamReader(ex.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);
                Console.WriteLine(mensaje);
                Assert.AreEqual("ID de Visitante no existe", mensaje);
            }
            
        }

        [TestMethod]
        public void Test_BuscarVisitantesPorFechaVisita()
        {
            string strFechaVisita = "2014-04-24";
            string strUri = string.Format("http://localhost:62061/VisitaService.svc/Visitantes/xml/Fecha/{0}",
                Uri.EscapeUriString(strFechaVisita));
            HttpWebRequest req = WebRequest.Create(strUri) as HttpWebRequest;
            req.Method = "GET";

            try
            {
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());

                DataContractSerializer dcs = new DataContractSerializer(typeof(List<VisitanteBE>));
                List<VisitanteBE> visitantesDeserializados = (List<VisitanteBE>)dcs.ReadObject(reader.BaseStream);

                Assert.AreEqual(strFechaVisita, visitantesDeserializados[0].D_FecVisita.ToString("yyyy-MM-dd"));
            }
            catch (WebException ex)
            {
                HttpStatusCode code = ((HttpWebResponse)ex.Response).StatusCode;
                string message = ((HttpWebResponse)ex.Response).StatusDescription;
                StreamReader reader = new StreamReader(ex.Response.GetResponseStream());
                
                DataContractSerializer dcs = new DataContractSerializer(typeof(string));
                string mensaje = (string)dcs.ReadObject(reader.BaseStream);
                                
                Console.WriteLine(mensaje);
                Assert.AreEqual("Formato de Fecha Incorrecto", mensaje);
            }
        }

        [TestMethod]
        public void Test_BuscarVisitantesPorResidente()
        {
            string strNroDocResidente = "98239233";
            string strUri = string.Format("http://localhost:62061/VisitaService.svc/Visitantes/Residente/{0}",
                Uri.EscapeUriString(strNroDocResidente));
            HttpWebRequest req = WebRequest.Create(strUri) as HttpWebRequest;
            req.Method = "GET";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());

            string visitantesJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<VisitanteBE> visitanteDeserializado = js.Deserialize<List<VisitanteBE>>(visitantesJson);
            Assert.AreEqual(strNroDocResidente, visitanteDeserializado[0].O_ResidenteBE.C_NumDocume);
        }

        [TestMethod]
        public void Test_AgregarVisitante()
        {
            string strNroDocResidente = "98239233";
            StringBuilder postData = new StringBuilder(250);            
            postData.Append("<VisitanteBE>");
            postData.Append("<C_NumDocumento>72067642</C_NumDocumento>");
            postData.Append("<C_Nombre>Vania Bludau</C_Nombre>");
            postData.Append("<D_FecVisita>2014-04-17</D_FecVisita>");
            postData.Append("<O_ResidenteBE><C_NumDocume>98239233</C_NumDocume></O_ResidenteBE>");
            postData.Append("</VisitanteBE>");            

            byte[] data = Encoding.UTF8.GetBytes(postData.ToString());

            string strUri = "http://localhost:62061/VisitaService.svc/Visitantes";                

            HttpWebRequest req = WebRequest.Create(strUri) as HttpWebRequest;            
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/xml; charset=UTF-8";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            try
            {
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());

                DataContractSerializer dcs = new DataContractSerializer(typeof(VisitanteBE));
                VisitanteBE visitanteDeserializado = (VisitanteBE)dcs.ReadObject(reader.BaseStream);
              
                Assert.AreNotEqual(0, visitanteDeserializado.N_IdVisitante);
                Assert.AreEqual(strNroDocResidente, visitanteDeserializado.O_ResidenteBE.C_NumDocume);
            }
            catch (WebException ex)
            {                
                HttpStatusCode code = ((HttpWebResponse)ex.Response).StatusCode;
                string message = ((HttpWebResponse)ex.Response).StatusDescription;
                StreamReader reader = new StreamReader(ex.Response.GetResponseStream());

                DataContractSerializer dcs = new DataContractSerializer(typeof(string));
                string mensaje = (string)dcs.ReadObject(reader.BaseStream);
                                
                Console.WriteLine(mensaje);
                Assert.AreNotEqual(0, mensaje.Length);
            }            
        }
    }
}
