﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Architects.TestProject.SOAPagosService;
using System.ServiceModel;

namespace Architecs.TestProject
{
    [TestClass]
    public class PagosServiceUnitTest
    {
        /* TABLA : TipoPago*/
        [TestMethod]
        public void TipoPagoListarTest()
        {
            PagosServiceClient proxy = new PagosServiceClient();
            IList<TipoPago> tipoPagoListar;
            tipoPagoListar = proxy.ListarTipoPago();

            Assert.AreNotEqual(tipoPagoListar.Count, 0);
        }

        [TestMethod]
        public void TipoPagoCrearTest()
        {
            PagosServiceClient proxy = new PagosServiceClient();
            RetornaMensaje retornaMensaje = null;
            TipoPago tipoPago = new TipoPago();
            string strDescripcion = "CONTADO";
            retornaMensaje = proxy.RegistrarTipoPago(strDescripcion);

            Assert.AreEqual(tipoPago.C_Descripcion, strDescripcion);
        }

        /* TABLA : Cuota*/
        [TestMethod]
        public void RegistrarCuotaTest()
        {
            PagosServiceClient proxy = new PagosServiceClient();
            RetornaMensaje retornaMensaje = null;
            Cuota cuotaRegistrada = new Cuota();

            string C_Periodo = "201401";
            int N_IdVivienda = 9;
            int N_IdTipoPago = 1;
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

        [TestMethod]
        public void ActualizarCuotaTest()
        {
            PagosServiceClient proxy = new PagosServiceClient();
            RetornaMensaje retornaMensaje = null;
            Cuota cuotaRegistrada = new Cuota();

            int pIdCuota = 6;
            string pPeriodo = "201401";
            int pIdVivienda = 2;
            int pIdTipoPago = 1;
            decimal pImporte = 150;
            DateTime pFecVncto = DateTime.Now;
            try
            {
                retornaMensaje = proxy.ActualizarCuota(pIdCuota, pPeriodo, pIdVivienda, pIdTipoPago, pImporte, pFecVncto);

                Assert.AreNotEqual(1, retornaMensaje.CodigoRetorno);
            }
            catch (FaultException<RetornaMensaje> exception)
            {
                Console.WriteLine("Error : {0}", exception.Detail.Mensage);
            }
        }

        [TestMethod]
        public void ListarCuotaTest()
        {
            PagosServiceClient proxy = new PagosServiceClient();
            try
            {
                string pPeriodo = "201401";
                IList<Cuota> lstCuotas = proxy.ListarCuota(pPeriodo).ToList();
                Assert.AreNotEqual(0, lstCuotas.Count);
            }
            catch (FaultException<RetornaMensaje> exception)
            {
                Console.WriteLine("Error : {0}", exception.Detail.Mensage);
            }

        }

        [TestMethod]
        public void BuscarCuotaTest()
        {
            PagosServiceClient proxy = new PagosServiceClient();
            try
            {
                int pIdCuota = 80;
                Cuota cuota = proxy.BuscarCuota(pIdCuota);
                Assert.AreEqual(pIdCuota, cuota.N_IdCuota);
            }
            catch (FaultException<RetornaMensaje> exception)
            {
                Console.WriteLine("Error : {0}", exception.Detail.Mensage);
            }

        }

        [TestMethod]
        public void EliminarCuotaTest()
        {
            PagosServiceClient proxy = new PagosServiceClient();
            RetornaMensaje retornaMensaje = null;
            try
            {
                int pIdCuota = 6;
                retornaMensaje = proxy.EliminarCuota(pIdCuota);
                Assert.AreNotEqual(-1, retornaMensaje.CodigoRetorno);

                Cuota cuotaEliminada = new Cuota();
                cuotaEliminada = proxy.BuscarCuota(pIdCuota);
                Assert.AreNotEqual(pIdCuota, cuotaEliminada.N_IdCuota);
            }
            catch (FaultException<RetornaMensaje> exception)
            {
                Console.WriteLine("Error : {0}", exception.Detail.Mensage);
            }

        }
    }
}