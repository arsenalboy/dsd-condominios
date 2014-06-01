using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Dominio;

namespace Architecs.EspaciosComunuesService
{
    [ServiceContract]
    public interface IEspacioComunService
    {
        [OperationContract]
        IList<EspacioComunBE> ListarEspacioComun();

        [OperationContract]
        EspacioComunBE RegistrarEspacioComun(string nombre);

        [OperationContract]
        EspacioComunBE ActualizarEspacioComun(int idEspacioComun, string nombre, int estado);

        [OperationContract]
        void EliminarHorario(int idEspacioComun);
    }
}
