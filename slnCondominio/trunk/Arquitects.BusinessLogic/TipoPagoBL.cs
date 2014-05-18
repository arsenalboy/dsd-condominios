﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Architects.Persistencia;
using Architects.Dominio;

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
            TipoPago tipoPagoCreado = new TipoPago();
            try
            {
                tipoPagoCreado.N_IdTipoPago = TipoPagoDAO.Crear(tipoPago);
                tipoPagoCreado = TipoPagoDAO.Buscar(tipoPagoCreado.N_IdTipoPago);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return (tipoPagoCreado);
        }

        public List<TipoPago> ListarTipoPago()
        {
            List<TipoPago> lstTipoPago = new List<TipoPago>();
            lstTipoPago = TipoPagoDAO.Listar().ToList();
            return lstTipoPago ;
        }


    }
}
