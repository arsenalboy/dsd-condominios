using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Architecs.QuejasService.Dominio;
using System.Data.SqlClient;
using System.Data;
using Architects.Dominio;

namespace Architecs.QuejasService.Persistencia
{
    public class QuejaDAO
    {
        string CadenaConexionSQL;
        SqlConnection objconeccion;

        public QuejaDAO(string cadenaconexion)
        {
            CadenaConexionSQL = cadenaconexion;
        }

        public QuejaDAO()
        {
            CadenaConexionSQL = ConexionUtil.CadenaConeccion();
        }

        public List<Queja> listarQuejas(string FechaIni, string FechaFin, string C_Tipo)
        {
            List<Queja> listarQuejas = new List<Queja>();
            objconeccion = new SqlConnection(CadenaConexionSQL);
            SqlCommand objcomand = new SqlCommand("LISTAR_QuejaS", objconeccion);
            objcomand.CommandType = CommandType.StoredProcedure;
            objcomand.Parameters.Add("@FechaIni", SqlDbType.DateTime);
            objcomand.Parameters["@FechaIni"].Value = FechaIni;
            objcomand.Parameters.Add("@FechaFin", SqlDbType.DateTime);
            objcomand.Parameters["@FechaFin"].Value = FechaFin;
            objcomand.Parameters.Add("@C_Tipo", SqlDbType.VarChar,45);
            objcomand.Parameters["@C_Tipo"].Value = C_Tipo;
            objconeccion.Open();
            SqlDataReader reader = objcomand.ExecuteReader();
            while (reader.Read())
            {
                Queja objQueja = new Queja();
                objQueja.N_IdQueja = reader.GetInt32(0);
                objQueja.N_IdResidente = reader.GetInt32(1);
                objQueja.C_Tipo = reader.GetString(2);
                objQueja.C_Motivo = reader.GetString(3);
                objQueja.D_FecRegistro = reader.GetDateTime(4);
                objQueja.B_Estado = reader.GetBoolean(5);

                ResidenteBE objresidente = new ResidenteBE();
                objresidente.C_Nombre = reader.GetString(6);
                objresidente.C_NumDocume = reader.GetString(7);
                objQueja.Residente = objresidente;

                objQueja.C_Detalle = reader.GetString(8);
                objQueja.D_FecQueja = reader.GetString(9);
                listarQuejas.Add(objQueja);
            }
            return listarQuejas;

        }

        public Queja CreaQueja(Queja objQueja)
        {
            try
            {
                objconeccion = new SqlConnection(CadenaConexionSQL);
                SqlCommand objcomand = new SqlCommand("insertar_queja", objconeccion);
                objcomand.CommandType = CommandType.StoredProcedure;
                objcomand.Parameters.Add("@N_IdResidente", SqlDbType.Int);
                objcomand.Parameters["@N_IdResidente"].Value = objQueja.N_IdResidente;
                objcomand.Parameters.Add("@C_Tipo ", SqlDbType.VarChar, 45);
                objcomand.Parameters["@C_Tipo "].Value = objQueja.C_Tipo;
                objcomand.Parameters.Add("@C_Motivo", SqlDbType.VarChar, 1000);
                objcomand.Parameters["@C_Motivo"].Value = objQueja.C_Motivo;
                objcomand.Parameters.Add("@C_Detalle", SqlDbType.VarChar, 1000);
                objcomand.Parameters["@C_Detalle"].Value = objQueja.C_Detalle;
                objcomand.Parameters.Add("@D_FecQueja", SqlDbType.DateTime);
                objcomand.Parameters["@D_FecQueja"].Value = objQueja.D_FecQueja;
                objconeccion.Open();
               
                string cadenadevuelta;
                string[] valores;
                cadenadevuelta = Convert.ToString(objcomand.ExecuteScalar());
                valores = cadenadevuelta.Split(';');
                
                objconeccion.Close();

                objQueja.N_IdQueja =  Convert.ToInt32(valores[0]);
                objQueja.D_FecRegistro = Convert.ToDateTime(valores[1]);
                return objQueja;
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