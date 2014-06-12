using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace Architecs.Presentacion.Reservas
{
    public partial class CreaReserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CARGAMOS LOS COMBOS Y LOS HORARIOS DISPONIBLES
            if (!IsPostBack)
            {
                //listarreserva
                ReservaService.ReservaServiceClient objreservaServ = new ReservaService.ReservaServiceClient();
                List<ReservaService.EspacioComunBE> ListaReservaComun = new List<ReservaService.EspacioComunBE>();
                ListaReservaComun = objreservaServ.ListarEspacioComun();
                ReservaService.EspacioComunBE objtodo = new ReservaService.EspacioComunBE();
                objtodo.N_IdEspacioComun = 0;
                objtodo.C_Nombre = "[SELECCIONE]";
                ListaReservaComun.Insert(0, objtodo);
                CboEspacio.DataTextField = "C_Nombre";
                CboEspacio.DataValueField = "N_IdEspacioComun";
                CboEspacio.DataSource = ListaReservaComun;
                CboEspacio.DataBind();

                

            }
        }

        protected void TxtFechReserva_TextChanged(object sender, EventArgs e)
        {
            LlenarHora();
            LblFecha.Text = TxtFechReserva.Text;
        }

        private void LlenarHora()
        {
            if (CboEspacio.SelectedIndex != -1 & TxtFechReserva.Text != "")
            {
                //listar horarios
                HorarioService.HorarioServiceClient ObjHorarioServ = new HorarioService.HorarioServiceClient();
                List<HorarioService.HorarioBE> ListaHorario = new List<HorarioService.HorarioBE>();
                ListaHorario = ObjHorarioServ.ListarHorariosDisponibles(Convert.ToDateTime(TxtFechReserva.Text), Convert.ToInt32(CboEspacio.SelectedValue));

                HorarioService.HorarioBE OBJHORATODO = new HorarioService.HorarioBE();
                OBJHORATODO.N_IdHorario = 0;
                OBJHORATODO.C_Rango = "[SELECCIONE]";
                ListaHorario.Insert(0, OBJHORATODO);

                CboHoraIni.DataTextField = "C_Rango";
                CboHoraIni.DataValueField = "N_IdHorario";
                CboHoraIni.DataSource = ListaHorario;
                CboHoraIni.DataBind();

                CboHoraFin.DataTextField = "C_Rango";
                CboHoraFin.DataValueField = "N_IdHorario";
                CboHoraFin.DataSource = ListaHorario;
                CboHoraFin.DataBind();
            }
        }

        protected void CboEspacio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboEspacio.SelectedIndex != 0)
                LlenarHora();
        }

        protected void CboHoraIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboHoraIni.SelectedIndex != 0)
                LblHoraIni.Text = CboHoraIni.SelectedItem.ToString().Substring(0, 5).Trim();
        }

        protected void CboHoraFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboHoraFin.SelectedIndex != 0)
            LblHoraFin.Text = CboHoraFin.SelectedItem.ToString().Substring(0,5).Trim();
        }

        protected void BtnGrabar_Click(object sender, EventArgs e)
        {
            //grabamos
            try
            {
                lblcorrecto.Text = "";
                if (CboHoraIni.SelectedIndex != 0 & CboHoraFin.SelectedIndex != 0 & CboEspacio.SelectedIndex != 0 & TxtFechReserva.Text != "")
                {
                    //se inserta la reserva
                    ReservaService.ReservaServiceClient objreservaServ = new ReservaService.ReservaServiceClient();
                    ReservaService.ReservasBE ObjReserva = new ReservaService.ReservasBE();
                    ObjReserva.N_IdResidente = 3;
                    ObjReserva.N_IdHorarioIni = Convert.ToInt32(CboHoraIni.SelectedValue);
                    ObjReserva.N_IdHorarioFin =Convert.ToInt32(CboHoraFin.SelectedValue);
                    ObjReserva.N_IdEspacioComun =Convert.ToInt32(CboEspacio.SelectedValue);
                    ObjReserva.D_FecRegistro = Convert.ToDateTime( TxtFechReserva.Text);
                    ObjReserva.B_Estado = true;
                    objreservaServ.CreaReserva(ObjReserva);

                    lblcorrecto.Text = "Reserva para el dia " + Convert.ToDateTime(TxtFechReserva.Text).ToShortDateString() + " de " + LblHoraIni.Text + " a " + LblHoraFin.Text ;
                    String script = "document.getElementById('divacepto').style.display='block';";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", script, true);
                }
            }
            catch (Exception ex)
            {
                lblcorrecto.Text = "";
                String strScript;
                strScript = "<script>alert('" + ex.Message + "')</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", strScript, false);
            }
        }

    
    }
}