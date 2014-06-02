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
            if (!Page.IsPostBack)
            {
                CargarGrilla();
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

        }
    }
}