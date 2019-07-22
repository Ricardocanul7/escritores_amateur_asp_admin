using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.MasterPage
{
    public partial class mpPrincipal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfRegistro.aspx");
        }

        protected void lbtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wpLandingPage.aspx");
        }
    }
}