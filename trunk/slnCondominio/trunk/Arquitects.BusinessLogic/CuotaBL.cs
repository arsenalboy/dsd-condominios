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
        /// <returns>List</returns>
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
        /// <returns>Entidad</returns>
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

        //#region /* Proceso de INSERT RECORD */

        ///// <summary>
        ///// Almacena el registro de una ENTIDAD de registro de Tipo Cuota
        ///// En la BASE de DATO la Tabla : [Gestion.Cuota]
        ///// <summary>
        ///// <param name = >itemCuota</param>
        //public Cuota Registra(Cuota pcuota)
        //{
        //    try
        //    {
        //        using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
        //        {
        //            oReturnValor.Exitosa = cuotaDAO.Registrar(pcuota);
        //            if (oReturnValor.Exitosa)
        //            {
        //                oReturnValor.Message = "¡Los Datos de la Entidad ha sido REGISTRADO SATISFACTORIAMENTE !";
        //                tx.Complete();
        //            }
        //            else
        //                oReturnValor.Message = "¡L¡Los Datos NO han REGISTRADO !";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        oReturnValor = ManejoException.mTraerMensaje(ex);
        //    }
        //    return oReturnValor;
        //}
        //#endregion

        //#region /* Proceso de UPDATE RECORD */

        ///// <summary>
        ///// Almacena el registro de una ENTIDAD de registro de Tipo Cuota
        ///// En la BASE de DATO la Tabla : [Gestion.Cuota]
        ///// <summary>
        ///// <param name = >itemCuota</param>
        //public ReturnValor Update(Cuota itemCuota)
        //{
        //    try
        //    {
        //        using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
        //        {
        //            oReturnValor.Exitosa = cuotaDAO.Update(itemCuota);
        //            if (oReturnValor.Exitosa)
        //            {
        //                oReturnValor.Message = "¡Los Datos de la Entidad ha sido ACTUALIZADO SATISFACTORIAMENTE !";
        //                tx.Complete();
        //            }
        //            else
        //                oReturnValor.Message = "¡Los Datos NO HAN sido ACTUALIZADO !";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        oReturnValor = ManejoException.mTraerMensaje(ex);
        //    }
        //    return oReturnValor;
        //}
        //#endregion

        //#region /* Proceso de DELETE BY ID CODE */

        ///// <summary>
        ///// ELIMINA un registro de la Entidad Gestion.Cuota
        ///// En la BASE de DATO la Tabla : [Gestion.Cuota]
        ///// <summary>
        ///// <returns>bool</returns>
        //public ReturnValor Delete(int prm_N_IdCuota)
        //{
        //    try
        //    {
        //        using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
        //        {
        //            oReturnValor.Exitosa = cuotaDAO.Delete(prm_N_IdCuota);
        //            if (oReturnValor.Exitosa)
        //            {
        //                oReturnValor.Message = "¡El Registro ha sido ELIMINADO SATISFACTORIAMENTE !";
        //                tx.Complete();
        //            }
        //            else
        //                oReturnValor.Message = "¡El Registro NO HA SIDO ELIMINADO !";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        oReturnValor = ManejoException.mTraerMensaje(ex);
        //    }
        //    return oReturnValor;
        //}
        //#endregion

    }
}
