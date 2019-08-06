﻿using System;
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
            cargaOperacion();
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
            if (txtNombre.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el nombre\n";
            }

            if (mensaje.Trim().Length == 0)
            {
                BO.Usuario obj = new BO.Usuario();
                Servicios.UsuarioCtrl objCtrl = new Servicios.UsuarioCtrl();
                obj.Nombre = txtNombre.Text.Trim();
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

            if (mensaje.Trim().Length == 0)
            {
                BO.Usuario obj = new BO.Usuario();
                Servicios.UsuarioCtrl objCtrl = new Servicios.UsuarioCtrl();
                obj.Id_usuario = Convert.ToInt32(txtId.Text.Trim().ToUpper());
                obj.Nombre = txtNombre.Text.Trim().ToUpper();
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
    }
}