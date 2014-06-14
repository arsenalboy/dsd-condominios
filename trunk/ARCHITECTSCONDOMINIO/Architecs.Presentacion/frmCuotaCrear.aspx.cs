using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Architecs.Presentacion.Dominio;
using Architecs.Presentacion.PagosService;

namespace Architecs.Presentacion
{
    public partial class frmCuotaCrear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!Page.IsPostBack)
                {
                    Page.Title = "Edición de Cuota";
                    string strURL = ConfigurationManager.AppSettings["URL_REST_vivienda"].ToString();
                    HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
                       .Create(strURL);
                    reqObtener.Method = "GET";
                    HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
                    StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
                    string viviendaJsonObtener = readerObtener.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    IList<Vivienda> lstVivienda = js.Deserialize<IList<Vivienda>>(viviendaJsonObtener);
                    ddlVivienda.DataSource = lstVivienda;
                    foreach (Vivienda vivienda in lstVivienda)
                        vivienda.C_NumEdificio = vivienda.C_NumEdificio + " - " + vivienda.C_NumDpto + " - " + vivienda.objResidente.C_Apellidos;
                    ddlVivienda.DataTextField = "C_NumEdificio";
                    ddlVivienda.DataValueField = "N_IdVivienda";
                    ddlVivienda.DataBind();

                    String querystringID = string.Empty;
                    
                    if (Request.QueryString.Get("pm") != null)
                    {
                        querystringID = Request.QueryString.Get("pm");
                        PagosServiceClient proxiCuota = new PagosServiceClient();
                        Cuota cuota = proxiCuota.BuscarCuota(Convert.ToInt32(querystringID));
                        if (cuota != null)
                        {
                            txtPeriodo.Text = cuota.C_Periodo;
                            txtFechaVcto.Text=cuota.D_FecVncto.Value.ToShortDateString().ToString();
                            ddlVivienda.SelectedValue= cuota.N_IdVivienda.ToString();
                            lblN_IdCuota.Text = cuota.N_IdCuota.ToString();
                            txtImportePago.Text= cuota.N_Importe.Value.ToString("N2");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text=ex.Message;
            }
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCuota.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Architects.Dominio.RetornaMensaje retornaMensaje = new Architects.Dominio.RetornaMensaje();
            try
            {
                string strC_Periodo = txtPeriodo.Text;
                string strD_FecVncto = txtFechaVcto.Text;
                int intN_IdVivienda = Convert.ToInt32(ddlVivienda.SelectedValue);
                int intN_IdCuota = lblN_IdCuota.Text == string.Empty ? 0 : Convert.ToInt32(lblN_IdCuota.Text);
                double decN_Importe = Convert.ToDouble(txtImportePago.Text);
                PagosServiceClient proxiCuota = new PagosServiceClient();
                if (Request.QueryString.Get("pm") == null)
                    retornaMensaje = proxiCuota.RegistrarCuota(strC_Periodo, intN_IdVivienda, decN_Importe, strD_FecVncto);
                else
                    retornaMensaje = proxiCuota.ActualizarCuota(intN_IdCuota, strC_Periodo, intN_IdVivienda, decN_Importe, strD_FecVncto);
                if (retornaMensaje.Exito)
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Blue;
                    lblN_IdCuota.Text = Request.QueryString.Get("pm") == null ? retornaMensaje.CodigoRetorno.ToString() : lblN_IdCuota.Text;
                    btnGuardar.Visible = false;
                }
                else
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = retornaMensaje.Mensage;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}