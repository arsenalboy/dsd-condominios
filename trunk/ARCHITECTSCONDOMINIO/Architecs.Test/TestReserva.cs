using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Architecs.Test
{
    [TestClass]
    public class TestReserva
    {
        /*
         Nota: Algunos devolveran error ya que valida por prioridades en este orden:
         * "La fecha no puede ser inferior a la fecha actual"
         * "No puede hacer mas de una reserva por el mismo espacio"
         * "La hora inicial no puede ser mayor que la hora final"
         * "No se puede reservar mas  de tres horas"
         * "La reserva no se aplica para ese horario , ya que esta ocupado"
         * 
         * <b
         * para evitar esto, se ejecutaria uno por uno ingresando los datos correctos
         */
        [TestMethod]
        public void InsertaTestCorrecto()
        {
            try
            {
                //se inserta la reserva
                SOAPReservaService.ReservaServiceClient objreservaServ = new SOAPReservaService.ReservaServiceClient();
                SOAPReservaService.ReservasBE ObjReserva = new SOAPReservaService.ReservasBE();
                ObjReserva.N_IdResidente = 4;
                ObjReserva.N_IdHorarioIni = Convert.ToInt32(1);
                ObjReserva.N_IdHorarioFin = Convert.ToInt32(2);
                ObjReserva.N_IdEspacioComun = Convert.ToInt32(2);
                ObjReserva.D_FecRegistro = Convert.ToDateTime("2014-06-20");
                ObjReserva.B_Estado = true;

                SOAPReservaService.ReservasBE ObjReservaPrueba = new SOAPReservaService.ReservasBE();
                ObjReservaPrueba = objreservaServ.CreaReserva(ObjReserva);

                Assert.AreNotEqual(0, ObjReservaPrueba.N_IdReserva);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("No puede hacer mas de una reserva por el mismo espacio", ex.Message); ;
            }
           

        }

        [TestMethod]
        public void InsertaTestErrorMayorFecha()
        {
            try
            {
                //se inserta la reserva
                SOAPReservaService.ReservaServiceClient objreservaServ = new SOAPReservaService.ReservaServiceClient();
                SOAPReservaService.ReservasBE ObjReserva = new SOAPReservaService.ReservasBE();
                ObjReserva.N_IdResidente = 21;
                ObjReserva.N_IdHorarioIni = Convert.ToInt32(6);
                ObjReserva.N_IdHorarioFin = Convert.ToInt32(7);
                ObjReserva.N_IdEspacioComun = Convert.ToInt32(2);
                ObjReserva.D_FecRegistro = Convert.ToDateTime("2000-06-20");
                ObjReserva.B_Estado = true;

                SOAPReservaService.ReservasBE ObjReservaPrueba = new SOAPReservaService.ReservasBE();
                ObjReservaPrueba = objreservaServ.CreaReserva(ObjReserva);

                Assert.AreNotEqual(0, ObjReservaPrueba.N_IdReserva);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("La fecha no puede ser inferior a la fecha actual", ex.Message);
            }          

        }

        [TestMethod]
        public void InsertaTestErrorMaximoReservas()
        {
            try
            {
                //se inserta la reserva
                SOAPReservaService.ReservaServiceClient objreservaServ = new SOAPReservaService.ReservaServiceClient();
                SOAPReservaService.ReservasBE ObjReserva = new SOAPReservaService.ReservasBE();
                ObjReserva.N_IdResidente = 4;
                ObjReserva.N_IdHorarioIni = Convert.ToInt32(1);
                ObjReserva.N_IdHorarioFin = Convert.ToInt32(3);
                ObjReserva.N_IdEspacioComun = Convert.ToInt32(2);
                ObjReserva.D_FecRegistro = Convert.ToDateTime("2014-06-20");
                ObjReserva.B_Estado = true;

                SOAPReservaService.ReservasBE ObjReservaPrueba = new SOAPReservaService.ReservasBE();
                ObjReservaPrueba = objreservaServ.CreaReserva(ObjReserva);

                Assert.AreNotEqual(0, ObjReservaPrueba.N_IdReserva);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("No puede hacer mas de una reserva por el mismo espacio", ex.Message);
            }

        }

        [TestMethod]
        public void InsertaTestErrorHorainicioMayorHoraFin()
        {
            try
            {
                //se inserta la reserva
                SOAPReservaService.ReservaServiceClient objreservaServ = new SOAPReservaService.ReservaServiceClient();
                SOAPReservaService.ReservasBE ObjReserva = new SOAPReservaService.ReservasBE();
                ObjReserva.N_IdResidente = 4;
                ObjReserva.N_IdHorarioIni = Convert.ToInt32(6);
                ObjReserva.N_IdHorarioFin = Convert.ToInt32(2);
                ObjReserva.N_IdEspacioComun = Convert.ToInt32(2);
                ObjReserva.D_FecRegistro = Convert.ToDateTime("2014-06-20");
                ObjReserva.B_Estado = true;

                SOAPReservaService.ReservasBE ObjReservaPrueba = new SOAPReservaService.ReservasBE();
                ObjReservaPrueba = objreservaServ.CreaReserva(ObjReserva);

                Assert.AreNotEqual(0, ObjReservaPrueba.N_IdReserva);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("La hora inicial no puede ser mayor que la hora final", ex.Message);
            }

        }

        [TestMethod]
        public void InsertaTestErrorReservaMasTresHoras()
        {
            try
            {
                //se inserta la reserva
                SOAPReservaService.ReservaServiceClient objreservaServ = new SOAPReservaService.ReservaServiceClient();
                SOAPReservaService.ReservasBE ObjReserva = new SOAPReservaService.ReservasBE();
                ObjReserva.N_IdResidente = 4;
                ObjReserva.N_IdHorarioIni = Convert.ToInt32(2);
                ObjReserva.N_IdHorarioFin = Convert.ToInt32(9);
                ObjReserva.N_IdEspacioComun = Convert.ToInt32(2);
                ObjReserva.D_FecRegistro = Convert.ToDateTime("2014-06-20");
                ObjReserva.B_Estado = true;

                SOAPReservaService.ReservasBE ObjReservaPrueba = new SOAPReservaService.ReservasBE();
                ObjReservaPrueba = objreservaServ.CreaReserva(ObjReserva);

                Assert.AreNotEqual(0, ObjReservaPrueba.N_IdReserva);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("No se puede reservar mas  de tres horas", ex.Message);
            }

        }

        [TestMethod]
        public void InsertaTestErrorHorarioNoDisponible()
        {
            try
            {
                //se inserta la reserva
                SOAPReservaService.ReservaServiceClient objreservaServ = new SOAPReservaService.ReservaServiceClient();
                SOAPReservaService.ReservasBE ObjReserva = new SOAPReservaService.ReservasBE();
                ObjReserva.N_IdResidente = 2;
                ObjReserva.N_IdHorarioIni = Convert.ToInt32(1);
                ObjReserva.N_IdHorarioFin = Convert.ToInt32(2);
                ObjReserva.N_IdEspacioComun = Convert.ToInt32(2);
                ObjReserva.D_FecRegistro = Convert.ToDateTime("2014-06-20");
                ObjReserva.B_Estado = true;

                SOAPReservaService.ReservasBE ObjReservaPrueba = new SOAPReservaService.ReservasBE();
                ObjReservaPrueba = objreservaServ.CreaReserva(ObjReserva);

                Assert.AreNotEqual(0, ObjReservaPrueba.N_IdReserva);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("La reserva no se aplica para ese horario , ya que esta ocupado", ex.Message);
            }

        }
    }
}
