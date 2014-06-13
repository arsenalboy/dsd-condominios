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

                    }

                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text=ex.Message;
            }
        }
    }
}