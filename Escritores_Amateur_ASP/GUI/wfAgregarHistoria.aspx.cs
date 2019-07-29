using System;
using System.Collections.Generic;
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

        }

        protected void btn_add_story_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string sinopsis = txtSinopsis.Text;
            string prologo = txtPrologo.Text;

            BO.Usuario usuarioBO = new BO.Usuario();
            BO.Sinopsis sinopsisBO = new BO.Sinopsis();
            BO.Prologo prologoBO = new BO.Prologo();


        }
    }
}