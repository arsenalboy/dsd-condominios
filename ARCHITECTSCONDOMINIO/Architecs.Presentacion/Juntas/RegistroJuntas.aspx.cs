using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Architecs.Presentacion.Dominio;

namespace Architecs.Presentacion.Juntas
{
    public partial class RegistroJuntas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Directivo> listdirectivo = new List<Directivo>();
            //Directivo objdirectivo = new Directivo();
            //listdirectivo.Add(objdirectivo);
            GvDirectivos.DataSource = listdirectivo;
            GvDirectivos.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            List<Directivo> listdirectivo = new List<Directivo>();
            GvBusca.DataSource = listdirectivo;
            GvBusca.DataBind();
            MpDirectores.Show();
        }

        protected void TraerDirectores()
        {
            List<Directivo> listdirectivo = new List<Directivo>();
            //Directivo objdirectivo = new Directivo();
            //listdirectivo.Add(objdirectivo);
            GvDirectivos.DataSource = listdirectivo;
            GvDirectivos.DataBind();
        }
    }
}