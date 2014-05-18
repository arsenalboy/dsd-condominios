using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Condominio.Entities;
using Arquitects.Negocio;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CuotaService" in code, svc and config file together.
    public class CuotaService : ICuotaService
    {
        TipoPagoBL tipoPagoBL = new TipoPagoBL();

        public IList<TipoPago> ListarTipoPago()
        {
            return tipoPagoBL.ListarTipoPago();
        }
    }
}
