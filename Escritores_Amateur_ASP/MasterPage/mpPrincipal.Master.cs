using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.MasterPage
{
    public partial class mpPrincipal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validarLogin();
        }

        public void validarLogin()
        {
            bool access = false;

            DAO.Usuario usuarioDAO = new DAO.Usuario();
            BO.Usuario usuarioBO = new BO.Usuario();

            if (Session["username"] != null && Session["password"] != null)
            {
                //usuarioBO.Username = Session["username"].ToString();
                //usuarioBO.Contrasenia = Session["password"].ToString();

                string username = Session["username"].ToString();
                string password = Session["password"].ToString();

                DataTable dt = usuarioDAO.devuelveDatos(usuarioBO);
                if (dt.Rows.Count > 0)
                {
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["username"].ToString() == username && dt.Rows[i]["contrasenia"].ToString() == password)
                        {
                            access = true;
                            break;
                        }
                            
                    }
                }
                else
                {
                    access = false;
                }
            }

            if (access == true)
            {
                lbtnLogin.Visible = false;
                lbtnSignUp.Visible = false;
                userDropDown.Visible = true;
            }
            else
            {
                lbtnLogin.Visible = true;
                lbtnSignUp.Visible = true;
                userDropDown.Visible = false;
            }
        }

        protected void lbtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfRegistro.aspx");
        }

        protected void lbtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wpLandingPage.aspx");
        }

        protected void lbtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfLogin.aspx");
        }
    }
}