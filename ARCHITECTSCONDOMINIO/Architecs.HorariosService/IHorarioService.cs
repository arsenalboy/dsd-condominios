using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Dominio;

namespace Architecs.HorariosService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHorarioService" in both code and config file together.
    [ServiceContract]
    public interface IHorarioService
    {
        /* TIPO DE PAGO */
        [OperationContract]
        IList<HorarioBE> ListarHorario();

        [OperationContract]
        RetornaMensaje RegistrarHorario(string rango);

        [OperationContract]
        RetornaMensaje ActualizarHorario(int idHorario, string rango, int estado);

        [OperationContract]
        RetornaMensaje EliminarHorario(int idHorario); 
    }
}
