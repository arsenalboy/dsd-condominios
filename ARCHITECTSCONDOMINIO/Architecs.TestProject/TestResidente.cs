using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.ServiceModel;
using Architects.TestProject.ResidenteProxy;
using Architects.Dominio;

namespace Architects.TestProject
{
    [TestClass]
    public class TestResidente
    {
        ResidenteServiceClient client = new ResidenteServiceClient();

        [TestMethod]
        public void Test_ListarResidente()
        {
            List<ResidenteBE> residentes = new List<ResidenteBE>(client.ListarResidentes());
            Assert.AreNotEqual(residentes, null);
        }

        [TestMethod]
        public void Test_ObtenerResidentePorNumeroDocumento()
        {
            string strNroDoc = "87032897";
            ResidenteBE residente = client.ObtenerResidentePorNroDocumento(strNroDoc);
            Assert.AreEqual(residente.C_NumDocume, strNroDoc);
        }

        [TestMethod]
        public void Test_BuscarResidente()
        {
            string strNroDoc = "87032897";
            List<ResidenteBE> residentes = new List<ResidenteBE>(client.BuscarResidentes("","",strNroDoc));
            Assert.AreNotEqual(residentes.Count, 0);
        }

        [TestMethod]
        public void Test_CrearResidente()
        {
            ResidenteBE nuevoResidente = new ResidenteBE();
            nuevoResidente.C_Nombre = "Selena Demi";
            nuevoResidente.C_Apellidos = "Gomez Lovato";
            nuevoResidente.N_TipoDoc = 1;
            nuevoResidente.C_NumDocume = "83245901";
            nuevoResidente.C_Correo = "selena@gmail.com";
            nuevoResidente.C_Clave = "StartDance14";
            nuevoResidente.D_FecNacimi = new DateTime(1992, 07, 22);

            int idResidente = client.CrearResidente(nuevoResidente);
            Assert.AreNotEqual(client.ObtenerResidentePorID(idResidente), null);
        }

        [TestMethod]
        public void Test_ActualizaResidente()
        {
            ResidenteBE modificarResidente = client.ObtenerResidentePorID(1);
            modificarResidente.C_Correo = "justindelabarra@gmail.com";

            client.ActualizarResidente(modificarResidente);

            Assert.AreEqual(client.ObtenerResidentePorID(1).C_Correo,
                modificarResidente.C_Correo);
        }

        [TestMethod]
        public void Test_EliminarResidente()
        {
            try
            {
                ResidenteBE eliminarResidente = client.ObtenerResidentePorID(4);

                if (eliminarResidente != null)
                    client.EliminarResidente(eliminarResidente.N_IdResidente);
                else
                    throw new FaultException<ValidationException>
                       (new ValidationException { ValidationError = "Residente no existe" },
                       new FaultReason("Validation Failed"));

                Assert.AreEqual(client.ObtenerResidentePorID(4), null);
            }
            catch (FaultException<ValidationException> ex)
            {
                Console.WriteLine(ex.Detail.ValidationError);
            }
        }
    }
}
