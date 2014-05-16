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
            CadenaConexionSQL = System.Configuration.ConfigurationSettings.AppSettings["CadenaConexion"].ToString();
        }

        public List<Residente> ListarResidentes()
        {
            List<Residente> objlistaresidente =  new List<Residente>();
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
                objresidente.C_NumDoc =reader.GetString(4);
                objresidente.C_Clave =reader.GetString(4);
                objresidente.C_EstReg =reader.GetString(4);
                objlistaresidente.Add(objresidente);
            }

            return objlistaresidente;
        }

    }

   
}