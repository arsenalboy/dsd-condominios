using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Architecs.Test;
using Architecs.Test.Entidades;


namespace Architecs.TestProject
{
    [TestClass]
    public class ViviendasServiceTest
    {
        [TestMethod]
        public void ViviendaCrearTest()
        {
            // Prueba de creación de vivienda vía HTTP POST
            string postdata = "{\"N_IdResidente\":\"29\","+ 
                               "\"C_NumEdificio\":\"8524\"," +
                               "\"C_NumDpto\":\"Dv66\"," + 
                               "\"N_NumMetros\":\"110\"," + 
                               "\"C_CodTipo\":\"depa\" }"; //JSON
            
            byte[] data = Encoding.UTF8.GetBytes(postdata);

            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:59151/ViviendasService.svc/Viviendas");

            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string viviendaJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            RetornaMensaje retornaMensaje = js.Deserialize<RetornaMensaje>(viviendaJson);

            Assert.AreNotEqual(0, retornaMensaje.CodigoRetorno);


        }

        [TestMethod]
        public void ViviendaListarTest()
        {
            // Prueba de OBTENER un vivienda vía HTTP GET

            string strURL = "http://localhost:59151/ViviendasService.svc/Viviendas/";
            HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
               .Create(strURL);
            reqObtener.Method = "GET";
            HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
            StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
            string viviendaJsonObtener = readerObtener.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            IList<Vivienda> viviendaCreado = js.Deserialize<List<Vivienda>>(viviendaJsonObtener);

            Assert.AreNotEqual(0, viviendaCreado.Count);

        }

        [TestMethod]
        public void ViviendaEliminarTest()
        {
            string strIDvivienda = "16";
            string strURL = "http://localhost:59151/ViviendasService.svc/Viviendas";
            string strID = strIDvivienda;
            HttpWebRequest reqEliminar = (HttpWebRequest)WebRequest
               .Create(strURL + "/" + strID);
            reqEliminar.Method = "DELETE";
            HttpWebResponse resEliminar = (HttpWebResponse)reqEliminar.GetResponse();

            string strURL2 = "http://localhost:59151/ViviendasService.svc/Viviendas";
            string strID2 = strIDvivienda;
            HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
               .Create(strURL2 + "/" + strID2);
            reqObtener.Method = "GET";
            HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
            StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
            string viviendaJsonObtener = readerObtener.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Vivienda viviendaEliminada = js.Deserialize<Vivienda>(viviendaJsonObtener);


            Assert.AreEqual(null, viviendaEliminada);
        }

        [TestMethod]
        public void ViviendaBuscarTest()
        {
            string IDvivienda = "2";
            string strURL = "http://localhost:59151/ViviendasService.svc/Viviendas";

            HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
               .Create(strURL + "/" + IDvivienda);
            reqObtener.Method = "GET";
            HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
            StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
            string viviendaJsonObtener = readerObtener.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Vivienda viviendaCreado = js.Deserialize<Vivienda>(viviendaJsonObtener);

            Assert.AreEqual(Convert.ToInt32(IDvivienda), viviendaCreado.N_IdVivienda);
        }


        [TestMethod]
        public void ViviendaiNSERTARtar00202Test()
        {
            string postdata = "{" + //\"N_IdVivienda\":\"29\"," +
            "\"N_IdResidente\":\"29\"," +
            "\"C_NumEdificio\":\"8524\"," +
            "\"C_NumDpto\":\"Dv0Z\"," +
            "\"N_NumMetros\":\"110\"," +
            "\"C_CodTipo\":\"DEPA\" }"; //JSON

            string strIdVivienda = "2";
            byte[] data = Encoding.UTF8.GetBytes(postdata);

            HttpWebRequest req = (HttpWebRequest)WebRequest
                 .Create("http://localhost:59151/ViviendasService.svc/Viviendas/" + strIdVivienda); //ConfigurationManager.AppSettings["URL_REST_vivienda"].ToString()

            req.Method = "PUT";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string retornaMensajeJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            RetornaMensaje retornaMensaje = js.Deserialize<RetornaMensaje>(retornaMensajeJson);

            Assert.AreNotEqual(true, retornaMensaje.Exito);
        }
    }
}
