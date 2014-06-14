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
            lblMensajes.Text = "Probando";
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
                    Response.Redirect("frmViviendaCrear.aspx?pm=" + e.CommandArgument);
                    break;

                case "Eliminar":
                    try
                    {
                        lblMensajes.Text = string.Empty;
                        string strURL = "http://localhost:59151/ViviendasService.svc/Viviendas";
                        string strID = e.CommandArgument.ToString();
                        HttpWebRequest reqEliminar = (HttpWebRequest)WebRequest
                           .Create(strURL + "/" + strID);
                        reqEliminar.Method = "DELETE";
                        HttpWebResponse resEliminar = (HttpWebResponse)reqEliminar.GetResponse();

                        string strURL2 = "http://localhost:59151/ViviendasService.svc/Viviendas";
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


        protected void gvViviendas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvViviendas.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmViviendaCrear.aspx");
        }


    }
}