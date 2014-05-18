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
            
        }

        [TestMethod]
        public void TestCrear()
        {
            ResidenteDAO objresidentedao = new ResidenteDAO();

             Residente objresidente = new Residente();
            objresidente.C_Nombre ="MARITZA ESPERANZA";
            objresidente.C_Apellidos = "GUERRA RIVERA";
            objresidente.N_TipoDoc = 1;
            objresidente.C_NumDocume = "12343213";
            objresidente.D_FecNacimi = Convert.ToDateTime("1986-10-21");
            objresidente.C_Correo = "CORREO5@GMAIL.COM";
            objresidente.C_Clave = "SUPERMAN";
            objresidente.B_Estado = true;
            Int32 id = objresidentedao.CreaResidente(objresidente);

            Assert.AreNotEqual(id, 0);
        }
    }
   
}
