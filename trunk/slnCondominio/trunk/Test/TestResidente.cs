using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Architects.Dominio;
using Architects.Persistencia;

namespace Test
{
    [TestClass]
    public class TestResidente
    {
        [TestMethod]
        public void ListarAsesorTest()
        {
            ResidenteDAO objresidentedao = new ResidenteDAO();
            IList<Residente> objresidente;
            objresidente = objresidentedao.ListarResidentes();
            Assert.AreNotEqual(objresidente.Count,0);
            //AsesoresWS.AsesoresClient proxi = new AsesoresWS.AsesoresClient();

            //IList<Asesor> asesorListar;
            //asesorListar = proxi.ListarAsesores();
            //Assert.AreNotEqual(asesorListar.Count, 0);
        }
    }
   
}
