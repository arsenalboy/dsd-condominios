using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Common;
//using VisitasService.Dominio;
using Architects.Dominio;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

using System.Messaging;

namespace VisitasService.Persistencia
{
    public class VisitanteDA : IVisitanteDA
    {
        private Database _db = null;

        public VisitanteDA()
        {
            _db = EnterpriseLibraryContainer.Current.GetInstance<Database>("ConnDB");
        }

        public VisitanteBE[] ListarVisitantes()
        {
            List<VisitanteBE> Visitantes = new List<VisitanteBE>();
            VisitanteBE visitante = null;

            try
            {
                using (IDataReader dataReader = _db.ExecuteReader("Gestion.USP_LIST_VISITANTE"))
                {
                    while (dataReader.Read())
                    {
                        visitante = new VisitanteBE();

                        visitante.N_IdVisitante = dataReader.GetInt32(dataReader.GetOrdinal("N_IdVisitante"));
                        visitante.C_NumDocumento = dataReader.GetString(dataReader.GetOrdinal("NroDocVisitante"));
                        visitante.C_Nombre = dataReader.GetString(dataReader.GetOrdinal("NombreVisitante"));
                        visitante.O_ResidenteBE.N_IdResidente = dataReader.GetInt32(dataReader.GetOrdinal("N_IdResidente"));
                        visitante.O_ResidenteBE.C_NumDocume = dataReader.GetString(dataReader.GetOrdinal("NroDocResidente"));
                        visitante.O_ResidenteBE.C_Nombre = dataReader.GetString(dataReader.GetOrdinal("NombreResidente"));
                        visitante.O_ResidenteBE.C_Apellidos = dataReader.GetString(dataReader.GetOrdinal("ApellidosResidente"));
                        visitante.D_FecVisita = dataReader.GetDateTime(dataReader.GetOrdinal("D_FecVisita"));
                        visitante.B_Estado = dataReader.GetBoolean(dataReader.GetOrdinal("B_Estado"));
                        Visitantes.Add(visitante);
                    }
                }

                return Visitantes.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public VisitanteBE[] BuscarVisitantes(string numDocumento, string nombre, DateTime? fechaVisita, int idResidente)
        {
            List<VisitanteBE> Visitantes = new List<VisitanteBE>();
            VisitanteBE visitante = null;
            DbCommand SearchCommand = null;

            try
            {
                SearchCommand = _db.GetStoredProcCommand("Gestion.USP_GET_VISITANTE");
                _db.AddInParameter(SearchCommand, "@pv_NumDocumento", DbType.String, numDocumento);
                _db.AddInParameter(SearchCommand, "@pv_nombre", DbType.String, nombre);
                _db.AddInParameter(SearchCommand, "@pd_FecVisita", DbType.DateTime, fechaVisita);
                _db.AddInParameter(SearchCommand, "@pi_IdResidente", DbType.Int32, idResidente);

                using (IDataReader dataReader = _db.ExecuteReader(SearchCommand))
                {
                    while (dataReader.Read())
                    {
                        visitante = new VisitanteBE();

                        visitante.N_IdVisitante = dataReader.GetInt32(dataReader.GetOrdinal("N_IdVisitante"));
                        visitante.C_NumDocumento = dataReader.GetString(dataReader.GetOrdinal("NroDocVisitante"));
                        visitante.C_Nombre = dataReader.GetString(dataReader.GetOrdinal("NombreVisitante"));
                        visitante.O_ResidenteBE.N_IdResidente = dataReader.GetInt32(dataReader.GetOrdinal("N_IdResidente"));
                        visitante.O_ResidenteBE.C_NumDocume = dataReader.GetString(dataReader.GetOrdinal("NroDocResidente"));
                        visitante.O_ResidenteBE.C_Nombre = dataReader.GetString(dataReader.GetOrdinal("NombreResidente"));
                        visitante.O_ResidenteBE.C_Apellidos = dataReader.GetString(dataReader.GetOrdinal("ApellidosResidente"));
                        visitante.D_FecVisita = dataReader.GetDateTime(dataReader.GetOrdinal("D_FecVisita"));
                        visitante.B_Estado = dataReader.GetBoolean(dataReader.GetOrdinal("B_Estado"));
                        Visitantes.Add(visitante);
                    }
                }

                return Visitantes.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 AgregarVisitante(VisitanteBE prmVisitante)
        {
            DbCommand insertCommand = null;

            try
            {
                insertCommand = _db.GetStoredProcCommand("Gestion.USP_INSERT_VISITANTE");
                _db.AddInParameter(insertCommand, "@PV_NumDocumento", DbType.String, prmVisitante.C_NumDocumento);
                _db.AddInParameter(insertCommand, "@PV_Nombre", DbType.String, prmVisitante.C_Nombre);
                _db.AddInParameter(insertCommand, "@PI_IdResidente", DbType.Int32, prmVisitante.O_ResidenteBE.N_IdResidente);
                _db.AddInParameter(insertCommand, "@PD_FecVisita", DbType.DateTime, prmVisitante.D_FecVisita);                

                var result = _db.ExecuteScalar(insertCommand);

                return Int32.Parse(result.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }       
    }
}