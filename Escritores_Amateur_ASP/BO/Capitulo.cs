using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.BO
{
    public class Capitulo
    {
        private int id_capitulo;
        private string titulo;
        private string contenido;
        private int id_historia;

        public int Id_capitulo { get => id_capitulo; set => id_capitulo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public int Id_historia { get => id_historia; set => id_historia = value; }
    }
}