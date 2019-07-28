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
            DataTable data = LastStories();

            dlistHistoriasRecientes.DataSource = data;
            dlistHistoriasRecientes.DataBind();
        }

        public DataTable LastStories()
        {
            DataTable dt = new DAO.Historia().getPreviewLastStories();
            return dt;
        }

        protected void dlistHistoriasRecientes_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int id_historias = (int)dlistHistoriasRecientes.DataKeys[index];

            Session["id_historia"] = id_historias;
            Response.Redirect("../GUI/wfHistoria.aspx");
        }

        protected void click_historia_Command(object sender, CommandEventArgs e)
        {

        }
    }
}