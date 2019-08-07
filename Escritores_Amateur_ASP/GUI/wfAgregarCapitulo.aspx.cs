using System;
using System.Collections.Generic;
using System.Data;
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
            if (!IsPostBack)
            {
                if (Session["id_historia"] != null)
                {
                    id_historia = Convert.ToInt32(Session["id_historia"]);
                    lblHeaderTitulo_Libro.Text = ObtenerInfoHistoria()["titulo"].ToString();
                    CargarInfo();
                }
            }
        }

        public void CargarInfo()
        {
            DAO.Capitulo capituloDAO = new DAO.Capitulo();
            BO.Capitulo capituloBO = new BO.Capitulo();

            capituloBO.Id_historia = id_historia;

            dlistCapitulos.DataSource = capituloDAO.devuelveDatos(capituloBO);
            dlistCapitulos.DataBind();
        }

        public DataRow ObtenerInfoHistoria()
        {
            DAO.Historia historiaDAO = new DAO.Historia();
            BO.Historia historiaBO = new BO.Historia();

            DataRow[] dr_historia = historiaDAO.devuelveDatos(historiaBO).Select(String.Format("id_historia={0}", id_historia));
            return dr_historia[0];
        }

        protected void btnAgregarCap_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfNuevoCapitulo.aspx", false);
        }

        protected void dlistCapitulos_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName == "editar_capitulo")
            {
                Session["id_capitulo"] = e.CommandArgument.ToString();
                //Session["id_historia"] = id_historia;
                Session["operacion_historia"] = "editar";
                Response.Redirect("../GUI/wfNuevoCapitulo.aspx", false);
            }
        }
    }
}