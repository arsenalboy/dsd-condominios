using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;

using Architecs.Presentacion.SOAResidentes;
using Architecs.Presentacion.Dominio;
using System.Net;
using System.IO;
using Architects.Dominio;

namespace Architecs.Presentacion.Visitas
{
    public partial class frmVisita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String script = "document.getElementById('divaviso').style.display='none';";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", script, true);

                CargarResidentes();
            }
        }

        protected void CargarResidentes()
        {
            ResidenteServiceClient client = new ResidenteServiceClient();

            List<SOAResidentes.ResidenteBE> listaResidentes = new List<SOAResidentes.ResidenteBE>(client.ListarResidentes());
                
            DdlResidente.DataSource = listaResidentes;
            DdlResidente.DataValueField = "C_NumDocume";
            DdlResidente.DataTextField = "C_Apellidos";
            DdlResidente.DataBind();

            DdlResidente.Items.Insert(0, new ListItem("Todos", ""));
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            string strUri = string.Empty;
            string strNroDocResidente = DdlResidente.SelectedItem.Value;
            HttpWebRequest req = null;
            StreamReader reader = null;
            List<VisitanteBE> visitantesDeserializado = null;

            try
            {
                if (strNroDocResidente.Length > 0)
                {
                    strUri = string.Format("http://localhost:62061/VisitaService.svc/Visitantes/Residente/{0}",
                       Uri.EscapeUriString(strNroDocResidente));

                    req = WebRequest.Create(strUri) as HttpWebRequest;
                    req.Method = "GET";
                    var res = (HttpWebResponse)req.GetResponse();
                    reader = new StreamReader(res.GetResponseStream());

                    string visitantesJson = reader.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    visitantesDeserializado = js.Deserialize<List<VisitanteBE>>(visitantesJson);
                }
                else if (txtFecVisita.Text.Length > 0)
                {
                    strUri = string.Format("http://localhost:62061/VisitaService.svc/Visitantes/xml/Fecha/{0}",
                    Uri.EscapeUriString(txtFecVisita.Text));

                    req = WebRequest.Create(strUri) as HttpWebRequest;
                    req.Method = "GET";

                    var res = (HttpWebResponse)req.GetResponse();
                    reader = new StreamReader(res.GetResponseStream());

                    DataContractSerializer dcs = new DataContractSerializer(typeof(List<VisitanteBE>));
                    visitantesDeserializado = (List<VisitanteBE>)dcs.ReadObject(reader.BaseStream);
                }
                grVisitas.DataSource = visitantesDeserializado;
                grVisitas.DataBind();

                if (visitantesDeserializado.Count == 0)
                {
                    String script2 = "document.getElementById('divaviso').style.display='block';";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", script2, true);
                }
            }
            catch (WebException ex)
            {
                HttpStatusCode code = ((HttpWebResponse)ex.Response).StatusCode;
                string message = ((HttpWebResponse)ex.Response).StatusDescription;
                reader = new StreamReader(ex.Response.GetResponseStream());

                DataContractSerializer dcs = new DataContractSerializer(typeof(string));
                string mensaje = (string)dcs.ReadObject(reader.BaseStream);

                String strScript;
                strScript = "<script>alert('" + mensaje + "')</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", strScript, false);
            }
        }
    }
}