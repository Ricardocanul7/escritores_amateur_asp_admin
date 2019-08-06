using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaCategoria : System.Web.UI.Page
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
            BO.Categoria oCategoria = new BO.Categoria();
            Servicios.CategoriaCtrl oCategoriaCtrl = new Servicios.CategoriaCtrl();
            DataTable dt = oCategoriaCtrl.devuelveObj(oCategoria);

            gvCategorias.DataSource = dt;
            gvCategorias.DataBind();
        }

        protected void gvCategorias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = (int)gvCategorias.DataKeys[indice].Value;
                BO.Categoria obj = new BO.Categoria();
                obj.Id_categoria = id;
                Session["frmCategoriaOperacion"] = "Editar";
                Session["frmCategoriaBO"] = obj;
                Response.Redirect("wfEditarCategorias.aspx");
            }
        }

        protected void lbtnAgregar_Click(object sender, EventArgs e)
        {
            Session["frmCategoriaOperacion"] = "Nuevo";
            Response.Redirect("wfEditarCategorias.aspx");
        }
    }
}