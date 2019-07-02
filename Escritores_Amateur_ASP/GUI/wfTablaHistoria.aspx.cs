using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaHistoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void DoOpen()
        {
            BO.Historia oHistoria = new BO.Historia();
            Servicios.HistoriaCtrl oHistoriaCtrl = new Servicios.HistoriaCtrl();
            DataTable dt = oHistoriaCtrl.devuelveObj(oHistoria);

            gvHistoria.DataSource = dt;
            gvHistoria.DataBind();
        }

        protected void lbtnBuscar_Click(object sender, EventArgs e)
        {
            DoOpen();
        }
    }
}