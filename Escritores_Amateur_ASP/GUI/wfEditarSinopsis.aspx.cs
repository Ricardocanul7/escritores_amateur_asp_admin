using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfEditarSinopsis : System.Web.UI.Page
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
            if ((String)Session["frmSinopsisOperacion"] == "Editar")
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
            BO.Sinopsis obj = (BO.Sinopsis)Session["frmSinopsisBO"];
            Servicios.SinopsisCtrl objCtrl = new Servicios.SinopsisCtrl();
            DataTable dt = objCtrl.devuelveObj(obj);
            if (dt.Rows.Count != 0)
            {
                txtId.Text = dt.Rows[0]["id_sinopsis"].ToString();
                txtNombre.Text = dt.Rows[0]["contenido"].ToString();
            }
        }
        public void agregar()
        {
            string mensaje = "";
            if (txtNombre.Text == string.Empty)
            {
                mensaje += "Introduce el contenido\n";
            }

            if (mensaje.Trim().Length == 0)
            {
                BO.Sinopsis obj = new BO.Sinopsis();
                Servicios.SinopsisCtrl objCtrl = new Servicios.SinopsisCtrl();
                obj.Contenido = txtNombre.Text;
                string msn = objCtrl.creaSinopsis(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaSinopsis.aspx");

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
                mensaje = mensaje + "Introduce el contenido\n";
            }

            if (mensaje.Trim().Length == 0)
            {
                BO.Sinopsis obj = new BO.Sinopsis();
                Servicios.SinopsisCtrl objCtrl = new Servicios.SinopsisCtrl();
                obj.Id_sinopsis = Convert.ToInt32(txtId.Text);
                obj.Contenido = txtNombre.Text;
                string msn = objCtrl.actualizaObj(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaSinopsis.aspx");

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
            BO.Sinopsis obj = (BO.Sinopsis)Session["frmSinopsisBO"];
            Servicios.SinopsisCtrl objCtrl = new Servicios.SinopsisCtrl();
            obj.Id_sinopsis = Convert.ToInt32(txtId.Text.Trim());
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
            Response.Redirect("wfTablaSinopsis.aspx");
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