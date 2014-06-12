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
            return ObjReservaDAO.CrearReserva(ObjReserva);
        }



        public List<EspacioComunBE> ListarEspacioComun()
        {
            return ObjReservaDAO.ListarEspacioComun();
        }
    }
}
