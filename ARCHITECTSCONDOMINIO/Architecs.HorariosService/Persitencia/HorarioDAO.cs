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
        public List<HorarioBE> Listar(string prm_C_Periodo)
        {
            List<HorarioBE> lstHorario = new List<HorarioBE>();
            try
            {
               using (DBMLHorariosDataContext SQLDC = new DBMLHorariosDataContext(conexion))
                {
                    var resul = SQLDC.dsd_mnt_S_Horario();

                    foreach (var item in resul)
                    {
                        HorarioBE horario = new HorarioBE();
                        horario.N_IdHorario = item.N_IdHorario;
                        horario.C_Rango = item.C_Rango;
                        horario.B_Estado = item.B_Estado;
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
        
    }
}