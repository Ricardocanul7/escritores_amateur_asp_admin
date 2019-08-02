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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
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

            //--FALTO

            //lblTitulo.Text = dr[0]["titulo"].ToString();
            //imgPortada.ImageUrl = dr[0]["portada_url"].ToString();
        }

        public DataTable recuperarHistorias()
        {
            DAO.Historia historia = new Historia();
            return historia.recuperaHistoria();
        }
    }
}