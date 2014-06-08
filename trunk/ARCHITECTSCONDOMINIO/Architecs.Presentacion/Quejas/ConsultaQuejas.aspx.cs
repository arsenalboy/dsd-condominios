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

namespace Architecs.Presentacion.Quejas
{
    public partial class ConsultaQuejas : System.Web.UI.Page
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
                //string postdata = "{\"FechaIni\":\"" + TxtDesde.Text + "\",\"FechaFin\":\"" + txtMotivo.Text + "\",\"C_Detalle\":\"" + TxtDetalle.Text + "\",\"D_FecQueja\":\"" + txtFecha.Text + "\"}"; //JSON
                //byte[] data = Encoding.UTF8.GetBytes(postdata);

                //HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:62070/QuejaService.svc/Quejas/Todos" + TxtDesde.Text + "," +TxtHasta.Text + "," + CboTipoQueja.SelectedValue);

                //req.Method = "GET";
                //req.ContentLength = data.Length;
                //req.ContentType = "application/json";

                //var reqStream = req.GetRequestStream();
                //reqStream.Write(data, 0, data.Length);

                //var res = (HttpWebResponse)req.GetResponse();
                //StreamReader reader = new StreamReader(res.GetResponseStream());
                //string alumnoJson = reader.ReadToEnd();

                //JavaScriptSerializer js = new JavaScriptSerializer();
                //Queja alumnoCreado = js.Deserialize<Queja>(alumnoJson);


                //String script = "document.getElementById('divacepto').style.display='block';";
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", script, true);




                string strURL = "http://localhost:62070/QuejaService.svc/Quejas/Todos/" + TxtDesde.Text + "," + TxtHasta.Text + "," + CboTipoQueja.SelectedValue;
                HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
                   .Create(strURL);
                reqObtener.Method = "GET";
                HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
                StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
                string QuejasObtener = readerObtener.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                IList<Queja> ListaQuejas = js.Deserialize<List<Queja>>(QuejasObtener);
                
                //ya que no me salio como cargarlo directamente a la grilla lo pase a otra lista
                List<QuejaConsulta> ObjQuejaConsulta = new List<QuejaConsulta>();

                foreach (Queja QUEJA in ListaQuejas)
                {
                    QuejaConsulta QUEJACON = new QuejaConsulta();
                    QUEJACON.N_IdQueja = QUEJA.N_IdQueja;
                    QUEJACON.N_IdResidente = QUEJA.N_IdResidente;
                    QUEJACON.C_Nombre = QUEJA.Residente.C_Nombre;
                    QUEJACON.B_Estado = QUEJA.B_Estado;
                    QUEJACON.C_Detalle = QUEJA.C_Detalle;
                    QUEJACON.C_Motivo = QUEJA.C_Motivo;
                    QUEJACON.C_NumDocume = QUEJA.Residente.C_NumDocume;
                    QUEJACON.C_Tipo = QUEJA.C_Tipo;
                    QUEJACON.D_FecQueja = QUEJA.D_FecQueja;
                    QUEJACON.D_FecRegistro = QUEJA.D_FecRegistro;
                    ObjQuejaConsulta.Add(QUEJACON);
                }
                
                GvQuejas.DataSource = ObjQuejaConsulta;
                GvQuejas.DataBind();

                if (ListaQuejas.Count == 0)
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

        protected void ChkAtendido_CheckedChanged(object sender, EventArgs e)
        {
            //cambiamos el estado del atendido
            CheckBox check;
            GridViewRow gvrow;

            check = (CheckBox)sender;
            gvrow = (GridViewRow)check.NamingContainer;

            int id;
            id = (int)GvQuejas.DataKeys[gvrow.RowIndex].Values["N_IdQueja"];

            string VALOR;
            if (check.Checked)
                VALOR = "true";
            else
                VALOR = "false";

            string strURL = "http://localhost:62070/QuejaService.svc/Quejas/" + id.ToString() +"," + VALOR;
            HttpWebRequest reqObtener = (HttpWebRequest)WebRequest
               .Create(strURL);
            reqObtener.Method = "UPDATE";
            HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
            StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());
            string QuejasObtener = readerObtener.ReadToEnd();
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //IList<Queja> ListaQuejas = js.Deserialize<List<Queja>>(QuejasObtener);
        }
    }
}