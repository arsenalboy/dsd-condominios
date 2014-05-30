using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Dominio;

namespace Architecs.PagosService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPagosService" in both code and config file together.
    [ServiceContract]
    public interface IPagosService
    {
        /* TIPO DE PAGO */
        [OperationContract]
        IList<TipoPago> ListarTipoPago();

        [OperationContract]
        RetornaMensaje RegistrarTipoPago(string Descripcion);

        /* CUOTAS */
        [FaultContract(typeof(RetornaMensaje))]
        [OperationContract(Name = "RegistrarCuota")]
        RetornaMensaje RegistrarCuota(string pPeriodo, int pIdVivienda, double pImporte, string pFecVncto);

        [FaultContract(typeof(RetornaMensaje))]
        [OperationContract(Name = "ActualizarCuota")]
        RetornaMensaje ActualizarCuota(int pIdCuota, string pPeriodo, int pIdVivienda, double pImporte, string pFecVncto);

        [FaultContract(typeof(RetornaMensaje))]
        [OperationContract(Name = "ListarCuota")]
        List<Cuota> ListarCuota(string pPeriodo);

        [FaultContract(typeof(RetornaMensaje))]
        [OperationContract(Name = "BuscarCuota")]
        Cuota BuscarCuota(int pIdCuota);

        [FaultContract(typeof(RetornaMensaje))]
        [OperationContract(Name = "EliminarCuota")]
        RetornaMensaje EliminarCuota(int pIdCuota); 
    }
}
