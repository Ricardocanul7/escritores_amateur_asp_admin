using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnBuscar_Click(object sender, EventArgs e)
        {
            DoOpen();
        }

        public void DoOpen()
        {
            BO.Categoria oCategoria = new BO.Categoria();
            Servicios.CategoriaCtrl oCategoriaCtrl = new Servicios.CategoriaCtrl();
            DataTable dt = oCategoriaCtrl.devuelveObj(oCategoria);

            gvCategorias.DataSource = dt;
            gvCategorias.DataBind();
        }
    }
}