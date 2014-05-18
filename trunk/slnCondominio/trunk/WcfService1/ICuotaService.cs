using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Collections;

using Condominio.Entities;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICuotaService" in both code and config file together.
    [ServiceContract]
    public interface ICuotaService
    {
        [OperationContract]
        IList<TipoPago> ListarTipoPago();
    }
}
