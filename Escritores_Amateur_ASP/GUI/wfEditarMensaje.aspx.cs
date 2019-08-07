using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfEditarMensaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargaOperacion();
        }
        public void limpiar()
        {
            txtId.Text = "";
            txtTexto.Text = "";
            txtFecha.Text = "";
            txtEstado.Text = "";
            txtIDconversacion.Text = "";
            txtCreador.Text = "";
        }
        public void cargaOperacion()
        {
            lblId.Visible = false;
            txtId.Visible = false;
            if ((String)Session["frmMensajeOperacion"] == "Editar")
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
            BO.Mensaje obj = (BO.Mensaje)Session["frmMensajeBO"];
            Servicios.MensajeCtrl objCtrl = new Servicios.MensajeCtrl();
            DataTable dt = objCtrl.devuelveObj(obj);
            if (dt.Rows.Count != 0)
            {
                txtId.Text = dt.Rows[0]["id_mensaje"].ToString();
                txtTexto.Text = dt.Rows[0]["texto"].ToString();
                txtFecha.Text = dt.Rows[0]["fecha"].ToString();
                txtEstado.Text = dt.Rows[0]["estado"].ToString();
                txtIDconversacion.Text = dt.Rows[0]["id_conversacion"].ToString();
                txtCreador.Text = dt.Rows[0]["id_user_creador"].ToString();
            }
        }
        public void agregar()
        {
            string mensaje = "";
            if (txtTexto.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el texto\n";
            }
            if (txtFecha.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la fecha\n";
            }
            if (txtEstado.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el estado\n";
            }
            if (txtIDconversacion.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el id de la conversación \n";
            }
            if (txtCreador.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el creador \n";
            }


            if (mensaje.Trim().Length == 0)
            {
                BO.Mensaje obj = new BO.Mensaje();
                Servicios.MensajeCtrl objCtrl = new Servicios.MensajeCtrl();
                obj.Tecto = txtTexto.Text.Trim();
                obj.Fecha = Convert.ToDateTime(txtFecha.Text.Trim().ToUpper());
                obj.Estado = Convert.ToInt32(txtEstado.Text.Trim().ToUpper());
                obj.Id_conversacion = Convert.ToInt32(txtIDconversacion.Text.Trim().ToUpper());
                obj.Id_usuario = Convert.ToInt32(txtCreador.Text.Trim().ToUpper());
                string msn = objCtrl.creaMensaje(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaMensaje.aspx");

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
            if (txtTexto.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el texto\n";
            }
            if (txtFecha.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la fecha\n";
            }
            if (txtEstado.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el estado\n";
            }
            if (txtIDconversacion.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el id de la conversación \n";
            }
            if (txtCreador.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el creador \n";
            }


            if (mensaje.Trim().Length == 0)
            {
                BO.Mensaje obj = new BO.Mensaje();
                Servicios.MensajeCtrl objCtrl = new Servicios.MensajeCtrl();
                obj.Id_mensaje = Convert.ToInt32(txtId.Text.Trim().ToUpper());
                obj.Tecto = txtTexto.Text.Trim();
                obj.Fecha = Convert.ToDateTime(txtFecha.Text.Trim().ToUpper());
                obj.Estado = Convert.ToInt32(txtEstado.Text.Trim().ToUpper());
                obj.Id_conversacion = Convert.ToInt32(txtIDconversacion.Text.Trim().ToUpper());
                obj.Id_usuario = Convert.ToInt32(txtCreador.Text.Trim().ToUpper());
                string msn = objCtrl.actualizaObj(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaMensaje.aspx");

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
            BO.Mensaje obj = (BO.Mensaje)Session["frmMensajeBO"];
            Servicios.MensajeCtrl objCtrl = new Servicios.MensajeCtrl();
            obj.Id_mensaje = Convert.ToInt32(txtId.Text.Trim());
            string mensaje = objCtrl.eliminaObj(obj);
            if (mensaje == "La operación se realizó de manera correcta")
            {
                Response.Redirect("wfTablaMensaje.aspx");

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
            Response.Redirect("wfTablaMensaje.aspx");
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