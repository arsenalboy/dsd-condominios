using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Architecs.Test;

namespace Architecs.Test
{
    /// <summary>
    /// Descripción resumida de TestJuntas
    /// </summary>
    [TestClass]
    public class TestJuntas
    {
        [TestMethod]
        public void CrearJunta()
        {
            try
            {
                //grabamos las juntas
                SOAPJuntasService.JuntaServiceClient objjunta = new SOAPJuntasService.JuntaServiceClient();
                //primero grabamos la cabecera
                int id;
                id = objjunta.CreaJunta(Convert.ToDateTime("2014-06-12"), "20", "Tema de Test", "Acuerdos Creados");
                int id2;
                id2 = objjunta.CreaJuntaDirectivos(id, 1, "SI", true);
                Assert.AreNotEqual(0, id);
                Assert.AreNotEqual(0, id2);
            }
            catch (Exception ex)
            {
                //test para la falla
                Assert.AreEqual("El horario ya se encuentra ocupado", ex.Message);
            }
        
        }

        [TestMethod]
        public void ListarJunta()
        {
            //listamos
            SOAPJuntasService.JuntaServiceClient objjuntaservice = new SOAPJuntasService.JuntaServiceClient();
            List<SOAPJuntasService.ListaJuntas> ObjListaJuntas = new List<SOAPJuntasService.ListaJuntas>();
            ObjListaJuntas = objjuntaservice.listarJuntas("2013-01-01", "2014-12-31");
            //debe traer valores
            Assert.AreNotEqual(0, ObjListaJuntas.Count());
        }
    }
}
