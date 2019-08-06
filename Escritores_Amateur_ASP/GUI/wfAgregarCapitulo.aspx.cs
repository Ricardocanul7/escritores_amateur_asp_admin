using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfAgregarCapitulo : System.Web.UI.Page
    {
        int id_historia;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["id_historia"] != null && Session["agregarCapitulo"].ToString() == "true")
            {
                id_historia = Convert.ToInt32(Session["id_historia"]);
            }
        }

        protected void btnAgregarCap_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfNuevoCapitulo.aspx");
        }
    }
}