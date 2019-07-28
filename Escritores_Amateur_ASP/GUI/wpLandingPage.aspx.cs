using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wpLandingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dlistHistoriasRecientes.DataSource = LastStories();
            dlistHistoriasRecientes.DataBind();

            if (Session["access"] != null)
                circulos_principal.Visible = true;
            else
                circulos_principal.Visible = false;
        }

        public DataTable LastStories()
        {
            DataTable dt = new DAO.Historia().getPreviewLastStories();
            return dt;
        }

        protected void dlistHistoriasRecientes_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName == "ver_historia")
            {
                Response.Redirect("../GUI/wfHistoria.aspx?id=" + e.CommandArgument.ToString());
            }
            
        }
    }
}