using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.BO
{
    public class Genero
    {
        private int id_genero;
        private string nombre_genero;

        public int Id_genero { get => id_genero; set => id_genero = value; }
        public string Nombre_genero { get => nombre_genero; set => nombre_genero = value; }
    }
}