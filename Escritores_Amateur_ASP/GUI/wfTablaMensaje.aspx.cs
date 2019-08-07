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

        protected void gvMensaje_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = (int)gvMensaje.DataKeys[indice].Value;
                BO.Mensaje obj = new BO.Mensaje();
                obj.Id_mensaje = id;
                Session["frmMensajeOperacion"] = "Editar";
                Session["frmMensajeBO"] = obj;
                Response.Redirect("wfEditarMensaje.aspx");
            }
        }

        protected void lbtnAgregar_Click(object sender, EventArgs e)
        {
            Session["frmMensajeOperacion"] = "Nuevo";
            Response.Redirect("wfEditarMensaje.aspx");
        }
    }
}