using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Escritores_Amateur_ASP.DAO;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfHistoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["id"] != null)
            {
                int id_historia = Convert.ToInt32(Request.QueryString["id"].ToString());
                cargarInfo(id_historia);
            }
        }

        public void cargarInfo(int id_historia)
        {
            // -- CARGA INFO DE AUTOR Y TITULO PROLOGO SINOPSIS
            DataTable dt = recuperarHistorias();
            DataRow[] dr = dt.Select("id_historia=" + id_historia);


            lblTitulo.Text = dr[0]["titulo"].ToString();
            lblAutor.Text = dr[0]["autor"].ToString();
            lblSinopsis.Text = dr[0]["sinopsis"].ToString();
            lblPrologo.Text = dr[0]["prologo"].ToString();
            imgPortada.ImageUrl = dr[0]["portada_url"].ToString();

            // CARGA CAPITULOS DE LA HISTORIA
            DataTable dt_capitulos = recuperarCapitulos();
            DataRow[] dr_capitulos = dt_capitulos.Select("id_historia=" + id_historia);

            DataTable dt_capitulosCopy = dr_capitulos.CopyToDataTable();

            dlistCapitulos.DataSource = dt_capitulosCopy;
            dlistCapitulos.DataBind();
        }

        public DataTable recuperarHistorias()
        {
            DAO.Historia historia = new Historia();
            return historia.recuperaHistoria();
        }

        public DataTable recuperarCapitulos()
        {
            DAO.Capitulo capituloDAO = new DAO.Capitulo();
            BO.Capitulo capituloBO = new BO.Capitulo();

            return capituloDAO.devuelveDatos(capituloBO);
        }
    }
}