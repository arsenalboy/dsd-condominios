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
    public partial class frmCuotaPagar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!Page.IsPostBack)
                {
                    Page.Title = "Pago de Cuota";
                    PagosServiceClient proxiPago = new PagosServiceClient();
                    IList<TipoPago> lstTipoPago =  proxiPago.ListarTipoPago();
                    ddlTipoPagoos.DataSource = lstTipoPago;
                    ddlTipoPagoos.DataTextField = "C_Descripcion";
                    ddlTipoPagoos.DataValueField = "N_IdTipoPago";
                    ddlTipoPagoos.DataBind();

                    String querystringID = string.Empty;
                    
                    if (Request.QueryString.Get("pm") != null)
                    {
                        querystringID = Request.QueryString.Get("pm");
                        PagosServiceClient proxiCuota = new PagosServiceClient();
                        Cuota cuota = proxiCuota.BuscarCuota(Convert.ToInt32(querystringID));
                        if (cuota != null)
                        {
                            txtResidenteVivienda.Text = "N° Dpto : " + cuota.objVivienda.C_NumDpto
                                                        + "/n - N° Edificio : " + cuota.objVivienda.C_NumEdificio
                                                        + "/n - [ Residente : " + cuota.objVivienda.objResidente.C_Apellidos + " ] ";
                            txtPeriodo.Text = cuota.C_Periodo;
                            txtFechaVcto.Text=cuota.D_FecVncto.Value.ToShortDateString().ToString();
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
                string strD_FecPago = txtFechaPago.Text;
                int intN_IdTipoPago = Convert.ToInt32(ddlTipoPagoos.SelectedValue);
                int intN_IdCuota = lblN_IdCuota.Text == string.Empty ? 0 : Convert.ToInt32(lblN_IdCuota.Text);
                double decN_Importe = Convert.ToDouble(txtImportePago.Text);
                PagosServiceClient proxiCuota = new PagosServiceClient();
                if (Request.QueryString.Get("pm") != null)
                    retornaMensaje = proxiCuota.PagarCuota(intN_IdCuota,strD_FecPago,txtNumeroOperacion.Text, intN_IdTipoPago);
                
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