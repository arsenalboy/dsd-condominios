using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Architecs.Presentacion.SOAResidentes;
using Architecs.Presentacion.Dominio;
using System.Net;
using System.IO;
using Architects.Dominio;
using System.Text;
using System.Runtime.Serialization;

namespace Architecs.Presentacion.Visitas
{
    public partial class frmRegistrarVisita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarResidentes();
            }
        }

        protected void Cleaning()
        {
            txtC_NumDocumento.Text = string.Empty;
            txtC_Nombre.Text = string.Empty;
            txtFecha.Text = string.Empty;
            DdlResidente.SelectedValue = "";
        }

        protected void CargarResidentes()
        {
            ResidenteServiceClient client = new ResidenteServiceClient();

            List<SOAResidentes.ResidenteBE> listaResidentes = new List<SOAResidentes.ResidenteBE>(client.ListarResidentes());

            DdlResidente.DataSource = listaResidentes;
            DdlResidente.DataValueField = "C_NumDocume";
            DdlResidente.DataTextField = "C_Apellidos";
            DdlResidente.DataBind();

            DdlResidente.Items.Insert(0, new ListItem("Seleccione", ""));
        }

        protected void btnRegistar_Click(object sender, EventArgs e)
        {
            StringBuilder postData = new StringBuilder(250);
            postData.Append("<VisitanteBE>");
            postData.Append("<C_NumDocumento>");
            postData.Append(txtC_NumDocumento.Text);
            postData.Append("</C_NumDocumento>");
            postData.Append("<C_Nombre>");
            postData.Append(txtC_Nombre.Text);            
            postData.Append("</C_Nombre>");
            postData.Append("<D_FecVisita>");
            postData.Append(txtFecha.Text);                
            postData.Append("</D_FecVisita>");
            postData.Append("<O_ResidenteBE><C_NumDocume>");
            postData.Append(DdlResidente.SelectedItem.Value);
            postData.Append("</C_NumDocume></O_ResidenteBE>");
            postData.Append("</VisitanteBE>");

            byte[] data = Encoding.UTF8.GetBytes(postData.ToString());

            string strUri = "http://localhost:62061/VisitaService.svc/Visitantes";

            HttpWebRequest req = WebRequest.Create(strUri) as HttpWebRequest;
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/xml; charset=UTF-8";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            try
            {
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());

                DataContractSerializer dcs = new DataContractSerializer(typeof(VisitanteBE));
                VisitanteBE visitanteDeserializado = (VisitanteBE)dcs.ReadObject(reader.BaseStream);

                String strScript;
                strScript = "<script>alert('Se ha registrado al visitante " + visitanteDeserializado.C_Nombre + " exitosamente. ')</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", strScript, false);

                Cleaning();
            }
            catch (WebException ex)
            {
                HttpStatusCode code = ((HttpWebResponse)ex.Response).StatusCode;
                string message = ((HttpWebResponse)ex.Response).StatusDescription;
                StreamReader reader = new StreamReader(ex.Response.GetResponseStream());

                DataContractSerializer dcs = new DataContractSerializer(typeof(string));
                string mensaje = (string)dcs.ReadObject(reader.BaseStream);

                String strScript;
                strScript = "<script>alert('" + mensaje + "')</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", strScript, false);              
            }
        }
    }
}