using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Architects.Dominio;

public partial class prueba : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnAgregar_Click(object sender, EventArgs e)
    {
        List<Directivo> listdirectivo = new List<Directivo>();
        GvBusca.DataSource = listdirectivo;
        GvBusca.DataBind();
        MpDirectores.Show();
    }
}