using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfTablaRevisiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DoOpen();
        }

        public void DoOpen()
        {
            BO.Revision oRevision = new BO.Revision();
            DAO.Revision oRevisionDAO = new DAO.Revision();
            DataTable dt = oRevisionDAO.devuelveDatos(oRevision);

            gvRevisiones.DataSource = dt;
            gvRevisiones.DataBind();
        }

        protected void lbtnAgregar_Click(object sender, EventArgs e)
        {
            Session["frmRevisionOperacion"] = "Nuevo";
            Response.Redirect("wfEditarRevision.aspx");
        }

        protected void gvRevisiones_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = (int)gvRevisiones.DataKeys[indice].Value;
                //BO.Categoria obj = new BO.Categoria();
                //obj.Id_categoria = id;
                BO.Revision obj = new BO.Revision();
                obj.Id_historia = id;   

                Session["frmRevisionOperacion"] = "Editar";
                Session["frmRevisionBO"] = obj;
                Response.Redirect("wfEditarRevision.aspx");
            }
        }

        protected void lbtnBuscar_Click(object sender, EventArgs e)
        {
            DoOpen();
        }
    }
}