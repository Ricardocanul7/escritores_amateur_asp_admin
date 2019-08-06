using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfEditarUsuario : System.Web.UI.Page
    {
        DAO.Usuario usuario = new DAO.Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaOperacion();
                llenarListBoxes();
            }
        }
        public void llenarListBoxes()
        {
            llenar_tipoUsuario();
        }
        public void llenar_tipoUsuario()
        {
            input_tipoUser.Items.Clear();
            DataRow[] dr_tipoUser = usuario.GetTipoUsuario().Select();

            foreach (var row in dr_tipoUser)
            {
                ListItem listItem = new ListItem();
                listItem.Text = row["nombre_tipo"].ToString();
                listItem.Value = row["id_tipo_usuario"].ToString();
                input_tipoUser.Items.Add(listItem);
            }
        }
        public void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellidoMat.Text = "";
            txtApellidoPat.Text = "";
            txtAvatar.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtMunicipio.Text = "";
            txtSitioWeb.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtBiografia.Text = "";
        }
        public void cargaOperacion()
        {
            lblId.Visible = false;
            txtId.Visible = false;
            if ((String)Session["frmUsuarioOperacion"] == "Editar")
            {
                limpiar();
                buscar();
                lbtnAgregar.Visible = false;
            }
            else
            {
                limpiar();
                lbtnEliminar.Visible = false;
                lbtnModificar.Visible = false;
            }
        }
        public void buscar()
        {
            BO.Usuario obj = (BO.Usuario)Session["frmUsuarioBO"];
            Servicios.UsuarioCtrl objCtrl = new Servicios.UsuarioCtrl();
            DataTable dt = objCtrl.devuelveObj(obj);
            if (dt.Rows.Count != 0)
            {
                txtId.Text = dt.Rows[0]["id_usuario"].ToString();
                txtNombre.Text = dt.Rows[0]["nombre"].ToString();
                txtApellidoMat.Text = dt.Rows[0]["apellido_mat"].ToString();
                txtApellidoPat.Text = dt.Rows[0]["apellido_pat"].ToString();
                txtAvatar.Text = dt.Rows[0]["avatar"].ToString();
                txtCorreo.Text = dt.Rows[0]["correo"].ToString();
                txtTelefono.Text = dt.Rows[0]["municipio"].ToString();
                txtMunicipio.Text = dt.Rows[0]["telefono"].ToString();
                txtSitioWeb.Text = dt.Rows[0]["sitio_web"].ToString();
                txtUsername.Text = dt.Rows[0]["username"].ToString();
                input_tipoUser.Text = dt.Rows[0]["tipo_usuario"].ToString();
                txtPassword.Text = dt.Rows[0]["contrasenia"].ToString();
                txtBiografia.Text = dt.Rows[0]["biografia"].ToString();
            }
        }
        public void agregar()
        {
            string mensaje = "";
            if (txtNombre.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el nombre\n";
            }
            if (txtApellidoMat.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el apellido materno \n";
            }
            if (txtApellidoPat.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el apellido paterno \n";
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Correo \n";
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el telefono \n";
            }
            if (txtMunicipio.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el municipio \n";
            }
            if (txtSitioWeb.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el sitio web \n";
            }
            if (txtUsername.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Username \n";
            }
            if (input_tipoUser.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el tipo de usuario \n";
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la contraseña \n";
            }
            if (txtBiografia.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la biografia \n";
            }


            if (mensaje.Trim().Length == 0)
            {
                BO.Usuario obj = new BO.Usuario();
                Servicios.UsuarioCtrl objCtrl = new Servicios.UsuarioCtrl();
                obj.Nombre = txtNombre.Text.Trim();
                obj.Avatar = txtAvatar.Text.Trim().ToUpper();
                obj.Apellido_pat = txtApellidoPat.Text.Trim().ToUpper();
                obj.Apellido_mat = txtApellidoMat.Text.Trim().ToUpper();
                obj.Correo = txtCorreo.Text.Trim().ToUpper();
                obj.Telefono = txtTelefono.Text.Trim().ToUpper();
                obj.Municipio = txtMunicipio.Text.Trim().ToUpper();
                obj.Sitio_web = txtSitioWeb.Text.Trim().ToUpper();
                obj.Username = txtUsername.Text.Trim().ToUpper();
                obj.Tipo_usuario = Convert.ToInt32(input_tipoUser.Text.Trim().ToUpper());
                obj.Contrasenia = txtPassword.Text.Trim().ToUpper();
                obj.Biografia = txtBiografia.Text.Trim().ToUpper();
                string msn = objCtrl.creaUsuario(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaUsuario.aspx");

                }
                else
                {
                    Mensaje(msn);
                }
            }
            else
            {
                Mensaje("Favor de ingresar los siguientes datos:\n" + mensaje);
            }
        }
        public void modificar()
        {
            string mensaje = "";
            if (txtId.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la Clave \n";
            }
            if (txtNombre.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el nombre\n";
            }
            if (txtApellidoPat.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el apellido paterno \n";
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Correo \n";
            }
            if (txtMunicipio.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el municipio \n";
            }
            if (txtUsername.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Username \n";
            }
            if (input_tipoUser.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el tipo de usuario \n";
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la contraseña \n";
            }


            if (mensaje.Trim().Length == 0)
            {
                BO.Usuario obj = new BO.Usuario();
                Servicios.UsuarioCtrl objCtrl = new Servicios.UsuarioCtrl();
                obj.Id_usuario = Convert.ToInt32(txtId.Text.Trim().ToUpper());
                obj.Nombre = txtNombre.Text.Trim().ToUpper();
                obj.Avatar = txtAvatar.Text.Trim().ToUpper();
                obj.Apellido_pat = txtApellidoPat.Text.Trim().ToUpper();
                obj.Apellido_mat = txtApellidoMat.Text.Trim().ToUpper();
                obj.Correo = txtCorreo.Text.Trim().ToUpper();
                obj.Telefono = txtTelefono.Text.Trim().ToUpper();
                obj.Municipio= txtMunicipio.Text.Trim().ToUpper();
                obj.Sitio_web = txtSitioWeb.Text.Trim().ToUpper();
                obj.Username = txtUsername.Text.Trim().ToUpper();
                obj.Tipo_usuario = Convert.ToInt32(input_tipoUser.Text.Trim().ToUpper());
                obj.Contrasenia = txtPassword.Text.Trim().ToUpper();
                obj.Biografia = txtBiografia.Text.Trim().ToUpper();
                string msn = objCtrl.actualizaObj(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaUsuario.aspx");

                }
                else
                {
                    Mensaje(msn);
                }
            }
            else
            {
                Mensaje("Favor de ingresar los siguientes datos:\n" + mensaje);
            }
        }
        public void eliminar()
        {
            BO.Usuario obj = (BO.Usuario)Session["frmUsuarioBO"];
            Servicios.UsuarioCtrl objCtrl = new Servicios.UsuarioCtrl();
            obj.Id_usuario = Convert.ToInt32(txtId.Text.Trim());
            string mensaje = objCtrl.eliminaObj(obj);
            if (mensaje == "La operación se realizó de manera correcta")
            {
                Response.Redirect("wfTablaUsuario.aspx");

            }
            else
            {
                Mensaje(mensaje);
            }

        }

        private void Mensaje(string ex)
        {
            string mensaje = ex;
            mensaje = mensaje.Replace(Environment.NewLine, "\\n");
            mensaje = mensaje.Replace("\n", "\\n");
            mensaje = mensaje.Replace("'", "\"");
            ClientScript.RegisterClientScriptBlock(typeof(Page), "Error", "<script> alert('" + mensaje + "');</script>");
        }

        protected void lbtnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        protected void lbtnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        protected void lbtnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        protected void lbtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfTablaUsuario.aspx");
        }
    }
}