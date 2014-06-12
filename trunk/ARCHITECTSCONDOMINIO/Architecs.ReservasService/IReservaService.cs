using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architecs.ReservasService.Dominio;

namespace Architecs.ReservasService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReservaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReservaService
    {
        [FaultContract(typeof(string))]
        [OperationContract(Name = "CreaReserva")]
        ReservasBE CreaReserva(ReservasBE ObjReserva);

        [FaultContract(typeof(string))]
        [OperationContract(Name = "ListarEspacioComun")]
        List<EspacioComunBE> ListarEspacioComun();

    }
}
