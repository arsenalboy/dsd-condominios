﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Architecs.TestProject.SOAPPagos;



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

        ////[TestMethod]
        //public void TipoPagoCrearTest()
        //{
        //    PagosServiceClient proxy = new PagosServiceClient();
        //    RetornaMensajeT retornaMensaje = null;
        //    TipoPago tipoPago = new TipoPago();
        //    string strDescripcion = "CONTADO";
        //    retornaMensaje = proxy.RegistrarTipoPago(strDescripcion);

        //    Assert.AreEqual(tipoPago.C_Descripcion, strDescripcion);
        //}

        /* TABLA : Cuota*/
        [TestMethod]
        public void RegistrarCuotaTest()
        {
            PagosServiceClient proxy = new PagosServiceClient();
            RetornaMensaje retornaMensaje = null;
            Cuota cuotaRegistrada = new Cuota();

            string C_Periodo = "201402";
            int N_IdVivienda = 3;
            decimal N_Importe = 120;
            string D_FecVncto = DateTime.Now.ToShortDateString();
            try
            {
                retornaMensaje = proxy.RegistrarCuota(C_Periodo, N_IdVivienda, Convert.ToDouble(N_Importe), D_FecVncto);

                Assert.AreNotEqual(0, retornaMensaje.CodigoRetorno);
            }
            catch (FaultException<RetornaMensajeT> exception)
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

            int pIdCuota = 24;
            string pPeriodo = "201401";
            int pIdVivienda = 2;
            double pImporte = 150;
            string pFecVncto = DateTime.Now.ToShortDateString();
            try
            {
                retornaMensaje = proxy.ActualizarCuota(pIdCuota, pPeriodo, pIdVivienda, pImporte, pFecVncto);

                Assert.AreNotEqual(1, retornaMensaje.CodigoRetorno);
            }
            catch (FaultException<RetornaMensajeT> exception)
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
            catch (FaultException<RetornaMensajeT> exception)
            {
                Console.WriteLine("Error : {0}", exception.Detail.Mensage);
            }

        }

        //[TestMethod]
        public void BuscarCuotaTest()
        {
            PagosServiceClient proxy = new PagosServiceClient();
            try
            {
                int pIdCuota = 80;
                Cuota cuota = proxy.BuscarCuota(pIdCuota);
                Assert.AreEqual(pIdCuota, cuota.N_IdCuota);
            }
            catch (FaultException<RetornaMensajeT> exception)
            {
                Console.WriteLine("Error : {0}", exception.Detail.Mensage);
            }

        }

        //[TestMethod]
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
            catch (FaultException<RetornaMensajeT> exception)
            {
                Console.WriteLine("Error : {0}", exception.Detail.Mensage);
            }

        }

       
    }
}
