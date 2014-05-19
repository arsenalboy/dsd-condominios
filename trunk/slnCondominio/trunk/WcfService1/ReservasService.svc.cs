using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Architects.Dominio;
using Arquitects.Negocio;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReservasService" in code, svc and config file together.
    public class ReservasService : IReservasService
    {
        private EspacioComunBL espacioComunBL = new EspacioComunBL();
        public IList<EspacioComun> ListarEspacioComun()
        {
            return espacioComunBL.Listar();
        }
    }
}
