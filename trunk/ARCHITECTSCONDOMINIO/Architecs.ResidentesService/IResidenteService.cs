using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Architects.Dominio;
using Architects.Persistencia;


namespace ResidenteService
{
    [ServiceContract]
    public interface IResidenteService
    {
        [FaultContract(typeof(ValidationException))]
        [OperationContract]
        ResidenteBE[] ListarResidentes();

        [FaultContract(typeof(ValidationException))]
        [OperationContract]
        ResidenteBE[] BuscarResidentes(string nombre, string apellidos, string numDocumento);

        [FaultContract(typeof(ValidationException))]
        [OperationContract]
        IEnumerable<ResidenteBE> ListarResidentesPaginado(int page, int size);

        [FaultContract(typeof(ValidationException))]
        [OperationContract]
        ResidenteBE ObtenerResidentePorID(int residenteId);

        [FaultContract(typeof(ValidationException))]
        [OperationContract]
        Int32 CrearResidente(ResidenteBE prmResidente);

        [FaultContract(typeof(ValidationException))]
        [OperationContract]
        ValidationException ActualizarResidente(ResidenteBE prmResidente);

        [FaultContract(typeof(ValidationException))]
        [OperationContract]
        ValidationException EliminarResidente(int residenteID);
    }

    [DataContract]
    public class ValidationException
    {
        [DataMember]
        public string ValidationError { get; set; } 
    }
}
