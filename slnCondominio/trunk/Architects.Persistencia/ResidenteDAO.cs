using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Architects.Dominio;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Architects.Persistencia
{
    public class ResidenteDAO
    {
        string CadenaConexionSQL;
        SqlConnection objconeccion;

        public ResidenteDAO(string cadenaconexion)
        {
            CadenaConexionSQL = cadenaconexion;
        }

        public ResidenteDAO()
        {
            CadenaConexionSQL = new Utilitario().CadenaConeccion();
            
        }

        public List<Residente> ListarResidentes()
        {
            List<Residente> objlistaresidente =  new List<Residente>();
            objconeccion = new SqlConnection(CadenaConexionSQL);
            SqlCommand objcomand = new SqlCommand("ListarResidentes",objconeccion);
            objconeccion.Open();
            SqlDataReader reader = objcomand.ExecuteReader();
            while (reader.Read())
            {
                Residente objresidente = new Residente();
                objresidente.N_IdResidente = reader.GetInt32(0);
                objresidente.C_Nombre = reader.GetString(1);
                objresidente.C_Apellidos = reader.GetString(2);
                objresidente.N_TipoDoc = reader.GetInt32(3);
                objresidente.C_NumDocume = reader.GetString(4);
                objresidente.D_FecNacimi = reader.GetDateTime(5);
                objresidente.C_Correo =reader.GetString(6);
                objresidente.C_Clave =reader.GetString(7);
                objresidente.B_Estado = reader.GetBoolean(8);
                objlistaresidente.Add(objresidente);
            }

            return objlistaresidente;
        }

        public Int32 CreaResidente(Residente objresidente)
        {
            try
            {
                objconeccion = new SqlConnection(CadenaConexionSQL);
                SqlCommand objcomand = new SqlCommand("insertar_residente", objconeccion);
                objcomand.CommandType = CommandType.StoredProcedure;
                objcomand.Parameters.Add("@C_Nombre", SqlDbType.VarChar, 80);
                objcomand.Parameters["@C_Nombre"].Value = objresidente.C_Nombre;
                objcomand.Parameters.Add("@C_Apellidos", SqlDbType.VarChar, 100);
                objcomand.Parameters["@C_Apellidos"].Value = objresidente.C_Nombre;
                objcomand.Parameters.Add("@N_TipoDoc", SqlDbType.Int);
                objcomand.Parameters["@N_TipoDoc"].Value = objresidente.N_TipoDoc;
                objcomand.Parameters.Add("@C_NumDocume", SqlDbType.VarChar, 10);
                objcomand.Parameters["@C_NumDocume"].Value = objresidente.C_NumDocume;
                objcomand.Parameters.Add("@D_FecNacimi", SqlDbType.DateTime);
                objcomand.Parameters["@D_FecNacimi"].Value = objresidente.D_FecNacimi;
                objcomand.Parameters.Add("@C_Correo", SqlDbType.VarChar, 45);
                objcomand.Parameters["@C_Correo"].Value = objresidente.C_Correo;
                objcomand.Parameters.Add("@C_Clave", SqlDbType.VarChar, 14);
                objcomand.Parameters["@C_Clave"].Value = objresidente.C_Clave;
                objcomand.Parameters.Add("@B_Estado", SqlDbType.VarChar, 1);
                objcomand.Parameters["@B_Estado"].Value = objresidente.B_Estado;
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