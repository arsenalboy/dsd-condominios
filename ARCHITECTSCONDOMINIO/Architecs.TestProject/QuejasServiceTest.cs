using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Architecs.TestProject.Dominio;

namespace Architecs.TestProject
{
    /// <summary>
    /// Descripción resumida de QuejasServiceTest
    /// </summary>
    [TestClass]
    public class QuejasServiceTest
    {
        [TestMethod]
        public void AlumnoCrearTest()
        {

            string postdata = "{\"N_IdResidente\":2, \"C_Tipo\":\"Leve\",\"C_Motivo\":\"Motivo Prueba\",\"C_Detalle\":\"Detalle Prueba\",\"D_FecQueja\":\"2014-06-03\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:62070/QuejaService.svc/Quejas");

            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string alumnoJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Queja QuejaCreada = js.Deserialize<Queja>(alumnoJson);


            Assert.AreEqual(2, QuejaCreada.N_IdResidente);
            Assert.AreEqual("Leve", QuejaCreada.C_Tipo);
            Assert.AreEqual("Motivo Prueba", QuejaCreada.C_Motivo);
            Assert.AreEqual("Detalle Prueba", QuejaCreada.C_Detalle);
            Assert.AreEqual("2014-06-03", QuejaCreada.D_FecQueja);

        }

        [TestMethod]
        public void AlumnoListarTest()
        {

            string strURL = "http://localhost:62070/QuejaService.svc/Quejas/Todos/2000-01-01,2015-01-01,Todos";
            HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
               .Create(strURL);
            reqObtener.Method = "GET";
            HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
            StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
            string QuejasObtener = readerObtener.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            IList<Queja> ListaQuejas = js.Deserialize<List<Queja>>(QuejasObtener);

            //ya que no me salio como cargarlo directamente a la grilla lo pase a otra lista
            List<QuejaConsulta> ObjQuejaConsulta = new List<QuejaConsulta>();

            foreach (Queja QUEJA in ListaQuejas)
            {
                QuejaConsulta QUEJACON = new QuejaConsulta();
                QUEJACON.N_IdQueja = QUEJA.N_IdQueja;
                QUEJACON.N_IdResidente = QUEJA.N_IdResidente;
                QUEJACON.C_Nombre = QUEJA.Residente.C_Nombre;
                QUEJACON.B_Estado = QUEJA.B_Estado;
                QUEJACON.C_Detalle = QUEJA.C_Detalle;
                QUEJACON.C_Motivo = QUEJA.C_Motivo;
                QUEJACON.C_NumDocume = QUEJA.Residente.C_NumDocume;
                QUEJACON.C_Tipo = QUEJA.C_Tipo;
                QUEJACON.D_FecQueja = QUEJA.D_FecQueja;
                QUEJACON.D_FecRegistro = QUEJA.D_FecRegistro;
                ObjQuejaConsulta.Add(QUEJACON);
            }

            Assert.AreNotEqual(0, ObjQuejaConsulta.Count);

            // Prueba de OBTENER un alumno vía HTTP GET

        

        }

    }
}
