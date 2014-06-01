using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architecs.EspaciosComunuesService.Persitencia;
using Architects.Dominio;

namespace Architecs.EspaciosComunuesService
{
    public class EspacioComunService : IEspacioComunService
    {
        EspacioComunDAO dao = new EspacioComunDAO();

        public IList<EspacioComunBE> ListarEspacioComun()
        {
            return dao.Listar().ToList();
        }

        public EspacioComunBE RegistrarEspacioComun(string nombre)
        {
            throw new NotImplementedException();
        }

        public EspacioComunBE ActualizarEspacioComun(int idEspacioComun, string nombre, int estado)
        {
            throw new NotImplementedException();
        }

        public void EliminarHorario(int idEspacioComun)
        {
            throw new NotImplementedException();
        }
    }
}
