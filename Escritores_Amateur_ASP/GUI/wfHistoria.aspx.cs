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
            //cargarInfo();
        }

        public void cargarInfo()
        {
            
            DataTable dt = recuperarHistorias();
            DataRow[] dr = dt.Select("id_historia=3");


            lblTitulo.Text = dr[0]["titulo"].ToString();
            lblAutor.Text = "Alan";
            lblSinopsis.Text = "Erase una vez";
            lblPrologo.Text = "Por enfermo pasó que...";
            imgPortada.ImageUrl = "https://a.wattpad.com/cover/114145992-352-k32105.jpg";
        }

        public DataTable recuperarHistorias()
        {
            DAO.Historia historia = new Historia();
            return historia.recuperaHistoria();
        }
    }
}