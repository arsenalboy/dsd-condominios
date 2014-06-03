using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Architecs.Presentacion.Dominio;
using System.Configuration;

namespace Architecs.Presentacion
{
    public partial class frmViviendas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    CargarGrilla();
                }
                this.btnNuevo.Attributes.Add("OnClick", "OpenPopup('frmViviendaCrear.aspx',600,480)");
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message;
            }
        }

        private void CargarGrilla()
        {
            // Prueba de OBTENER las viviendas vía HTTP GET - REST

            string strURL = ConfigurationManager.AppSettings["URL_REST_vivienda"].ToString();

            HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
               .Create(strURL);
            reqObtener.Method = "GET";
            HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
            StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
            string viviemdasJsonObtener = readerObtener.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            IList<Vivienda> lstViviendas = js.Deserialize<List<Vivienda>>(viviemdasJsonObtener);

            gvViviendas.DataSource = lstViviendas;
            gvViviendas.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            lblMensajes.Text = string.Empty;  
        }

        protected void gvViviendas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Editar":
                    break;

                case "Eliminar":
                    try
                    {
                        lblMensajes.Text = string.Empty;  
                        string strURL = "http://localhost:62023/ViviendasService.svc/Viviendas";
                        string strID = e.CommandArgument.ToString();
                        HttpWebRequest reqEliminar = (HttpWebRequest)WebRequest
                           .Create(strURL + "/" + strID);
                        reqEliminar.Method = "DELETE";
                        HttpWebResponse resEliminar = (HttpWebResponse)reqEliminar.GetResponse();

                        string strURL2 = "http://localhost:62023/ViviendasService.svc/Viviendas";
                        string strID2 = e.CommandArgument.ToString();
                        HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
                           .Create(strURL2 + "/" + strID2);
                        reqObtener.Method = "GET";
                        HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
                        StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
                        string viviendaJsonObtener = readerObtener.ReadToEnd();
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        Vivienda viviendaEliminada = js.Deserialize<Vivienda>(viviendaJsonObtener);
                        if (viviendaEliminada == null)
                            lblMensajes.Text = "Registro eliminado satisfactoriamente.";
                        CargarGrilla();
                    }
                    catch (Exception ex)
                    {
                        lblMensajes.Text = ex.Message;
                    }
                    break;
            }
        }

        protected void gvViviendas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ImageButton btnEditar = (ImageButton)e.Row.FindControl("btnEditar");
                HiddenField hhdIDVivienda = (HiddenField)e.Row.FindControl("hhdIDVivienda");
                btnEditar.Attributes.Add("Onclick", "OpenPopup('frmViviendaCrear.aspx?pm=" + hhdIDVivienda.Value + "',600,480)");
            }
        }
    }
}