﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Escritores_Amateur_ASP.DAO;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfMisHistorias : System.Web.UI.Page
    {
        string id_autor;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarInfo();
        }
        public void cargarInfo()
        {
            // RECUPERAR INFORMACION DEL USUARIO LOGGEADO
            DAO.Usuario usuarioDAO = new DAO.Usuario();
            BO.Usuario usuarioBO = new BO.Usuario();

            usuarioBO.Username = Session["username"].ToString();

            DataRow[] dr_usuarios = usuarioDAO.devuelveDatos(usuarioBO).Select();
            id_autor = dr_usuarios[0]["id_usuario"].ToString();

            // RECUPERA LAS HISTORIAS DE UN SOLO AUTOR
            DAO.Historia historiaDAO = new DAO.Historia();
            DataTable dt_misHistorias = historiaDAO.GetStoriesByAuthor(id_autor);

            dlistMisHistorias.DataSource = dt_misHistorias;
            dlistMisHistorias.DataBind();
        }

        public DataTable recuperarHistorias()
        {
            DAO.Historia historia = new Historia();
            return historia.recuperaHistoria();
        }

        protected void btnAgregarHistoria_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfAgregarHistoria.aspx");
        }

        protected void dlistMisHistorias_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName == "editar_historia")
            {
                int id_historia = Convert.ToInt32(e.CommandArgument);
                // AUN FALTA COMPLETAR QUE REDIRECCIONE A UNA PAGINA PARA
                // EDITAR EL CONTENIDO DE LA HISTORIA
            }
            if(e.CommandName == "eliminar_historia")
            {
                int id_historia = Convert.ToInt32(e.CommandArgument);

                DAO.Historia historiaDAO = new DAO.Historia();

                historiaDAO.EliminarHistoriaSP(id_historia);
            }
        }
    }
}