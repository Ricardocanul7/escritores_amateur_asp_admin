using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Escritores_Amateur_ASP.BO;
using Escritores_Amateur_ASP.Servicios;
using System.Data;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaCapitulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DoOpen();
        }
        protected void lbtnBuscar_Click(object sender, EventArgs e)
        {
            DoOpen();
        }
        public void DoOpen()
        {
            BO.Capitulo oCapitulo = new BO.Capitulo();
            Servicios.CapituloCtrl oCapituloCtrl = new Servicios.CapituloCtrl();
            //el .length sirve para que cuente cuantos caracteres hay.
            if (txtTitulo.Text.Trim().Length != 0)
            {
                oCapitulo.Titulo = txtTitulo.Text.Trim();
            }
            DataTable dt = oCapituloCtrl.devuelveObj(oCapitulo);

            gvCapitulo.DataSource = dt;
            gvCapitulo.DataBind();
        }

        protected void gvCapitulo_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Editar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = (int)gvCapitulo.DataKeys[indice].Value;
                BO.Capitulo obj = new BO.Capitulo();
                obj.Id_capitulo = id;
                Session["frmCapituloOperacion"] = "Editar";
                Session["frmCapituloBO"] = obj;
                Response.Redirect("wfEditarCapitulo.aspx");
            }
        }

        protected void lbtnAgregar_Click(object sender, EventArgs e)
        {
            Session["frmCapituloOperacion"] = "Nuevo";
            Response.Redirect("wfEditarCapitulo.aspx");
        }
    }
}