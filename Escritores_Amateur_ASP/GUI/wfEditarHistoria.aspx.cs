using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfEditarHistoria : System.Web.UI.Page
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
            txtTitulo.Text = "";
            txtCategoria.Text = "";
            txtUrl.Text = "";
            txtSinopsis.Text = "";
            txtPrologo.Text = "";
        }
        public void cargaOperacion()
        {
            lblId.Visible = false;
            txtId.Visible = false;
            if ((String)Session["frmHistoriaOperacion"] == "Editar")
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
            BO.Historia obj = (BO.Historia)Session["frmHistoriaBO"];
            Servicios.HistoriaCtrl objCtrl = new Servicios.HistoriaCtrl();
            DataTable dt = objCtrl.devuelveObj(obj);
            if (dt.Rows.Count != 0)
            {
                txtId.Text = dt.Rows[0]["id_historia"].ToString();
                txtTitulo.Text = dt.Rows[0]["titulo"].ToString();
                txtCategoria.Text = dt.Rows[0]["id_categoria"].ToString();
                txtUrl.Text = dt.Rows[0]["portada_url"].ToString();
                txtSinopsis.Text = dt.Rows[0]["id_sinopsis"].ToString();
                txtPrologo.Text = dt.Rows[0]["id_prologo"].ToString();
            }
        }
        public void agregar()
        {
            string mensaje = "";
            if (txtTitulo.Text == string.Empty)
            {
                mensaje += "Introduce el Titulo\n";
            }
            if (txtCategoria.Text == string.Empty)
            {
                mensaje += "Introduce la categoria\n";
            }
            if (txtUrl.Text == string.Empty)
            {
                mensaje += "Introduce la URL \n";
            }
            if (txtSinopsis.Text == string.Empty)
            {
                mensaje += "Introduce la sinopsis \n";
            }
            if (txtPrologo.Text == string.Empty)
            {
                mensaje += "Introduce el prologo \n";
            }


            if (mensaje.Trim().Length == 0)
            {
                BO.Historia obj = new BO.Historia();
                Servicios.HistoriaCtrl objCtrl = new Servicios.HistoriaCtrl();
                obj.Titulo = txtTitulo.Text.Trim();
                obj.Id_categoria = Convert.ToInt32(txtCategoria.Text);
                obj.Portada_url = txtUrl.Text;
                obj.Id_sinopsis = Convert.ToInt32(txtSinopsis.Text);
                obj.Id_prologo = Convert.ToInt32(txtPrologo.Text);
                string msn = objCtrl.creaHistoria(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaHistoria.aspx");

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
            if (txtTitulo.Text == string.Empty)
            {
                mensaje = mensaje + "Introduce el titulo \n";
            }
            if (txtCategoria.Text == string.Empty)
            {
                mensaje = mensaje + "Introduce la categoria \n";
            }
            if (txtSinopsis.Text == string.Empty)
            {
                mensaje = mensaje + "Introduce la sinopsis \n";
            }
            if (txtPrologo.Text == string.Empty)
            {
                mensaje = mensaje + "Introduce el prologo \n";
            }


            if (mensaje.Trim().Length == 0)
            {
                BO.Historia obj = new BO.Historia();
                Servicios.HistoriaCtrl objCtrl = new Servicios.HistoriaCtrl();
                obj.Id_historia = Convert.ToInt32(txtId.Text);
                obj.Titulo = txtTitulo.Text;
                obj.Id_categoria = Convert.ToInt32(txtCategoria.Text);
                obj.Portada_url = txtUrl.Text;
                obj.Id_sinopsis = Convert.ToInt32(txtSinopsis.Text);
                obj.Id_prologo = Convert.ToInt32(txtPrologo.Text);
                string msn = objCtrl.actualizaObj(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("wfTablaHistoria.aspx");

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
            BO.Historia obj = (BO.Historia)Session["frmHistoriaBO"];
            Servicios.HistoriaCtrl objCtrl = new Servicios.HistoriaCtrl();
            obj.Id_historia = Convert.ToInt32(txtId.Text.Trim());
            string mensaje = objCtrl.eliminaObj(obj);
            if (mensaje == "La operación se realizó de manera correcta")
            {
                Response.Redirect("wfTablaHistoria.aspx");

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
            Response.Redirect("wfTablaHistoria.aspx");
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