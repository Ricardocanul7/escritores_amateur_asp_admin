using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Escritores_Amateur_ASP.Servicios;

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
            /*if (txt .Text.Trim().Length != 0)
            {
                oFlor.NombreComun = txtNombreComun.Text.Trim();
            }
            if (txtNombreCientifico.Text.Trim().Length != 0)
            {
                oFlor.NombreCientifico = txtNombreCientifico.Text.Trim();
            }
            if (txtFamilia.Text.Trim().Length != 0)
            {
                oFlor.Familia = txtFamilia.Text.Trim();
            }*/
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
                Session["frmUsuarioOperacion"] = "Editar";
                Session["frmUsuarioBO"] = obj;
                Response.Redirect("wfEditarUsuario.aspx");
            }
        }

        protected void lbtnAgregar_Click(object sender, EventArgs e)
        {
            Session["frmUsuarioOperacion"] = "Nuevo";
            Response.Redirect("wfEditarUsuario.aspx");
        }
    }
}