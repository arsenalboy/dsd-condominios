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

            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Prueba de creación de vivienda vía HTTP POST
            string postdata = "{\"N_IdResidente\":\"" + ddlN_IdResidente.SelectedValue + "\"," +
                               "\"C_NumEdificio\":\"" + txtC_NumEdificio.Text + "\"," +
                               "\"C_NumDpto\":\"" + txtC_NumDpto.Text + "\"," +
                               "\"N_NumMetros\":\"" + txtN_NumMetros.Text + "\"," +
                               "\"C_CodTipo\":\"" + ddlC_CodTipo + "\" }"; //JSON


            byte[] data = Encoding.UTF8.GetBytes(postdata);

            HttpWebRequest req = (HttpWebRequest)WebRequest
                 .Create(ConfigurationManager.AppSettings["URL_REST_vivienda"]);

            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string alumnoJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            RetornaMensajeT retornaMensaje = js.Deserialize<RetornaMensajeT>(alumnoJson);

            
        }
    }
}