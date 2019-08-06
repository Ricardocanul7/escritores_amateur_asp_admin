using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfAgregarHistoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                precargarInfo();
            }
        }

        protected void btn_add_story_Click(object sender, EventArgs e)
        {
            DAO.Usuario usuarioDAO = new DAO.Usuario();
            BO.Usuario usuarioBO = new BO.Usuario();
            BO.Sinopsis sinopsisBO = new BO.Sinopsis();
            BO.Prologo prologoBO = new BO.Prologo();

            string username = Session["username"].ToString();
            DataTable dt_users = usuarioDAO.devuelveDatos(usuarioBO);
            DataRow[] dr_user = dt_users.Select(string.Format("username = '{0}'", username));

            int id_autor = Convert.ToInt32(dr_user[0]["id_usuario"]);
            string titulo = txtTitulo.Text;
            string sinopsis = txtSinopsis.Text;
            string prologo = txtPrologo.Text;
            int id_categoria = Convert.ToInt32(lboxCategoria.SelectedValue);
            // Portada por default mientras se arregla como subir imagenes y obtener su url
            string portada_url = "https://cdn.pixabay.com/photo/2014/04/02/14/06/book-306178_960_720.png";

            

            DAO.Historia historiaDAO = new DAO.Historia();
            int rowsAffected = historiaDAO.AgregarHistoriaSP(id_autor, titulo, portada_url, sinopsis, prologo, id_categoria);

            if(rowsAffected == 0)
            {
                Mensaje("Ha ocurrido un error!");
            }
            else
            {
                Session["agregarCapitulo"] = "true";
                Session["id_historia"] = GetLastID_story_added();
                Response.Redirect("../GUI/wfAgregarCapitulo.aspx");
            }
        }

        public int GetLastID_story_added()
        {
            DAO.Historia historiaDAO = new DAO.Historia();
            BO.Historia historiaBO = new BO.Historia();

            DataTable dt_stories = historiaDAO.GetTopRows_Descendent();
            return Convert.ToInt32(dt_stories.Rows[0]["id_historia"]);
        }

        private void Mensaje(string ex)
        {
            string mensaje = ex;
            mensaje = mensaje.Replace(Environment.NewLine, "\\n");
            mensaje = mensaje.Replace("\n", "\\n");
            mensaje = mensaje.Replace("'", "\"");
            ClientScript.RegisterClientScriptBlock(typeof(Page), "Error", "<script> alert('" + mensaje + "');</script>");
        }

        public void precargarInfo()
        {
            BO.Categoria categoriaBO = new BO.Categoria();
            DAO.Categoria categoriaDAO = new DAO.Categoria();

            lboxCategoria.Items.Clear();
            DataRow[] dr_categoria = categoriaDAO.devuelveDatos(categoriaBO).Select();

            foreach (var row in dr_categoria)
            {
                ListItem listItem = new ListItem();
                listItem.Text = row["nombre_cat"].ToString();
                listItem.Value = row["id_categoria"].ToString();
                lboxCategoria.Items.Add(listItem);
            }
        }
    }
}