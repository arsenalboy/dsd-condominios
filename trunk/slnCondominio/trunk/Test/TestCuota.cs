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
        public void ListarTipoPagoTest()
        {
            SOAPagosService.CuotaServiceClient proxy = new SOAPagosService.CuotaServiceClient();
            IList<TipoPago> tipoPagoListar;
            tipoPagoListar = proxy.ListarTipoPago();

            Assert.AreNotEqual(tipoPagoListar.Count, 0);

        }
    }
}
