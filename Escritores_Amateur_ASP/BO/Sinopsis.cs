using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.BO
{
    public class Sinopsis
    {
        private int id_sinopsis;
        private string cabecera;
        private string contenido;

        public int Id_sinopsis { get => id_sinopsis; set => id_sinopsis = value; }
        public string Cabecera { get => cabecera; set => cabecera = value; }
        public string Contenido { get => contenido; set => contenido = value; }
    }
}