using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaMensaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void DoOpen()
        {
            BO.Mensaje oMensaje = new BO.Mensaje();
            Servicios.MensajeCtrl oMensajeCtrl = new Servicios.MensajeCtrl();
            DataTable dt = oMensajeCtrl.devuelveObj(oMensaje);

            gvMensaje.DataSource = dt;
            gvMensaje.DataBind();
        }

        protected void lbtnBuscar_Click(object sender, EventArgs e)
        {
            DoOpen();
        }
    }
}