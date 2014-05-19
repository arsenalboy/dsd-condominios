using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Architects.Dominio;

namespace Test
{
     [TestClass]
    public class TestReservas
    {
         [TestMethod]
         public void EspacioComunListarTest()
         {
             SOAReservasService.ReservasServiceClient proxy = new SOAReservasService.ReservasServiceClient();
             IList<EspacioComun> espacioComunListar;
             espacioComunListar = proxy.ListarEspacioComun();

             Assert.AreNotEqual(espacioComunListar.Count, 0);

         }
    }
}
