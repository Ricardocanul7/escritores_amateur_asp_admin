using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.BO
{
    public class Categoria
    {
        private int id_categoria;
        private string nombre_cat;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre_cat { get => nombre_cat; set => nombre_cat = value; }
    }
}