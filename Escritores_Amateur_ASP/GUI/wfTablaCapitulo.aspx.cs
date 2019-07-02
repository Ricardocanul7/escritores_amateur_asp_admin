using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaCapitulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void DoOpen()
        {
            BO.Capitulo oCapitulo = new BO.Capitulo();
            Servicios.CapituloCtrl oCapituloCtrl = new Servicios.CapituloCtrl();
            DataTable dt = oCapituloCtrl.devuelveObj(oCapitulo);

            gvCapitulo.DataSource = dt;
            gvCapitulo.DataBind();
        }

        protected void lbtnBuscar_Click(object sender, EventArgs e)
        {
            DoOpen();
        }
    }
}