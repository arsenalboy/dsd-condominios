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
