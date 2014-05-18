using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Architects.Persistencia;
using Architects.Dominio;

namespace Arquitects.Negocio
{
    public class ResidenteBL
    {
        ResidenteDAO residenteDAO = null;
        public ResidenteBL()
        {
            residenteDAO = new ResidenteDAO();
        }

        public Int32 CreaResidente(Residente objresidente)
        {
            int intResultado = 0;
            try
            {
                intResultado = residenteDAO.CreaResidente(objresidente);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return intResultado;
        }

        public List<Residente> ListarResidente()
        {
            return residenteDAO.ListarResidentes();
        }
    }
}
