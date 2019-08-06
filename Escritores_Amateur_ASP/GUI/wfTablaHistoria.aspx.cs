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

        protected void gvHistoria_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = (int)gvHistoria.DataKeys[indice].Value;
                BO.Historia obj = new BO.Historia();
                obj.Id_historia = id;
                Session["frmHistoriaOperacion"] = "Editar";
                Session["frmHistoriaBO"] = obj;
                Response.Redirect("wfEditarHistoria.aspx");
            }
        }

        protected void lbtnAgregar_Click(object sender, EventArgs e)
        {
            Session["frmHistoriaOperacion"] = "Nuevo";
            Response.Redirect("wfEditarHistoria.aspx");
        }
    }
}