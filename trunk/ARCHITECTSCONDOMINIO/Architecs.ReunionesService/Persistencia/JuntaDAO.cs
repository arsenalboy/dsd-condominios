using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Architecs.ReunionesService.Dominio;
using System.Data;
using System.Data.SqlClient;
using Architects.Dominio;

namespace Architecs.ReunionesService.Persistencia
{
    public class JuntaDAO
    {

        string CadenaConexionSQL;
        SqlConnection objconeccion;

        public JuntaDAO(string cadenaconexion)
        {
            CadenaConexionSQL = cadenaconexion;
        }

        public JuntaDAO()
        {
            CadenaConexionSQL = ConexionUtil.CadenaConeccion();
        }

        public List<Directivo> listarDirectivos(string C_NomPer)
        {
            List<Directivo> listarDirectivos = new List<Directivo>();
            objconeccion = new SqlConnection(CadenaConexionSQL);
            SqlCommand objcomand = new SqlCommand("LISTAR_DIRECTIVOS", objconeccion);
            objcomand.CommandType = CommandType.StoredProcedure;
            objcomand.Parameters.Add("@C_NomPer", SqlDbType.VarChar,45);
            objcomand.Parameters["@C_NomPer"].Value = C_NomPer;
            objconeccion.Open();
            SqlDataReader reader = objcomand.ExecuteReader();
            while (reader.Read())
            {
                Directivo objdirectivo = new Directivo();
                objdirectivo.N_IdDirectivo = reader.GetInt32(0);
                objdirectivo.C_NomPer = reader.GetString(1);
                objdirectivo.C_Cargo = reader.GetString(2);
                objdirectivo.N_IdResidente = reader.GetInt32(3);
                objdirectivo.B_Estado = reader.GetBoolean(4);
                listarDirectivos.Add(objdirectivo);
            }
            return listarDirectivos;

        }

        public Int32 CreaJunta(Junta objJunta)
        {
            try
            {
                objconeccion = new SqlConnection(CadenaConexionSQL);
                SqlCommand objcomand = new SqlCommand("insertar_junta", objconeccion);
                objcomand.CommandType = CommandType.StoredProcedure;
                objcomand.Parameters.Add("@D_Fecha", SqlDbType.Date);
                objcomand.Parameters["@D_Fecha"].Value = objJunta.D_Fecha;
                objcomand.Parameters.Add("@C_Hora", SqlDbType.VarChar, 10);
                objcomand.Parameters["@C_Hora"].Value = objJunta.C_Hora;
                objcomand.Parameters.Add("@C_Tema", SqlDbType.VarChar,200);
                objcomand.Parameters["@C_Tema"].Value = objJunta.C_Tema;
                objcomand.Parameters.Add("@C_Acuerdo", SqlDbType.VarChar, 1000);
                objcomand.Parameters["@C_Acuerdo"].Value = objJunta.C_Acuerdo;
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

        public Int32 CreaJuntaDirectivos(JuntaDirectivos objJuntaDirectivos)
        {
            try
            {
                objconeccion = new SqlConnection(CadenaConexionSQL);
                SqlCommand objcomand = new SqlCommand("insertar_juntaDirectivos", objconeccion);
                objcomand.CommandType = CommandType.StoredProcedure;
                objcomand.Parameters.Add("@N_IdJunta", SqlDbType.Int);
                objcomand.Parameters["@N_IdJunta"].Value = objJuntaDirectivos.N_IdJunta;
                objcomand.Parameters.Add("@N_IdDirectivo", SqlDbType.Int);
                objcomand.Parameters["@N_IdDirectivo"].Value = objJuntaDirectivos.N_IdDirectivo;
                objcomand.Parameters.Add("@C_PreJun", SqlDbType.VarChar, 2);
                objcomand.Parameters["@C_PreJun"].Value = objJuntaDirectivos.C_PreJun;
                objcomand.Parameters.Add("@B_Estado", SqlDbType.Bit);
                objcomand.Parameters["@B_Estado"].Value = objJuntaDirectivos.B_Estado;
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

        public List<ListaJuntas> listarJuntas(string fechaini, string fechafin)
        {
            List<ListaJuntas> ListadeListaJuntas = new List<ListaJuntas>();
            objconeccion = new SqlConnection(CadenaConexionSQL);
            SqlCommand objcomand = new SqlCommand("LISTAR_JUNTAS", objconeccion);
            objcomand.CommandType = CommandType.StoredProcedure;
            objcomand.Parameters.Add("@FECHAINI", SqlDbType.Date);
            objcomand.Parameters["@FECHAINI"].Value = fechaini;
            objcomand.Parameters.Add("@FECHAFIN", SqlDbType.Date);
            objcomand.Parameters["@FECHAFIN"].Value = fechafin;
            objconeccion.Open();
            SqlDataReader reader = objcomand.ExecuteReader();
            while (reader.Read())
            {
                ListaJuntas obListaJuntas = new ListaJuntas();
                obListaJuntas.N_IdJunta = reader.GetInt32(0);
                obListaJuntas.D_Fecha = reader.GetString(1);
                obListaJuntas.C_Hora = reader.GetString(2);
                obListaJuntas.C_Tema = reader.GetString(3);
                obListaJuntas.C_Acuerdo = reader.GetString(4);
                obListaJuntas.C_NomPer = reader.GetString(5);
                obListaJuntas.C_Cargo = reader.GetString(6);
                obListaJuntas.C_PREJUN = reader.GetString(7);
                ListadeListaJuntas.Add(obListaJuntas);
            }
            return ListadeListaJuntas;

        }

    }
}