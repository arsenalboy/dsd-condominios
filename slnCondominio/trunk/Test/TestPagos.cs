using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Architects.Dominio;
using Test.SOAPagosService;
using System.ServiceModel;

namespace Test
{
    [TestClass]
    public class TestPagos
    {

        [TestMethod]
        public void TipoPagoListarTest()
        {
            SOAPagosService.PagosServiceClient proxy = new SOAPagosService.PagosServiceClient();
            IList<TipoPago> tipoPagoListar;
            tipoPagoListar = proxy.ListarTipoPago();

            Assert.AreNotEqual(tipoPagoListar.Count, 0);
        }

        [TestMethod]
        public void TipoPagoCrearTest()
        {
            SOAPagosService.PagosServiceClient proxy = new SOAPagosService.PagosServiceClient();
            TipoPago tipoPago = new TipoPago();
            string strDescripcion = "CONTADO";
            tipoPago = proxy.RegistrarTipoPago(strDescripcion);

            Assert.AreEqual(tipoPago.C_Descripcion, strDescripcion);
            /* */
        }

        [TestMethod]
        public void RegistrarCuotaTest()
        {
            SOAPagosService.PagosServiceClient proxy = new SOAPagosService.PagosServiceClient();
            RetornaMensaje retornaMensaje = null;
            Cuota cuotaRegistrada = new Cuota();

            string C_Periodo = "201401"; 
            int N_IdVivienda=1; 
            int N_IdTipoPago=1; 
            decimal N_Importe = 120; 
            DateTime D_FecVncto = DateTime.Now;
            try
            {
                retornaMensaje = proxy.RegistrarCuota(C_Periodo, N_IdVivienda, N_IdTipoPago, N_Importe, D_FecVncto);

                Assert.AreNotEqual(0, retornaMensaje.CodigoRetorno);
            }
            catch (FaultException<RetornaMensaje> exception)
            {
                Console.WriteLine("Error : {0}", exception.Detail.Mensage);
            }
            
            
        }

    }
}
