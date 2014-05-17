using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Architects.Dominio;
using System.Data;
using System.Data.SqlClient;
using System.Configuration.Assemblies;

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
            CadenaConexionSQL = "workstation id=condominio.mssql.somee.com;packet size=4096;user id=julioanyosa_SQLLogin_1;pwd=spnnkydfl1;data source=condominio.mssql.somee.com;persist security info=False;initial catalog=condominio";
            // System.Configuration.ConfigurationSettings.AppSettings["CadenaConexion"].ToString();
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
                objresidente.N_IdRes = reader.GetInt32(0);
                objresidente.C_NomRes = reader.GetString(1);
                objresidente.N_TipDoc = reader.GetInt32(2);
                objresidente.D_FecNac = reader.GetDateTime(3);
                objresidente.C_Correo =reader.GetString(4);
                objresidente.C_NumDoc =reader.GetString(5);
                objresidente.C_Clave =reader.GetString(6);
                objresidente.C_EstReg =reader.GetString(7);
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
                objcomand.Parameters.Add("@C_NomRes", SqlDbType.VarChar, 60);
                objcomand.Parameters["@C_NomRes"].Value = objresidente.C_NomRes;
                objcomand.Parameters.Add("@N_TipDoc", SqlDbType.Int);
                objcomand.Parameters["@N_TipDoc"].Value = objresidente.N_TipDoc;
                objcomand.Parameters.Add("@D_FecNac", SqlDbType.DateTime);
                objcomand.Parameters["@D_FecNac"].Value = objresidente.D_FecNac;
                objcomand.Parameters.Add("@C_Correo", SqlDbType.VarChar, 45);
                objcomand.Parameters["@C_Correo"].Value = objresidente.C_Correo;
                objcomand.Parameters.Add("@C_NumDoc", SqlDbType.VarChar, 10);
                objcomand.Parameters["@C_NumDoc"].Value = objresidente.C_NumDoc;
                objcomand.Parameters.Add("@C_Clave", SqlDbType.VarChar, 14);
                objcomand.Parameters["@C_Clave"].Value = objresidente.C_Clave;
                objcomand.Parameters.Add("@C_EstReg", SqlDbType.VarChar, 1);
                objcomand.Parameters["@C_EstReg"].Value = objresidente.C_EstReg;
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