using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alerta_error_login.Visible = false;
        }

        public void validarLogin()
        {
            bool access = false;

            DAO.Usuario usuarioDAO = new DAO.Usuario();
            BO.Usuario usuarioBO = new BO.Usuario();

            if (Session["username"] != null && Session["password"] != null)
            {
                string username = Session["username"].ToString();
                string password = Session["password"].ToString();

                DataTable dt = usuarioDAO.devuelveDatos(usuarioBO);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
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
                Session["access"] = true;
                Response.Redirect("../GUI/wpLandingPage.aspx");
            }
            else
            {
                Session["access"] = null;
                alerta_error_login.Visible = true;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = input_username.Value;
            string password = input_password.Value;

            Session["username"] = username;
            Session["password"] = password;

            validarLogin();
        }
    }
}