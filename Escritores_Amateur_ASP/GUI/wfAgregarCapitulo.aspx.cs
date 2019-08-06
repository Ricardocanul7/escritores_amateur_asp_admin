﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escritores_Amateur_ASP.GUI
{
    public partial class wfAgregarCapitulo : System.Web.UI.Page
    {
        int id_historia;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["id_historia"] != null && Session["agregarCapitulo"].ToString() == "true")
            {
                id_historia = Convert.ToInt32(Session["id_historia"]);
                lblHeaderTitulo_Libro.Text = ObtenerInfoHistoria()["titulo"].ToString();
            }
        }

        public DataRow ObtenerInfoHistoria()
        {
            DAO.Historia historiaDAO = new DAO.Historia();
            BO.Historia historiaBO = new BO.Historia();

            DataRow[] dr_historia = historiaDAO.devuelveDatos(historiaBO).Select(String.Format("id_historia={0}", id_historia));
            return dr_historia[0];
        }

        protected void btnAgregarCap_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GUI/wfNuevoCapitulo.aspx");
        }
    }
}