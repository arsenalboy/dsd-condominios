using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Architects.Dominio;
using Architects.Persistencia;
using System.Transactions;

namespace Arquitects.Negocio
{/// <summary>
    /// Proyecto    :  Modulo de Mantenimiento de : 
    /// Creacion    : CROM - Orlando Carril Ramírez
    /// Fecha       : 16/05/2014-07:59:42 a.m.
    /// Descripcion : Capa de Lógica 
    /// Archivo     : [Gestion.CuotaLogic.cs]
    /// </summary>
    public class CuotaBL
    {
        private CuotaDAO cuotaDAO = null;

        public CuotaBL()
        {
            cuotaDAO = new CuotaDAO();
        }

        #region /* Proceso de SELECT ALL */

        /// <summary>
        /// Retorna un LISTA de registros de la Entidad Gestion.Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <summary>
        /// <param name="prm_C_Periodo"></param>
        /// <returns></returns>
        public List<Cuota> Listar(string prm_C_Periodo)
        {
            List<Cuota> lstCuota = new List<Cuota>();
            try
            {
                lstCuota = new CuotaDAO().Listar(prm_C_Periodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstCuota;
        }

        #endregion

        #region /* Proceso de SELECT BY ID CODE */

        /// <summary>
        /// Retorna una ENTIDAD de registro de la Entidad Gestion.Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <summary>
        /// <param name="prm_N_IdCuota"></param>
        /// <returns></returns>
        public Cuota Buscar(int prm_N_IdCuota)
        {
            Cuota cuota = new Cuota();
            try
            {
                cuota = cuotaDAO.Buscar(prm_N_IdCuota);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cuota;
        }

        #endregion

        #region /* Proceso de INSERT RECORD */

        /// <summary>
        /// Almacena el registro de una ENTIDAD de registro de Tipo Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <summary>
        /// <param name="pcuota"></param>
        /// <returns></returns>
        public int Registrar(Cuota pcuota)
        {
            int IdcuotaNueva = -1;
            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    IdcuotaNueva = cuotaDAO.Registrar(pcuota);
                    if (IdcuotaNueva > 0)
                    {
                        tx.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IdcuotaNueva;
        }

        #endregion

        #region /* Proceso de UPDATE RECORD */

        /// <summary>
        /// Almacena el registro de una ENTIDAD de registro de Tipo Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <summary>
        /// <param name="pCuota"></param>
        /// <returns></returns>
        public int Actualizar(Cuota pCuota)
        {
            int cuotaEditada = -1;
            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    cuotaEditada = cuotaDAO.Actualizar(pCuota);
                    if (cuotaEditada > 0)
                    {
                        tx.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cuotaEditada;
        }

        #endregion

        #region /* Proceso de DELETE BY ID CODE */

        /// <summary>
        /// ELIMINA un registro de la Entidad Gestion.Cuota
        /// En la BASE de DATO la Tabla : [Gestion.Cuota]
        /// <param name="prm_N_IdCuota"></param>
        public void Eliminar(int prm_N_IdCuota)
        {
            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    cuotaDAO.Eliminar(prm_N_IdCuota);
                    tx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
