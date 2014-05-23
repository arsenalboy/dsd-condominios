using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Dominio;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPagosService" in both code and config file together.
    [ServiceContract]
    public interface IPagosService
    {

        [OperationContract]
        IList<TipoPago> ListarTipoPago();

        [OperationContract]
        TipoPago RegistrarTipoPago(string Descripcion);

        //[OperationContract(Name = "Error")]
        //[FaultContract(typeof(RetornaMensaje))]

        [OperationContract]
        [FaultContract(typeof(RetornaMensaje))]
        RetornaMensaje RegistrarCuota(string C_Periodo, int N_IdVivienda, int N_IdTipoPago, decimal N_Importe, DateTime D_FecVncto);

    }
}
