using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Dominio;

namespace Architecs.HorariosService
{
    [ServiceContract]
    public interface IHorarioService
    {
        [OperationContract]
        IList<HorarioBE> ListarHorariosDisponibles(DateTime fecha, int idEspacio);

        [OperationContract]
        HorarioBE RegistrarHorario(string rango);

        [OperationContract]
        HorarioBE ActualizarHorario(int idHorario, string rango, int estado);

        [OperationContract]
        void EliminarHorario(int idHorario); 
    }
}
