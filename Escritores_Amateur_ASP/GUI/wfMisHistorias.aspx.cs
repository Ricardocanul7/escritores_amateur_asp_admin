using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Escritores_Amateur_ASP.DAO;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfMisHistorias : System.Web.UI.Page
    {
        string id_autor_temp = "13";
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarInfo();
        }
        public void cargarInfo()
        {
            DAO.Historia historiaDAO = new DAO.Historia();
            DataTable dt_misHistorias = historiaDAO.GetStoriesByAuthor(id_autor_temp);

            dlistMisHistorias.DataSource = dt_misHistorias;
            dlistMisHistorias.DataBind();
        }

        public DataTable recuperarHistorias()
        {
            DAO.Historia historia = new Historia();
            return historia.recuperaHistoria();
        }

        protected void btnAgregarHistoria_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfAgregarHistoria.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfAgregarCapitulo.aspx");
        }
    }
}