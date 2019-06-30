using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaSinopsis : System.Web.UI.Page
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
            BO.Sinopsis oSinopsis = new BO.Sinopsis();
            Servicios.SinopsisCtrl oSinopsisCtrl = new Servicios.SinopsisCtrl();
            DataTable dt = oSinopsisCtrl.devuelveObj(oSinopsis);

            gvSinopsis.DataSource = dt;
            gvSinopsis.DataBind();
        }
    }
}