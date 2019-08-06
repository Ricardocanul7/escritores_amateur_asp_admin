using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfNuevoCapitulo : System.Web.UI.Page
    {
        int id_historia;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetID_Story();
                CargarInfo();
            }
        }

        public void SetID_Story()
        {
            id_historia = Convert.ToInt32(Session["id_historia"]);
        }

        // en caso de abrir este form para editar un capitulo hecho
        public void CargarInfo()
        {
            if(Session["operacion_historia"].ToString() == "editar")
            {
                DAO.Capitulo capituloDAO = new DAO.Capitulo();
                BO.Capitulo capituloBO = new BO.Capitulo();

                capituloBO.Id_capitulo = Convert.ToInt32(Session["id_capitulo"]);

                DataTable dt_capitulos = capituloDAO.devuelveDatos(capituloBO);

                txtTitulo.Text = dt_capitulos.Rows[0]["titulo"].ToString();
                txtContenido.Text = dt_capitulos.Rows[0]["contenido"].ToString();
            }
            if(Session["operacion_historia"].ToString() == "nuevo")
            {

            }
        }
    }
}