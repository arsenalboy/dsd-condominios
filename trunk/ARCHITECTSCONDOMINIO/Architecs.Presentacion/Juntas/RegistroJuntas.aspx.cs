using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Architecs.Presentacion.Dominio;
using System.Xml.Linq;

namespace Architecs.Presentacion.Juntas
{
    public partial class RegistroJuntas : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Directivo> listdirectivo = new List<Directivo>();
                Session["listdirectivo"] = listdirectivo;
                GvDirectivos.DataSource = listdirectivo;
                GvDirectivos.DataBind();
            }
    
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                TraerDirectores();
                MpDirectores.Show();

            }
            catch (Exception ex)
            {

                throw;
            }


        }

        protected void TraerDirectores()
        {
            List<Directivo> listdirectivo2 = new List<Directivo>();
            //Directivo objdirectivo = new Directivo();
            //listdirectivo2.Add(objdirectivo);
            GvBusca.DataSource = listdirectivo2;
            GvBusca.DataBind();
        }

        protected void BtnBusca_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                List<JuntaService.Directivo> listdirectivo2;
                JuntaService.JuntaServiceClient objjunta = new JuntaService.JuntaServiceClient();
                listdirectivo2 = objjunta.listarDirectivos(TxtBuscar.Text);
                GvBusca.DataSource = listdirectivo2;
                GvBusca.DataBind();
            }
            catch (Exception)
            {
                
                throw;
            }
          
        }

        protected void btnSelecciona_Click(object sender, ImageClickEventArgs e)
        {
            //se agrega a al lista
            ImageButton imgButton;
            GridViewRow gvrFila;
            int N_IdDirectivo;
            string C_NomPer;

            imgButton = (ImageButton)sender;
            gvrFila = (GridViewRow)imgButton.NamingContainer;
            int index = gvrFila.DataItemIndex;

            N_IdDirectivo = (int)GvBusca.DataKeys[index]["N_IdDirectivo"];
            C_NomPer = GvBusca.DataKeys[index]["C_NomPer"].ToString();

            Directivo dir = new Directivo();
            dir.N_IdDirectivo = N_IdDirectivo;
            dir.C_NomPer = C_NomPer;

            ((List<Directivo>)Session["listdirectivo"]).Add(dir);
            GvDirectivos.DataSource = (List<Directivo>)Session["listdirectivo"];
            GvDirectivos.DataBind();

        }

        protected void ChkSeleccionado_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkBoxSel; 
            CheckBox chkBox;
            GridViewRow gvRowSel; 

            chkBoxSel = (CheckBox)sender;
            gvRowSel = (GridViewRow)chkBoxSel.NamingContainer;

            foreach (GridViewRow gvRow in GvDirectivos.Rows)
            {
                chkBox = (CheckBox)gvRow.FindControl("ChkSeleccionado");
                chkBox.Checked = false;
            }
            ((CheckBox)GvDirectivos.Rows[gvRowSel.DataItemIndex].FindControl("ChkSeleccionado")).Checked = true;
        }

        protected void BtnGrabar_Click(object sender, EventArgs e)
        {
            try 
	        {	        
		      //grabamos las juntas
                JuntaService.JuntaServiceClient objjunta = new JuntaService.JuntaServiceClient();
                //primero grabamos la cabecera
                int id;
                id = objjunta.CreaJunta(Convert.ToDateTime(TxtFecha.Text), TxtHora.Text, TxtTemas.Text, txtAcuerdos.Text);

                //ahora insertamos los miembros
                CheckBox chkBox;
               
                foreach (GridViewRow gvRow in GvDirectivos.Rows)
                {
                    chkBox = (CheckBox)gvRow.FindControl("ChkSeleccionado");
                    string valor;
                    if(chkBox.Checked)
                        valor ="SI";
                    else
                        valor = "NO";

                    int N_IdDirectivo;
                    N_IdDirectivo = (int)GvBusca.DataKeys[gvRow.DataItemIndex]["N_IdDirectivo"];
                    objjunta.CreaJuntaDirectivos(id, N_IdDirectivo, valor, true);
                }

                String strScript;
                strScript = "<script>alert('Se grabo la junta correctamente.')</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", strScript, false);

                limpiar();
	        }
	        catch (Exception ex)
	        {
                String strScript;
                strScript = "<script>alert('" + ex.Message + "')</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", strScript, false);
	        }
          
        }


        void limpiar()
        {
            TxtFecha.Text = "";
            TxtHora.Text="";
            TxtTemas.Text = "";
            txtAcuerdos.Text = "";

            List<Directivo> listdirectivo = new List<Directivo>();
            Session["listdirectivo"] = listdirectivo;
            GvDirectivos.DataSource = listdirectivo;
            GvDirectivos.DataBind();
        }
    }
}