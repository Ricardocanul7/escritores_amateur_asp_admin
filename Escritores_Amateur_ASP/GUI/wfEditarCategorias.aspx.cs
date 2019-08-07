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
    public partial class wfEditarCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaOperacion();
            }
        }
        public void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
        }
        public void cargaOperacion()
        {
            lblId.Visible = false;
            txtId.Visible = false;
            if ((String)Session["frmCategoriaOperacion"] == "Editar")
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
            BO.Categoria obj = (BO.Categoria)Session["frmCategoriaBO"];
            Servicios.CategoriaCtrl objCtrl = new Servicios.CategoriaCtrl();
            DataTable dt = objCtrl.devuelveObj(obj);
            if (dt.Rows.Count != 0)
            {
                txtId.Text = dt.Rows[0]["id_categoria"].ToString();
                txtNombre.Text = dt.Rows[0]["nombre_cat"].ToString();
            }
        }
        public void agregar()
        {
            string mensaje = "";
            if (txtNombre.Text == string.Empty)
            {
                mensaje += "Introduce el nombre\n";
            }

            if (mensaje.Trim().Length == 0)
            {
                BO.Categoria obj = new BO.Categoria();
                Servicios.CategoriaCtrl objCtrl = new Servicios.CategoriaCtrl();
                obj.Nombre_cat = txtNombre.Text;
                string msn = objCtrl.creaCategoria(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaCategoria.aspx");

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
            if (txtId.Text == string.Empty)
            {
                mensaje = mensaje + "Introduce la Clave \n";
            }
            if (txtNombre.Text == string.Empty)
            {
                mensaje = mensaje + "Introduce el nombre\n";
            }

            if (mensaje.Trim().Length == 0)
            {
                BO.Categoria obj = new BO.Categoria();
                Servicios.CategoriaCtrl objCtrl = new Servicios.CategoriaCtrl();
                obj.Id_categoria = Convert.ToInt32(txtId.Text);
                obj.Nombre_cat = txtNombre.Text;
                string msn = objCtrl.actualizaObj(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaCategoria.aspx");

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
            BO.Categoria obj = (BO.Categoria)Session["frmCategoriaBO"];
            Servicios.CategoriaCtrl objCtrl = new Servicios.CategoriaCtrl();
            obj.Id_categoria = Convert.ToInt32(txtId.Text.Trim());
            string mensaje = objCtrl.eliminaObj(obj);
            if (mensaje == "La operación se realizó de manera correcta")
            {
                Response.Redirect("wfTablaCategoria.aspx");

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

        protected void lbtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfTablaCategoria.aspx");
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
    }
}