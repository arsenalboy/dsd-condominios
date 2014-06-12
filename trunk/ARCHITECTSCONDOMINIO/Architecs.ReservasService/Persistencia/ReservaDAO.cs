using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Architecs.ReservasService.Dominio;
using System.Data.SqlClient;
using System.Data;
using System.ServiceModel;

namespace Architecs.ReservasService.Persistencia
{
    public class ReservaDAO
    {
        string CadenaConexionSQL;
        SqlConnection objconeccion;

        public ReservaDAO(string cadenaconexion)
        {
            CadenaConexionSQL = cadenaconexion;
        }

        public ReservaDAO()
        {
            CadenaConexionSQL = ConexionUtil.CadenaConeccion();
        }

        public ReservasBE CrearReserva(ReservasBE ObjReserva)
        {
            try
            {
                objconeccion = new SqlConnection(CadenaConexionSQL);
                SqlCommand objcomand = new SqlCommand("INSERTAR_RESERVAS", objconeccion);
                objcomand.CommandType = CommandType.StoredProcedure;
                objcomand.Parameters.Add("@N_IdResidente", SqlDbType.Int);
                objcomand.Parameters["@N_IdResidente"].Value = ObjReserva.N_IdResidente;
                objcomand.Parameters.Add("@N_IdHorarioIni ", SqlDbType.Int);
                objcomand.Parameters["@N_IdHorarioIni "].Value = ObjReserva.N_IdHorarioIni;
                objcomand.Parameters.Add("@N_IdHorarioFin ", SqlDbType.Int);
                objcomand.Parameters["@N_IdHorarioFin "].Value = ObjReserva.N_IdHorarioFin;
                objcomand.Parameters.Add("@N_IdEspacioComun", SqlDbType.Int);
                objcomand.Parameters["@N_IdEspacioComun"].Value = ObjReserva.N_IdEspacioComun;
                objcomand.Parameters.Add("@D_FecRegistro", SqlDbType.Date);
                objcomand.Parameters["@D_FecRegistro"].Value = ObjReserva.D_FecRegistro;
                objcomand.Parameters.Add("@B_Estado", SqlDbType.Bit);
                objcomand.Parameters["@B_Estado"].Value = ObjReserva.B_Estado;
                objconeccion.Open();

                int id;
                id = Convert.ToInt32(objcomand.ExecuteScalar());
 
                objconeccion.Close();

                ObjReserva.N_IdReserva = id;
                return ObjReserva;
            }
            catch (Exception ex)
            {
                if (objconeccion.State == ConnectionState.Open)
                    objconeccion.Close();
                throw new FaultException(ex.Message);
            }
        }


        public List<EspacioComunBE> ListarEspacioComun()
        {
            try
            {
                List<EspacioComunBE> Lista = new List<EspacioComunBE>();
                objconeccion = new SqlConnection(CadenaConexionSQL);
                SqlCommand objcomand = new SqlCommand("LISTAR_ESPACIOCOMUN", objconeccion);
                objcomand.CommandType = CommandType.StoredProcedure;
                objconeccion.Open();
                SqlDataReader ObjDataReader = objcomand.ExecuteReader();   

                while (ObjDataReader.Read())
                {
                    EspacioComunBE objespaciocomun = new EspacioComunBE();
                    objespaciocomun.N_IdEspacioComun =  ObjDataReader.GetInt32(0);
                    objespaciocomun.C_Nombre = ObjDataReader.GetString(1);
                    objespaciocomun.B_Estado = true;
                    Lista.Add(objespaciocomun);
                }
                objconeccion.Close();

                return Lista;
            }
            catch (FaultException ex)
            {
                if (objconeccion.State == ConnectionState.Open)
                    objconeccion.Close();
                throw new FaultException(ex.Message);
            }
        }
    }
}