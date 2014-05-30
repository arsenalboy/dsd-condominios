using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
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
        /*public List<HorarioBE> Listar(string prm_C_Periodo)
        {
            List<HorarioBE> lstHorario = new List<HorarioBE>();
            try
            {
                using (DBMLHorariossDataContext SQLDC = new DBMLHorariossDataContext(conexion))
                {
                    var resul = SQLDC.dsd_mnt_S_Cuota(prm_C_Periodo);

                    foreach (var item in resul)
                    {
                        Cuota cuota = new Cuota();
                        cuota.N_IdCuota = item.N_IdCuota;
                        cuota.C_Periodo = item.C_Periodo;
                        cuota.N_IdVivienda = item.N_IdVivienda;
                        lstHorario.Add(cuota);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstHorario;
        }*/
        
    }
}