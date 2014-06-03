using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;


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
                               "\"C_NumDpto\":\"Dv0X\"," + 
                               "\"N_NumMetros\":\"110\"," + 
                               "\"C_CodTipo\":\"depa\" }"; //JSON
            
            
            byte[] data = Encoding.UTF8.GetBytes(postdata);

            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:62023/ViviendasService.svc/Viviendas");

            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string alumnoJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            RetornaMensajeT retornaMensaje = js.Deserialize<RetornaMensajeT>(alumnoJson);

            Assert.AreNotEqual(0, retornaMensaje.CodigoRetorno);


        }


        [TestMethod]
        public void ViviendaListarTest()
        {
            // Prueba de OBTENER un alumno vía HTTP GET

            string strURL = "http://localhost:62023/ViviendasService.svc/Viviendas/";
          //string strURL = "http://localhost:1275/Alumnos.svc/Alumnos";
            HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
               .Create(strURL);
            reqObtener.Method = "GET";
            HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
            StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
            string alumnoJsonObtener = readerObtener.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            IList<Vivienda> alumnoCreado = js.Deserialize<List<Vivienda>>(alumnoJsonObtener);

            Assert.AreNotEqual(0, alumnoCreado.Count);

        }

        //[TestMethod]
        //public void ViviendaListar00202Test()
        //{
        //    ViviendasService.ViviendasService xx = new ViviendasService.ViviendasService();
        //    List<ViviendaBE> lstListado = new List<ViviendaBE>();
        //    lstListado = xx.ListarVivienda();

        //    Assert.AreNotEqual(0, lstListado.Count);
        //}

        //[TestMethod]
        //public void ViviendaiNSERTARtar00202Test()
        //{
        //    ViviendasService.ViviendasService xx = new ViviendasService.ViviendasService();
        //    ViviendaBE ITEMListado = new ViviendaBE();
        //    RetornaMensaje X = new RetornaMensaje();

        //    ITEMListado.C_NumDpto = "XXX";
        //    ITEMListado.C_NumEdificio = "XEFX";
        //    ITEMListado.N_IdResidente = 1;
        //    ITEMListado.N_NumMetros = 120;
        //    ITEMListado.C_CodTipo = "CAS";

        //    X = xx.CrearVivienda(ITEMListado);

        //    Assert.AreNotEqual(0, X.CodigoRetorno);
        //}


        //[TestMethod]
        //public void ViviendaiNSERTARtar00202Test()
        //{
        //    ViviendasService.ViviendasService xx = new ViviendasService.ViviendasService();
        //    ViviendaBE ITEMListado = new ViviendaBE();
        //    RetornaMensaje X = new RetornaMensaje();

        //    ITEMListado.N_IdVivienda=8
        //    ITEMListado.C_NumDpto = "XXX";
        //    ITEMListado.C_NumEdificio = "XEFX";
        //    ITEMListado.N_IdResidente = 1;
        //    ITEMListado.N_NumMetros = 120;
        //    ITEMListado.C_CodTipo = "CAS";

        //    X = xx.uP(ITEMListado);

        //    Assert.AreNotEqual(0, X.CodigoRetorno);
        //}
    }
}
