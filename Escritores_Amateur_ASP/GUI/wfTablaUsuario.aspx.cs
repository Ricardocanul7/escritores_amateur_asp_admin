using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaUsuario : System.Web.UI.Page
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
            BO.Usuario oUsuario = new BO.Usuario();
            Servicios.UsuarioCtrl oUsuarioCtrl = new Servicios.UsuarioCtrl();
            DataTable dt = oUsuarioCtrl.devuelveObj(oUsuario);

            gvUsuarios.DataSource = dt;
            gvUsuarios.DataBind();
        }

        protected void gvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = (int)gvUsuarios.DataKeys[indice].Value;
                BO.Usuario obj = new BO.Usuario();
                obj.Id_usuario = id;
                Session["frmUsurioOperación"] = "Editar";
                Session["frmUsuarioBO"] = obj;
                Response.Redirect("wfFlorEditar.aspx");
            }
        }
    }
}