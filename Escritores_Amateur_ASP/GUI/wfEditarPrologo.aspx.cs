﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfEditarPrologo : System.Web.UI.Page
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
            if ((String)Session["frmPrologoOperacion"] == "Editar")
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
            BO.Prologo obj = (BO.Prologo)Session["frmPrologoBO"];
            Servicios.PrologoCtrl objCtrl = new Servicios.PrologoCtrl();
            DataTable dt = objCtrl.devuelveObj(obj);
            if (dt.Rows.Count != 0)
            {
                txtId.Text = dt.Rows[0]["id_prologo"].ToString();
                txtNombre.Text = dt.Rows[0]["contenido"].ToString();
            }
        }
        public void agregar()
        {
            string mensaje = "";
            if (txtNombre.Text == string.Empty)
            {
                mensaje = mensaje + "Introduce el contenido\n";
            }

            if (mensaje.Trim().Length == 0)
            {
                BO.Prologo obj = new BO.Prologo();
                Servicios.PrologoCtrl objCtrl = new Servicios.PrologoCtrl();
                obj.Contenido = txtNombre.Text;
                string msn = objCtrl.creaPrologo(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaPrologo.aspx");

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
                BO.Prologo obj = new BO.Prologo();
                Servicios.PrologoCtrl objCtrl = new Servicios.PrologoCtrl();
                obj.Id_prologo = Convert.ToInt32(txtId.Text);
                obj.Contenido = txtNombre.Text;
                string msn = objCtrl.actualizaObj(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaPrologo.aspx");

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
            BO.Prologo obj = (BO.Prologo)Session["frmPrologoBO"];
            Servicios.PrologoCtrl objCtrl = new Servicios.PrologoCtrl();
            obj.Id_prologo = Convert.ToInt32(txtId.Text);
            string mensaje = objCtrl.eliminaObj(obj);
            if (mensaje == "La operación se realizó de manera correcta")
            {
                Response.Redirect("wfTablaPrologo.aspx");

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
            Response.Redirect("wfTablaPrologo.aspx");
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