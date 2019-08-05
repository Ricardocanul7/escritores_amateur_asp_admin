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
            precargarInfo();
        }

        protected void btn_add_story_Click(object sender, EventArgs e)
        {
            DAO.Usuario usuarioDAO = new DAO.Usuario();
            BO.Usuario usuarioBO = new BO.Usuario();
            BO.Sinopsis sinopsisBO = new BO.Sinopsis();
            BO.Prologo prologoBO = new BO.Prologo();

            DataRow[] dr_user = usuarioDAO.devuelveDatos(usuarioBO).Select("username=" + Session["username"].ToString());

            int id_autor = Convert.ToInt32(dr_user[0]["id_usuario"]);
            string titulo = txtTitulo.Text;
            string sinopsis = txtSinopsis.Text;
            string prologo = txtPrologo.Text;
            // Portada por default mientras se arregla como subir imagenes y obtener su url
            string portada_url = "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwjl7JjU0ezjAhWkrFkKHcsHA2cQjRx6BAgBEAU&url=https%3A%2F%2Fpixabay.com%2Fes%2Fvectors%2Flibro-portada-en-blanco-cerrado-306178%2F&psig=AOvVaw3lqaZvA2xFo1z31oQP1eG1&ust=1565125666554652";

            

            DAO.Historia historiaDAO = new DAO.Historia();

            //int rowsAffected = historiaDAO.AgregarHistoriaSP()
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