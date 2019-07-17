using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaPrologo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void DoOpen()
        {
            BO.Prologo oPrologo = new BO.Prologo();
            Servicios.PrologoCtrl oPrologoCtrl = new Servicios.PrologoCtrl();
            DataTable dt = oPrologoCtrl.devuelveObj(oPrologo);

            gvPrologo.DataSource = dt;
            gvPrologo.DataBind();
        }

        protected void lbtnBuscar_Click(object sender, EventArgs e)
        {
            DoOpen();
        }
    }
}