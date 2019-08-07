using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfEditarRevision : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaOperacion();
                llenar_status();
            }
        }

        public void cargaOperacion()
        {
            lblId.Visible = false;
            txtId_admin.Visible = false;
            if ((String)Session["frmRevisionOperacion"] == "Editar")
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

        public void limpiar()
        {
            txtId_admin.Text = "";
            txtIdHistoria.Text = "";
            lboxEstado.Items.Clear();
        }

        public void llenar_status()
        {
            lboxEstado.Items.Clear();
            DAO.Revision revisionDAO = new DAO.Revision();
            DataRow[] dr_status = revisionDAO.GetStatus().Select();

            foreach (var row in dr_status)
            {
                ListItem listItem = new ListItem();
                listItem.Text = row["nombre_estatus"].ToString();
                listItem.Value = row["id_status"].ToString();
                lboxEstado.Items.Add(listItem);
            }
        }

        public void buscar()
        {
            BO.Revision obj = (BO.Revision)Session["frmRevisionBO"];
            DAO.Revision objCtrl = new DAO.Revision();
            DataTable dt = objCtrl.devuelveDatos(obj);

            if (dt.Rows.Count != 0)
            {
                txtId_admin.Text = dt.Rows[0]["id_admin"].ToString();
                txtIdHistoria.Text = dt.Rows[0]["id_historia"].ToString();
                lboxEstado.SelectedValue = dt.Rows[0]["id_estatus"].ToString();
            }
        }
        public void agregar()
        {
            string mensaje = "";
            if (txtId_admin.Text==string.Empty)
            {
                mensaje = mensaje + "Introduce el Titulo\n";
            }
            if (txtIdHistoria.Text == string.Empty)
            {
                mensaje = mensaje + "Introduce el contenido\n";
            }


            if (mensaje.Trim().Length == 0)
            {
                BO.Revision obj = new BO.Revision();
                DAO.Revision objCtrl = new DAO.Revision();
                obj.Id_admin = Convert.ToInt32(txtId_admin.Text);
                obj.Id_historia = Convert.ToInt32(txtIdHistoria.Text);
                obj.Id_estado = Convert.ToInt32(lboxEstado.SelectedValue);
                int ok = objCtrl.creaRevision(obj);
                if (ok != 0)
                {
                    Response.Redirect("wfTablaRevisiones.aspx");

                }
                else
                {
                    Mensaje("La operación no se realizó de manera correcta");
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
            if (txtId_admin.Text == string.Empty)
            {
                mensaje = mensaje + "Introduce el Titulo\n";
            }
            if (txtIdHistoria.Text == string.Empty)
            {
                mensaje = mensaje + "Introduce el contenido\n";
            }


            if (mensaje.Trim().Length == 0)
            {
                BO.Revision obj = new BO.Revision();
                DAO.Revision objCtrl = new DAO.Revision();
                obj.Id_admin = Convert.ToInt32(txtId_admin.Text);
                obj.Id_historia = Convert.ToInt32(txtIdHistoria.Text);
                obj.Id_estado = Convert.ToInt32(lboxEstado.SelectedValue);
                int ok = objCtrl.actualizaRevision(obj);
                if (ok != 0)
                {
                    Response.Redirect("wfTablaRevisiones.aspx");

                }
                else
                {
                    Mensaje("La operación no se realizó de manera correcta");
                }
            }
            else
            {
                Mensaje("Favor de ingresar los siguientes datos:\n" + mensaje);
            }
        }
        public void eliminar()
        {
            BO.Revision obj = (BO.Revision)Session["frmRevisionBO"];
            DAO.Revision objCtrl = new DAO.Revision();

            obj.Id_historia = Convert.ToInt32(txtIdHistoria.Text);

            int ok = objCtrl.eliminaDatos(obj);
            if (ok != 0)
            {
                Response.Redirect("wfTablaRevisiones.aspx");

            }
            else
            {
                Mensaje("La operación se realizó de manera correcta");
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
            Response.Redirect("wfTablaRevisiones.aspx");
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