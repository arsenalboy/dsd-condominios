using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Web;
using System.Net;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;
using Architecs.Presentacion.Dominio;

namespace Architecs.Presentacion.Juntas
{
    public partial class ConsultaJuntas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String script = "document.getElementById('divaviso').style.display='none';";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", script, true);
            }
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                JuntaService.JuntaServiceClient objjuntaservice = new JuntaService.JuntaServiceClient();

                List<JuntaService.ListaJuntas> ObjListaJuntas = new List<JuntaService.ListaJuntas>();
                ObjListaJuntas = objjuntaservice.listarJuntas(TxtDesde.Text, TxtHasta.Text); 
                DgvJuntas.DataSource = ObjListaJuntas;
                DgvJuntas.DataBind();

                if (ObjListaJuntas.Count == 0)
                {
                    String script2 = "document.getElementById('divaviso').style.display='block';";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", script2, true);
                }
            }
            catch (FaultException ex)
            {
                String strScript;
                strScript = "<script>alert('" + ex.Message + "')</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", strScript, false);
            }
        }
    }
}