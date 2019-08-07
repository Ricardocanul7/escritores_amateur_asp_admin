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
            DoOpen();
        }

        public void DoOpen()
        {
            BO.Mensaje oMensaje = new BO.Mensaje();
            Servicios.MensajeCtrl oMensajeCtrl = new Servicios.MensajeCtrl();
            //el .length sirve para que cuente cuantos caracteres hay.
            if (txtFecha.Text.Trim().Length != 0)
            {
                oMensaje.Fecha = Convert.ToDateTime(txtFecha.Text.Trim());
            }
            if (txtCreador.Text.Trim().Length != 0)
            {
                oMensaje.Id_usuario = Convert.ToInt32(txtCreador.Text.Trim());
            }
            if (txtConversacion.Text.Trim().Length != 0)
            {
                oMensaje.Id_conversacion = Convert.ToInt32(txtConversacion.Text.Trim());
            }
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