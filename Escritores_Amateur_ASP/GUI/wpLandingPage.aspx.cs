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

            listViewHistoriasRecientes.DataSource = data;
            listViewHistoriasRecientes.DataBind();
        }

        public DataTable LastStories()
        {
            DataTable dt = new DAO.Historia().getPreviewLastStories();
            return dt;
        }

        protected void listViewHistoriasRecientes_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }
    }
}