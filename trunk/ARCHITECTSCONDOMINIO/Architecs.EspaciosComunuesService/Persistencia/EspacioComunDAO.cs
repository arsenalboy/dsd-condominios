using System;
using System.Collections.Generic;
using System.Configuration;

using Architects.Dominio;
using Architecs.HorariosService.Persitencia;
using Architecs.EspaciosComunuesService.Persistencia;

namespace Architecs.EspaciosComunuesService.Persitencia
{

    public class EspacioComunDAO
    {
        private string conexion = string.Empty;
        public EspacioComunDAO()
        {
            conexion = ConexionUtil.CadenaConeccion();
        }
        #region /* Proceso de SELECT ALL */

        public List<EspacioComunBE> Listar()
        {
            List<EspacioComunBE> lstEspacioComun = new List<EspacioComunBE>();
            try
            {
                using (DBMLEspacioComunDataContext SQLDC = new DBMLEspacioComunDataContext(conexion))
                {
                    var resul = SQLDC.dsd_mnt_S_EspacioComun();
                    foreach (var item in resul)
                    {
                        lstEspacioComun.Add(new EspacioComunBE()
                        {
                            N_IdEspacio = item.N_IdEspacioComun,
                            C_Nombre = item.C_Nombre,
                            B_Estado = item.B_Estado,

                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstEspacioComun;
        }
              #endregion 

        //        #region /* Proceso de SELECT BY ID CODE */ 

        //        /// <summary>
        //        /// Retorna una ENTIDAD de registro de la Entidad Maestros.Espacio
        //        /// En la BASE de DATO la Tabla : [Maestros.Espacio]
        //        /// <summary>
        //        /// <returns>Entidad</returns>
        //        public Espacio Find(int prm_N_IdEspacio)
        //        {
        //            Espacio miEntidad = new Espacio();
        //            try
        //            {
        //            using (CROMDataContext SQLDC = new CROMDataContext(conexion))
        //            {
        //                var resul = SQLDC.omgc_mnt_GetByIdCodeEspacio(prm_N_IdEspacio               );
        //                foreach (var item in resul)
        //                {
        //                    miEntidad = new Espacio()
        //                    {
        //                    N_IdEspacio = item.N_IdEspacio,
        //                    C_Nombre = item.C_Nombre,
        //                    B_Estado = item.B_Estado,

        //                    };
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //        return miEntidad;
        //}
        //        #endregion 

        //        #region /* Proceso de SELECT BY ID CODE FOREIGN KEY*/ 

        //        /// <summary>
        //        /// Retorna una LISTA de registro de la Entidad Maestros.Espacio POR FOREIGN KEY
        //        /// En la BASE de DATO la Tabla : [Maestros.Espacio]
        //        /// <summary>
        //        /// <returns>Entidad</returns>
        //        #endregion 

        //        #region /* Proceso de INSERT RECORD */ 

        //        /// <summary>
        //        /// Almacena el registro de una ENTIDAD de registro de Tipo Espacio
        //        /// En la BASE de DATO la Tabla : [Maestros.Espacio]
        //        /// <summary>
        //        /// <param name = >itemEspacio</param>
        //        public bool Insert( Espacio itemEspacio )
        //        {
        //            int codigoRetorno = -1;
        //            try
        //            {
        //                using (CROMDataContext SQLDC = new CROMDataContext(conexion))
        //                {
        //                    codigoRetorno = SQLDC.omgc_mnt_InsertEspacio(
        //                        itemEspacio.N_IdEspacio,
        //                        itemEspacio.C_Nombre,
        //                        itemEspacio.B_Estado		);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw ex;
        //            }
        //            return codigoRetorno == 0 ? true : false;
        //        }
        //        #endregion 

        //        #region /* Proceso de UPDATE RECORD */ 

        //        /// <summary>
        //        /// Almacena el registro de una ENTIDAD de registro de Tipo Espacio
        //        /// En la BASE de DATO la Tabla : [Maestros.Espacio]
        //        /// <summary>
        //        /// <param name = >itemEspacio</param>
        //        public bool Update( Espacio itemEspacio )
        //        {
        //            int codigoRetorno = -1;
        //            try
        //            {
        //                using (CROMDataContext SQLDC = new CROMDataContext(conexion))
        //                {
        //                    codigoRetorno = SQLDC.omgc_mnt_UpdateEspacio(
        //                        itemEspacio.N_IdEspacio,
        //                        itemEspacio.C_Nombre,
        //                        itemEspacio.B_Estado		);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw ex;
        //            }
        //            return codigoRetorno == 0 ? true : false;
        //        }
        //        #endregion 

        //        #region /* Proceso de DELETE BY ID CODE */ 

        //        /// <summary>
        //        /// ELIMINA un registro de la Entidad Maestros.Espacio
        //        /// En la BASE de DATO la Tabla : [Maestros.Espacio]
        //        /// <summary>
        //        /// <returns>bool</returns>
        //        public bool Delete(int prm_N_IdEspacio)
        //        {
        //            int codigoRetorno = -1;
        //            try
        //            {
        //                using (CROMDataContext SQLDC = new CROMDataContext(conexion))
        //                {
        //                    codigoRetorno = SQLDC.omgc_mnt_DeleteEspacio(prm_N_IdEspacio);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw ex;
        //            }
        //            return codigoRetorno == 0 ? true : false;
        //        }
        //        #endregion 
    }
}