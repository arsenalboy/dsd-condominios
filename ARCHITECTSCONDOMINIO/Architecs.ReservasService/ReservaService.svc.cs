using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architecs.ReservasService.Dominio;
using Architecs.ReservasService.Persistencia;

namespace Architecs.ReservasService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ReservaService" en el código, en svc y en el archivo de configuración a la vez.
    public class ReservaService : IReservaService
    {
        ReservaDAO ObjReservaDAO = new ReservaDAO();

        public ReservasBE CreaReserva(ReservasBE ObjReserva)
        {
            try
            {
                //validacion de fecha
                if (ObjReserva.D_FecRegistro < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    throw new FaultException("La fecha no puede ser inferior a la fecha actual");
                }
                //validacion de fecha
                if (ObjReserva.N_IdHorarioIni > ObjReserva.N_IdHorarioFin)
                {
                    throw new FaultException("La hora inicial no puede ser mayor que la hora final");
                }
                //validacion maximo tres horas
                if ((ObjReserva.N_IdHorarioFin - ObjReserva.N_IdHorarioIni + 1) > 3)
                {
                    throw new FaultException("No se puede reservar mas  de tres horas");
                }
               //validacion maximo de reservas y hora no disponible
                string valor;
                valor = ObjReservaDAO.ValidaReserva(ObjReserva);
                if (valor == "PASO_MAXIMO")
                {
                    throw new FaultException("No puede hacer mas de una reserva por el mismo espacio");
                }
                else if (valor == "HORA_NO_DISPONIBLE")
                {
                    throw new FaultException("La reserva no se aplica para ese horario , ya que esta ocupado");
                }
                else
                    return ObjReservaDAO.CrearReserva(ObjReserva);
            }
            catch (Exception ex)
            {
                 throw new FaultException(ex.Message);
            }

        }



        public List<EspacioComunBE> ListarEspacioComun()
        {
            return ObjReservaDAO.ListarEspacioComun();
        }
    }
}
