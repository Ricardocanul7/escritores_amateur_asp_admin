using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.MasterPage
{
    public partial class mpAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtTableUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfTablaUsuario.aspx");
        }

        protected void lbtTablaCategorias_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfTablaCategoria.aspx");
        }

        protected void lbtnTablaGenero_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfTablaGenero.aspx");
        }

        protected void lbtnTablaSinopsis_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfTablaSinopsis.aspx");
        }

        protected void lbtnTablaMensaje_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfTablaMensaje.aspx");
        }
    }
}