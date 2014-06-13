using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Architecs.Presentacion.SOAResidentes;
using System.Net;
using System.Text;
using System.IO;
using System.Configuration;
using System.Web.Script.Serialization;
using Architecs.Presentacion.Dominio;

namespace Architecs.Presentacion
{
    public partial class frmViviendaCrear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                SOAResidentes.ResidenteServiceClient proxi = new SOAResidentes.ResidenteServiceClient();
                List<ResidenteBE> listaResidentes = new List<ResidenteBE>();
                listaResidentes = proxi.ListarResidentes().ToList();
                ddlN_IdResidente.DataSource = listaResidentes;
                ddlN_IdResidente.DataValueField = "N_IdResidente";
                ddlN_IdResidente.DataTextField = "C_Apellidos";
                ddlN_IdResidente.DataBind();

                
                String querystringID = string.Empty;
                if (Request.QueryString.Get("pm") != null)
                {
                    Page.Title = "Edición de Vivienda";
                    querystringID = Request.QueryString.Get("pm");
                    string strURL = ConfigurationManager.AppSettings["URL_REST_vivienda"].ToString(); // "http://localhost:59151/ViviendasService.svc/Viviendas";

                    HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
                       .Create(strURL + "/" + querystringID);
                    reqObtener.Method = "GET";
                    HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
                    StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
                    string viviendaJsonObtener = readerObtener.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    Vivienda viviendaCreado = js.Deserialize<Vivienda>(viviendaJsonObtener);

                    lblN_IdVivienda.Text = viviendaCreado.N_IdVivienda.ToString();
                    ddlN_IdResidente.SelectedValue = viviendaCreado.N_IdResidente.ToString();
                    txtC_NumEdificio.Text = viviendaCreado.C_NumEdificio;
                    txtC_NumDpto.Text = viviendaCreado.C_NumDpto;
                    txtN_NumMetros.Text = viviendaCreado.N_NumMetros.ToString();
                    ddlC_CodTipo.SelectedValue = viviendaCreado.C_CodTipo;

                }

            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString.Get("pm") == null)
                {
                    // Prueba de creación de vivienda vía HTTP POST
                    string postdata = "{\"N_IdResidente\":\"" + ddlN_IdResidente.SelectedValue + "\"," +
                                       "\"C_NumEdificio\":\"" + txtC_NumEdificio.Text + "\"," +
                                       "\"C_NumDpto\":\"" + txtC_NumDpto.Text + "\"," +
                                       "\"N_NumMetros\":\"" + txtN_NumMetros.Text + "\"," +
                                       "\"C_CodTipo\":\"" + ddlC_CodTipo.SelectedValue + "\" }"; //JSON

                    byte[] data = Encoding.UTF8.GetBytes(postdata);

                    HttpWebRequest req = (HttpWebRequest)WebRequest
                         .Create(ConfigurationManager.AppSettings["URL_REST_vivienda"].ToString());

                    req.Method = "POST";
                    req.ContentLength = data.Length;
                    req.ContentType = "application/json";

                    var reqStream = req.GetRequestStream();
                    reqStream.Write(data, 0, data.Length);

                    var res = (HttpWebResponse)req.GetResponse();
                    StreamReader reader = new StreamReader(res.GetResponseStream());
                    string retornaMensajeJson = reader.ReadToEnd();

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    RetornaMensajeT retornaMensaje = js.Deserialize<RetornaMensajeT>(retornaMensajeJson);
                    lblN_IdVivienda.Text = retornaMensaje.CodigoRetorno.ToString();
                    lblMensaje.Text = retornaMensaje.Mensage;
                }
                else
                {
                    // Prueba de creación de vivienda vía HTTP POST
                    string postdata = "{\"N_IdVivienda\":\"" + lblN_IdVivienda.Text + "\"," +
                                       "\"N_IdResidente\":\"" + ddlN_IdResidente.SelectedValue + "\"," +
                                       "\"C_NumEdificio\":\"" + txtC_NumEdificio.Text + "\"," +
                                       "\"C_NumDpto\":\"" + txtC_NumDpto.Text + "\"," +
                                       "\"N_NumMetros\":\"" + txtN_NumMetros.Text + "\"," +
                                       "\"C_CodTipo\":\"" + ddlC_CodTipo.SelectedValue + "\" }"; //JSON

                    byte[] data = Encoding.UTF8.GetBytes(postdata);

                    HttpWebRequest req = (HttpWebRequest)WebRequest
                         .Create(ConfigurationManager.AppSettings["URL_REST_vivienda"].ToString()+"/" + lblN_IdVivienda.Text); 

                    req.Method = "PUT";
                    req.ContentLength = data.Length;
                    req.ContentType = "application/json";

                    var reqStream = req.GetRequestStream();
                    reqStream.Write(data, 0, data.Length);

                    var res = (HttpWebResponse)req.GetResponse();
                    StreamReader reader = new StreamReader(res.GetResponseStream());
                    string retornaMensajeJson = reader.ReadToEnd();

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    RetornaMensajeT retornaMensaje = js.Deserialize<RetornaMensajeT>(retornaMensajeJson);

                    lblMensaje.Text = retornaMensaje.Mensage;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }

        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmViviendas.aspx");
        }


    }
}