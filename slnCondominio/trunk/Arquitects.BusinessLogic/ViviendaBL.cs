using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Architects.Persistencia;
using Architects.Dominio;

namespace Arquitects.Negocio
{
    class ViviendaBL
    {
        ViviendaDAO viviendaDAO = null;
        public ViviendaBL()
        {
            viviendaDAO = new ViviendaDAO();
        }

        public Int32 CreaVivienda(Vivienda objvivienda)
        {
            int intResultado = 0;
            try
            {
                intResultado = viviendaDAO.CreaVivienda(objvivienda);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return intResultado;
        }

        public Int32 ActualizaVivienda(Vivienda objvivienda)
        {
            int intResultado = 0;
            try
            {
                intResultado = viviendaDAO.ActualizaVivienda(objvivienda);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return intResultado;
        }

        public List<Vivienda> ListarVivienda()
        {
            return viviendaDAO.ListarViviendas();
        }

        public Vivienda ObtenerVivienda(int n_IdVivienda)
        {
            return viviendaDAO.ObtenerVivienda(n_IdVivienda);
        }

    }
}
