using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Condominio.Entities;
using Architects.Persistencia;

namespace Arquitects.Negocio
{
    public class TipoPagoBL
    {
        private TipoPagoDAO tipoPagoDAO = null;
        private TipoPagoDAO TipoPagoDAO
        {
            get
            {
                if (tipoPagoDAO == null)
                    tipoPagoDAO = new TipoPagoDAO();
                return tipoPagoDAO;
            }
        }

        public TipoPago CrearTipoPago(TipoPago tipoPago)
        {
            TipoPago tipoPagoCrear = new TipoPago();
            try
            {
                tipoPagoCrear = TipoPagoDAO.Crear(tipoPago);
            }
            catch (Exception)
            {
                
                throw;
            }

            return (tipoPagoCrear);
        }

        public List<TipoPago> ListarTipoPago()
        {
            return TipoPagoDAO.ListarTodos().ToList();
        }


    }
}
