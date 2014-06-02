using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Architects.Dominio;



namespace Architecs.ViviendasService.Persistencia
{
    public class ViviendaDAO
    {
        string CadenaConexionSQL;
        SqlConnection objconeccion;

        public ViviendaDAO(string cadenaconexion)
        {
            CadenaConexionSQL = cadenaconexion;
        }

        public ViviendaDAO()
        {
            CadenaConexionSQL = Utilitario.CadenaConeccion();
        }

        public List<ViviendaBE> Listar(int? prm_N_IdResidente, string prm_C_NumEdificio)
        {
            List<ViviendaBE> lstViviendas = new List<ViviendaBE>();
            ViviendaBE itemViviendaBE = null;
            try
            {
                using (DBML_ViviendaDataContext SQLDC = new DBML_ViviendaDataContext(CadenaConexionSQL))
                {
                    var resul = SQLDC.dsd_mnt_S_Vivienda(prm_N_IdResidente, prm_C_NumEdificio);
                    foreach (var item in resul)
                    {
                        itemViviendaBE = new ViviendaBE();
                            itemViviendaBE.N_IdVivienda = item.N_IdVivienda;
                            itemViviendaBE.N_IdResidente = item.N_IdResidente;
                            itemViviendaBE.C_NumEdificio = item.C_NumEdificio;
                            itemViviendaBE.C_NumDpto = item.C_NumDpto;
                            itemViviendaBE.N_NumMetros = item.N_NumMetros;
                            itemViviendaBE.C_CodTipo = item.C_CodTipo;
                            itemViviendaBE.B_Estado = item.B_Estado;
                            itemViviendaBE.objResidente.C_Apellidos = item.Column1;

                            lstViviendas.Add(itemViviendaBE);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstViviendas;
        }

        public ViviendaBE Buscar(int prm_N_IdVivienda)
        {
            ViviendaBE objVivienda = null;
            try
            {
                using (DBML_ViviendaDataContext SQLDC = new DBML_ViviendaDataContext(CadenaConexionSQL))
                {
                    var resul = SQLDC.dsd_mnt_S_ViviendaId(prm_N_IdVivienda);
                    foreach (var item in resul)
                    {
                        objVivienda = new ViviendaBE();
                        objVivienda.N_IdVivienda = item.N_IdVivienda;
                        objVivienda.N_IdResidente = item.N_IdResidente;
                        objVivienda.C_NumEdificio = item.C_NumEdificio;
                        objVivienda.C_NumDpto = item.C_NumDpto;
                        objVivienda.N_NumMetros = item.N_NumMetros;
                        objVivienda.C_CodTipo = item.C_CodTipo;
                        objVivienda.B_Estado = item.B_Estado;
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objVivienda;
        }

        public List<ViviendaBE> Buscar(ViviendaBE prm_Vivienda)
        {
            List<ViviendaBE> lstViviendas = new List<ViviendaBE>();
            ViviendaBE itemViviendaBE = null;
            try
            {
                using (DBML_ViviendaDataContext SQLDC = new DBML_ViviendaDataContext(CadenaConexionSQL))
                {
                    var resul = SQLDC.dsd_mnt_S_ViviendaDpto(prm_Vivienda.C_NumDpto, prm_Vivienda.C_NumEdificio);
                    foreach (var item in resul)
                    {
                        itemViviendaBE = new ViviendaBE();
                        itemViviendaBE.N_IdVivienda = item.N_IdVivienda;
                        itemViviendaBE.N_IdResidente = item.N_IdResidente;
                        itemViviendaBE.C_NumEdificio = item.C_NumEdificio;
                        itemViviendaBE.C_NumDpto = item.C_NumDpto;
                        itemViviendaBE.N_NumMetros = item.N_NumMetros;
                        itemViviendaBE.C_CodTipo = item.C_CodTipo;
                        itemViviendaBE.B_Estado = item.B_Estado;
                        
                        lstViviendas.Add(itemViviendaBE);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstViviendas;
        }

        public int Registrar(ViviendaBE itemVivienda)
        {
            int? codigoRetorno = -1;
            try
            {
                using (DBML_ViviendaDataContext SQLDC = new DBML_ViviendaDataContext(CadenaConexionSQL))
                {
                     SQLDC.dsd_mnt_I_Vivienda(
                       ref codigoRetorno ,
                        itemVivienda.N_IdResidente,
                        itemVivienda.C_NumEdificio,
                        itemVivienda.C_NumDpto,
                        itemVivienda.N_NumMetros,
                        itemVivienda.C_CodTipo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno == null ? 0 : codigoRetorno.Value;
        }

        public int Actualizar(ViviendaBE itemVivienda)
        {
            int codigoRetorno = -1;
            try
            {
                using (DBML_ViviendaDataContext SQLDC = new DBML_ViviendaDataContext(CadenaConexionSQL))
                {
                    codigoRetorno = SQLDC.dsd_mnt_U_Vivienda(
                        itemVivienda.N_IdVivienda,
                        itemVivienda.N_IdResidente,
                        itemVivienda.C_NumEdificio,
                        itemVivienda.C_NumDpto,
                        itemVivienda.N_NumMetros,
                        itemVivienda.C_CodTipo,
                        itemVivienda.B_Estado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno;
        }

        public bool Eliminar(int prm_N_IdVivienda)
        {
            int codigoRetorno = -1;
            try
            {
                using (DBML_ViviendaDataContext SQLDC = new DBML_ViviendaDataContext(CadenaConexionSQL))
                {
                    codigoRetorno = SQLDC.dsd_mnt_D_Vivienda(prm_N_IdVivienda);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno == 0 ? true : false;
        }



        public List<ViviendaBE> ListarViviendas()
        {
            List<ViviendaBE> objlistavivienda = new List<ViviendaBE>();
            objconeccion = new SqlConnection(CadenaConexionSQL);
            SqlCommand objcomand = new SqlCommand("ListarViviendas", objconeccion);
            objconeccion.Open();
            SqlDataReader reader = objcomand.ExecuteReader();
            while (reader.Read())
            {
                ViviendaBE objvivienda = new ViviendaBE();
                objvivienda.N_IdVivienda = reader.GetInt32(0);
                objvivienda.N_IdResidente = reader.GetInt32(0);
                objvivienda.C_NumEdificio = reader.GetString(10);
                objvivienda.C_NumDpto = reader.GetString(10);
                objvivienda.N_NumMetros = reader.GetDecimal(10);
                objvivienda.C_CodTipo = reader.GetString(5);
                objvivienda.B_Estado = reader.GetBoolean(1);
                objlistavivienda.Add(objvivienda);
            }

            return objlistavivienda;
        }

        public ViviendaBE ObtenerVivienda(int n_IdVivienda)
        {
            objconeccion = new SqlConnection(CadenaConexionSQL);
            SqlCommand objcomand = new SqlCommand("traer_vivienda", objconeccion);
            objcomand.CommandType = CommandType.StoredProcedure;
            objcomand.Parameters.Add("@N_IdVivienda", SqlDbType.Int);
            objcomand.Parameters["@N_IdVivienda"].Value = n_IdVivienda;
            objconeccion.Open();
            SqlDataReader reader = objcomand.ExecuteReader();

            ViviendaBE objvivienda = new ViviendaBE();
            while (reader.Read())
            {
                objvivienda.N_IdVivienda = reader.GetInt32(0);
                objvivienda.N_IdResidente = reader.GetInt32(0);
                objvivienda.C_NumEdificio = reader.GetString(10);
                objvivienda.C_NumDpto = reader.GetString(10);
                objvivienda.N_NumMetros = reader.GetDecimal(10);
                objvivienda.C_CodTipo = reader.GetString(5);
                objvivienda.B_Estado = reader.GetBoolean(1);
            }

            return objvivienda;
        }

        public Int32 CreaVivienda(ViviendaBE objvivienda)
        {
            try
            {
                //objvivienda.N_IdVivienda = reader.GetInt32(0);
                //objvivienda.N_IdResidente = reader.GetInt32(0);
                //objvivienda.C_NumEdificio = reader.GetString(10);
                //objvivienda.C_NumDpto = reader.GetString(10);
                //objvivienda.N_NumMetros = reader.GetDecimal(10);
                //objvivienda.C_CodTipo = reader.GetString(5);
                //objvivienda.B_Estado
        //        [DataMember]
        //public int N_IdVivienda { get; set; }
        //[DataMember]
        //public int N_IdResidente { get; set; }
        //[DataMember]
                objconeccion = new SqlConnection(CadenaConexionSQL);
                SqlCommand objcomand = new SqlCommand("insertar_vivienda", objconeccion);
                objcomand.CommandType = CommandType.StoredProcedure;                
                objcomand.Parameters.Add("@C_NumDpto", SqlDbType.VarChar, 10);
                objcomand.Parameters["@C_NumDpto"].Value = objvivienda.C_NumDpto;
                objcomand.Parameters.Add("@N_NumMetros", SqlDbType.Decimal);
                objcomand.Parameters["@N_NumMetros"].Value = objvivienda.N_NumMetros;
                objcomand.Parameters.Add("@C_CodTipo", SqlDbType.VarChar, 10);
                objcomand.Parameters["@C_CodTipo"].Value = objvivienda.C_CodTipo;
                objcomand.Parameters.Add("@B_Estado", SqlDbType.Bit);
                objcomand.Parameters["@B_Estado"].Value = objvivienda.B_Estado;               
                objconeccion.Open();
                Int32 id;
                id = Convert.ToInt32(objcomand.ExecuteScalar());
                objconeccion.Close();


                return id;
            }
            catch (Exception ex)
            {
                if (objconeccion.State == ConnectionState.Open)
                    objconeccion.Close();
                throw new Exception(ex.Message);
            }


        }

        public Int32 ActualizaVivienda(ViviendaBE objvivienda)
        {
            try
            {
                objconeccion = new SqlConnection(CadenaConexionSQL);
                SqlCommand objcomand = new SqlCommand("actualiza_vivienda", objconeccion);
                objcomand.CommandType = CommandType.StoredProcedure;
                objcomand.Parameters.Add("@N_IdVivienda", SqlDbType.Int);
                objcomand.Parameters["@N_IdVivienda"].Value = objvivienda.N_IdVivienda;
                objcomand.Parameters.Add("@N_IdResidente", SqlDbType.Int);
                objcomand.Parameters["@N_IdResidente"].Value = objvivienda.N_IdResidente;
                objcomand.Parameters.Add("@C_NumEdificio", SqlDbType.VarChar, 10);
                objcomand.Parameters["@C_NumEdificio"].Value = objvivienda.C_NumEdificio;
                objcomand.Parameters.Add("@C_NumDpto", SqlDbType.VarChar, 10);
                objcomand.Parameters["@C_NumDpto"].Value = objvivienda.C_NumDpto;
                objcomand.Parameters.Add("@N_NumMetros", SqlDbType.Decimal);
                objcomand.Parameters["@N_NumMetros"].Value = objvivienda.N_NumMetros;
                objcomand.Parameters.Add("@C_CodTipo", SqlDbType.VarChar, 10);
                objcomand.Parameters["@C_CodTipo"].Value = objvivienda.C_CodTipo;
                objcomand.Parameters.Add("@B_Estado", SqlDbType.Bit);
                objcomand.Parameters["@B_Estado"].Value = objvivienda.B_Estado; 
                objconeccion.Open();
                Int32 id;
                id = Convert.ToInt32(objcomand.ExecuteScalar());
                objconeccion.Close();


                return id;
            }
            catch (Exception ex)
            {
                if (objconeccion.State == ConnectionState.Open)
                    objconeccion.Close();
                throw new Exception(ex.Message);
            }


        }

    }
    }
