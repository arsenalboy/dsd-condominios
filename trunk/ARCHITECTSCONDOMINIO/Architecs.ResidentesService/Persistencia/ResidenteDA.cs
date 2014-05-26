using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using Architects.Dominio;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace Architects.Persistencia
{
    public class ResidenteDA : IResidenteDA
    {
        private Database _db = null;

        public ResidenteDA()
        {
            _db = EnterpriseLibraryContainer.Current.GetInstance<Database>("ConnDB");
        }

        public ResidenteBE[] ListarResidentes()
        {
            List<ResidenteBE> Residentes = new List<ResidenteBE>();
            ResidenteBE residente = null;

            try
            {
                using (IDataReader dataReader = _db.ExecuteReader("Maestros.USP_LIST_RESIDENTE"))
                {
                    while (dataReader.Read())
                    {
                        residente = new ResidenteBE();

                        residente.N_IdResidente = dataReader.GetInt32(0);
                        residente.C_Nombre = dataReader.GetString(1);
                        residente.C_Apellidos = dataReader.GetString(2);
                        residente.N_TipoDoc = dataReader.GetInt32(3);
                        residente.C_NumDocume = dataReader.GetString(4);
                        residente.D_FecNacimi = dataReader.GetDateTime(5);
                        residente.C_Correo = dataReader.IsDBNull(6) ? "" : dataReader.GetString(6);
                        residente.B_Estado = dataReader.GetBoolean(7);

                        Residentes.Add(residente);
                    }
                }

                return Residentes.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 CrearResidente(ResidenteBE prmResidente)
        {
            DbCommand insertCommand = null;            

            try
            {
                insertCommand = _db.GetStoredProcCommand("Maestros.USP_INSERT_RESIDENTE");
                _db.AddInParameter(insertCommand, "@C_Nombre", DbType.String, prmResidente.C_Nombre);
                _db.AddInParameter(insertCommand, "@C_Apellidos", DbType.String, prmResidente.C_Apellidos);
                _db.AddInParameter(insertCommand, "@N_TipoDoc", DbType.Int32, prmResidente.N_TipoDoc);
                _db.AddInParameter(insertCommand, "@C_NumDocume", DbType.String, prmResidente.C_NumDocume);
                _db.AddInParameter(insertCommand, "@D_FecNacimi", DbType.DateTime, prmResidente.D_FecNacimi);
                _db.AddInParameter(insertCommand, "@C_Correo", DbType.String, prmResidente.C_Correo);
                _db.AddInParameter(insertCommand, "@C_Clave", DbType.String, prmResidente.C_Clave);

                var result = _db.ExecuteScalar(insertCommand);

                return Int32.Parse(result.ToString());
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public void ActualizarResidente(ResidenteBE prmResidente)
        {
            DbCommand updateCommand = null;

            try
            {
                updateCommand = _db.GetStoredProcCommand("Maestros.USP_UPDATE_RESIDENTE");
                _db.AddInParameter(updateCommand, "@N_IdResidente", DbType.Int32, prmResidente.N_IdResidente);
                _db.AddInParameter(updateCommand, "@C_Nombre", DbType.String, prmResidente.C_Nombre);
                _db.AddInParameter(updateCommand, "@C_Apellidos", DbType.String, prmResidente.C_Apellidos);
                _db.AddInParameter(updateCommand, "@N_TipoDoc", DbType.Int32, prmResidente.N_TipoDoc);
                _db.AddInParameter(updateCommand, "@C_NumDocume", DbType.String, prmResidente.C_NumDocume);
                _db.AddInParameter(updateCommand, "@D_FecNacimi", DbType.DateTime, prmResidente.D_FecNacimi);
                _db.AddInParameter(updateCommand, "@C_Correo", DbType.String, prmResidente.C_Correo);                

                _db.ExecuteNonQuery(updateCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void EliminarResidente(int residenteID)
        {
            DbCommand deleteCommand = null;

            try
            {
                deleteCommand = _db.GetStoredProcCommand("Maestros.USP_DELETE_RESIDENTE");
                _db.AddInParameter(deleteCommand, "@pi_IdResidente", DbType.Int32, residenteID);
                _db.ExecuteNonQuery(deleteCommand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
