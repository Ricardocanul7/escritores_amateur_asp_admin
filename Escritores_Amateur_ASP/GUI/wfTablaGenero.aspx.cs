using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaGenero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void DoOpen()
        {
            BO.Genero oGenero = new BO.Genero();
            Servicios.GeneroCtrl oGeneroCtrl = new Servicios.GeneroCtrl();
            DataTable dt = oGeneroCtrl.devuelveObj(oGenero);

            gvGenero.DataSource = dt;
            gvGenero.DataBind();
        }

        protected void lbtnBuscar_Click(object sender, EventArgs e)
        {
            DoOpen();
        }

        protected void lbtnAgregar_Click(object sender, EventArgs e)
        {
            Session["frmGeneroOperacion"] = "Nuevo";
            Response.Redirect("wfEditarGenero.aspx");
        }

        protected void gvGenero_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = (int)gvGenero.DataKeys[indice].Value;
                BO.Genero obj = new BO.Genero();
                obj.Id_genero = id;
                Session["frmGeneroOperacion"] = "Editar";
                Session["frmGeneroBO"] = obj;
                Response.Redirect("wfEditarGenero.aspx");
            }
        }
    }
}