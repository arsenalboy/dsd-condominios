using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Script.Serialization;
using System.Net;
using System.Text;
using Architecs.Presentacion.Dominio;
using System.Xml.Linq;

namespace Architecs.Presentacion.Quejas
{
    public partial class CreaQueja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonEnviar_Click(object sender, EventArgs e)
        {
            // se serializa en xml y se envia
          
            XElement xmlTree1 = new XElement("Queja",
                new XElement("N_IdResidente", 1),
                new XElement("C_Tipo", CboTipoQueja.SelectedValue),
                new XElement("C_Motivo", txtMotivo.Text)
            );

            byte[] data = Encoding.UTF8.GetBytes(xmlTree1.ToString());

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:62070/QuejaService.svc/Quejas");

            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/xml";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string alumnoJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Queja QuejaCreada = js.Deserialize<Queja>(alumnoJson);

            
        }
    }
}