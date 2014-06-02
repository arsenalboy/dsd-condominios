using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Architects.Dominio;


namespace Architecs.HorariosService.Persitencia
{
    public class HorarioDAO
    {
        private string conexion = string.Empty;
        public HorarioDAO()
        {
            conexion = ConexionUtil.CadenaConeccion();
        }
        public List<HorarioBE> ListarHorariosDisponibles(DateTime prm_fecha, int prm_idEspacio)
        {
            List<HorarioBE> lstHorario = new List<HorarioBE>();
            try
            {
               using (DBMLHorariosDataContext SQLDC = new DBMLHorariosDataContext(conexion))
                {
                    var resul = SQLDC.dsd_mnt_S_HorarioDisponible(prm_fecha, prm_idEspacio);
                    string estado;
                    foreach (var item in resul)
                    {
                        HorarioBE horario = new HorarioBE();
                        horario.N_IdHorario = item.N_IdHorario;
                        horario.C_Rango = item.C_Rango;
                        estado = item.Estado;
                        lstHorario.Add(horario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstHorario;
        }

        public int Registrar(HorarioBE horario)
        {
            int? codigoRetorno = -1;

            try
            {
                using (DBMLHorariosDataContext SQLDC = new DBMLHorariosDataContext(conexion))
                {
                    SQLDC.dsd_mnt_I_Horario(
                        horario.C_Rango
                       );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno == null ? 0 : codigoRetorno.Value;
        }

        public int Actualizar(HorarioBE horario)
        {
            int codigoRetorno = -1;
            try
            {
                using (DBMLHorariosDataContext SQLDC = new DBMLHorariosDataContext(conexion))
                {
                    codigoRetorno = SQLDC.dsd_mnt_U_Horario(
                        horario.N_IdHorario,
                        horario.C_Rango,
                        horario.B_Estado
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno;
        }

        public bool Eliminar(int prm_N_IdHorario)
        {
            int codigoRetorno = -1;
            try
            {
                using (DBMLHorariosDataContext SQLDC = new DBMLHorariosDataContext(conexion))
                {
                    codigoRetorno = SQLDC.dsd_mnt_D_Horario(prm_N_IdHorario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoRetorno == 0 ? true : false;
        }

    }
}