using System;
using System.Collections.Generic;
using System.Configuration;

using Architects.Persistencia;
using Architects.Dominio;

namespace Arquitects.Negocio
{ 
	/// <summary>
	/// Proyecto    :  Modulo de Mantenimiento de : 
	/// Creacion    : 
	/// Fecha       : 16/05/2014-07:59:42 a.m. Y A
	/// Descripcion : Capa de Lógica 
	/// Archivo     : [Maestros.EspacioLogic.cs]
	/// </summary>
	public class EspacioComunBL
	{
        private EspacioComunDAO espacioComunDAO = null;
		
		public EspacioComunBL()
		{
			espacioComunDAO = new EspacioComunDAO();
		}
		#region /* Proceso de SELECT ALL */ 

		/// <summary>
		/// Retorna un LISTA de registros de la Entidad Maestros.Espacio
		/// En la BASE de DATO la Tabla : [Maestros.Espacio]
		/// <summary>
		/// <returns>List</returns>
		public List<EspacioComun> Listar()
		{
            List<EspacioComun> lstEspacioComun = new List<EspacioComun>();
			try
			{
				 lstEspacioComun = espacioComunDAO.Listar();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return lstEspacioComun;
		}

		#endregion 

        //#region /* Proceso de SELECT BY ID CODE */ 

        ///// <summary>
        ///// Retorna una ENTIDAD de registro de la Entidad Maestros.Espacio
        ///// En la BASE de DATO la Tabla : [Maestros.Espacio]
        ///// <summary>
        ///// <returns>Entidad</returns>
        //public Espacio Find(int prm_N_IdEspacio)
        //{
        //    Espacio miEntidad = new Espacio();
        //    try
        //    {
        //        miEntidad = oEspacioData.Find(prm_N_IdEspacio);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return miEntidad;
        //}
        //#endregion 

        //#region /* Proceso de SELECT BY ID CODE FOREIGN KEY*/ 

        ///// <summary>
        ///// Retorna una LISTA de registro de la Entidad Maestros.Espacio POR FOREIGN KEY
        ///// En la BASE de DATO la Tabla : [Maestros.Espacio]
        ///// <summary>
        ///// <returns>Entidad</returns>
        //#endregion 

        //#region /* Proceso de INSERT RECORD */ 

        ///// <summary>
        ///// Almacena el registro de una ENTIDAD de registro de Tipo Espacio
        ///// En la BASE de DATO la Tabla : [Maestros.Espacio]
        ///// <summary>
        ///// <param name = >itemEspacio</param>
        //public ReturnValor Insert( Espacio itemEspacio )
        //{
        //    try
        //    {
        //        using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
        //        {
        //            oReturnValor.Exitosa = oEspacioData.Insert( itemEspacio);
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
        //        oReturnValor= ManejoException.mTraerMensaje(ex);
        //    }
        //    return oReturnValor;
        //}
        //#endregion 

        //#region /* Proceso de UPDATE RECORD */ 

        ///// <summary>
        ///// Almacena el registro de una ENTIDAD de registro de Tipo Espacio
        ///// En la BASE de DATO la Tabla : [Maestros.Espacio]
        ///// <summary>
        ///// <param name = >itemEspacio</param>
        //public ReturnValor Update( Espacio itemEspacio )
        //{
        //    try
        //    {
        //        using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
        //        {
        //            oReturnValor.Exitosa = oEspacioData.Update( itemEspacio);
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
        //        oReturnValor= ManejoException.mTraerMensaje(ex);
        //    }
        //    return oReturnValor;
        //}
        //#endregion 

        //#region /* Proceso de DELETE BY ID CODE */ 

        ///// <summary>
        ///// ELIMINA un registro de la Entidad Maestros.Espacio
        ///// En la BASE de DATO la Tabla : [Maestros.Espacio]
        ///// <summary>
        ///// <returns>bool</returns>
        //public ReturnValor Delete(int	prm_N_IdEspacio)
        //{
        //    try
        //    {
        //        using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
        //        {
        //            oReturnValor.Exitosa = oEspacioData.Delete(prm_N_IdEspacio);
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
        //        oReturnValor= ManejoException.mTraerMensaje(ex);
        //    }
        //    return oReturnValor;
        //}
        //#endregion 

	} 
} 
