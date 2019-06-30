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
    }
}