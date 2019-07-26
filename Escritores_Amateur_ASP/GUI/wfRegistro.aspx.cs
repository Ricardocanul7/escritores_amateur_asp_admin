using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarListBoxes();
        }

        public void llenarListBoxes()
        {
            // PENDIENTE
        }

        protected void lbtnLoginRegitro1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfLogin.aspx");
        }

        protected void lbtnRegistro_Click(object sender, EventArgs e)
        {
            BO.Usuario usuarioBO = new BO.Usuario();

            usuarioBO.Nombre = input_nombre.Value;
            usuarioBO.Apellido_pat = input_apellido_pat.Value;
            usuarioBO.Apellido_mat = input_apellido_mat.Value;
            usuarioBO.Correo = input_correo.Value;
            usuarioBO.Telefono = input_telefono.Value;
            //SEXO NO TIENE ATRIBUTOS
            usuarioBO.Municipio = input_ciudad.SelectedValue;
            usuarioBO.Username = input_username.Value;
            usuarioBO.Contrasenia = input_username.Value;
            usuarioBO.Tipo_usuario = 1; //Escritor

            DAO.Usuario usuarioDAO = new DAO.Usuario();

            if(usuarioDAO.creaUsuario(usuarioBO) == 0)
            {
                form_registro.Visible = false;
                alerta_exito.Visible = true;
            }
            else
            {
                alerta_fallo.Visible = true;
            }
            
        }
    }
}