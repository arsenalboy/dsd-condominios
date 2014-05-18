using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Condominio.Entities;

namespace Test
{
    [TestClass]
    public class TestCuota
    {

        [TestMethod]
        public void TipoPagoListarTest()
        {
            SOAPagosService.CuotaServiceClient proxy = new SOAPagosService.CuotaServiceClient();
            IList<TipoPago> tipoPagoListar;
            tipoPagoListar = proxy.ListarTipoPago();

            Assert.AreNotEqual(tipoPagoListar.Count, 0);

        }

        [TestMethod]
        public void TipoPagoCrearTest()
        {
            SOAPagosService.CuotaServiceClient proxy = new SOAPagosService.CuotaServiceClient();
            TipoPago tipoPago = new TipoPago();
            string strDescripcion = "CONTADO";
            tipoPago = proxy.CrearTipoPago(strDescripcion);

            Assert.AreEqual(tipoPago.C_Descripcion, strDescripcion);
            /* */
        }
    }
}
