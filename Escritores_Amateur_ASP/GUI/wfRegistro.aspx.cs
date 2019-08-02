using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfRegistro : System.Web.UI.Page
    {
        DAO.Localizacion localizacion = new DAO.Localizacion();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarListBoxes();
            }
        }

        public void llenarListBoxes()
        {
            llenar_pais();
        }

        public void llenar_pais()
        {
            input_pais.Items.Clear();
            DataRow[] dr_paises = localizacion.GetPaises().Select();

            foreach (var row in dr_paises)
            {
                ListItem listItem = new ListItem();
                listItem.Text = row["nombre"].ToString();
                listItem.Value = row["id_pais"].ToString();
                input_pais.Items.Add(listItem);
            }
        }

        public void llenar_estado(string id_pais)
        {
            if(input_pais.SelectedIndex < 0)
            {
                input_estado.Enabled = false;
            }
            input_estado.Items.Clear();
            DataRow[] dr_estados;

            if(id_pais == null)
                dr_estados = localizacion.GetEstados().Select();
            else
                dr_estados = localizacion.GetEstados().Select("id_pais=" + id_pais);

            foreach (var row in dr_estados)
            {
                ListItem listItem = new ListItem();
                listItem.Text = row["nombre"].ToString();
                listItem.Value = row["id_estado"].ToString();
                input_estado.Items.Add(listItem);
            }
        }

        public void llenar_ciudad(string id_estado)
        {
            input_ciudad.Items.Clear();
            DataRow[] dr_ciudades;
            if (id_estado == null)
                dr_ciudades = localizacion.GetCiudades().Select();
            else
                dr_ciudades = localizacion.GetCiudades().Select("id_estado=" + id_estado);


            foreach (var row in dr_ciudades)
            {
                ListItem listItem = new ListItem();
                listItem.Text = row["nombre"].ToString();
                listItem.Value = row["id_ciudad"].ToString();
                input_ciudad.Items.Add(listItem);
            }
        }

        protected void lbtnLoginRegitro1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfLogin.aspx");
        }

        protected void lbtnRegistro_Click(object sender, EventArgs e)
        {
            BO.Usuario usuarioBO = new BO.Usuario();

            usuarioBO.Nombre = input_nombre.Text;
            usuarioBO.Apellido_pat = input_apellido_pat.Text;
            usuarioBO.Apellido_mat = input_apellido_mat.Text;
            usuarioBO.Correo = input_correo.Text;
            usuarioBO.Telefono = input_telefono.Text;
            //SEXO NO TIENE ATRIBUTOS
            usuarioBO.Municipio = input_ciudad.Text;
            usuarioBO.Username = input_username.Text;
            usuarioBO.Contrasenia = input_username.Text;
            usuarioBO.Tipo_usuario = 1; //Escritor

            DAO.Usuario usuarioDAO = new DAO.Usuario();

            if(usuarioDAO.creaUsuario(usuarioBO) == 0)
            {
                form_registro.Visible = false;
                alerta_exito.Visible = true;
                alerta_fallo.Visible = false;
            }
            else
            {
                alerta_exito.Visible = false;
                alerta_fallo.Visible = true;
            }
            
        }

        protected void input_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_pais = input_pais.SelectedValue;
            llenar_estado(id_pais);
        }

        protected void input_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_estado = input_estado.SelectedValue;
            llenar_ciudad(id_estado);
        }
    }
}