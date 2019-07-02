using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.BO
{
    public class Historia
    {
        private int id_historia;
        private string titulo;
        private string portada_url;
        private int id_sinopsis;
        private int id_categoria;
        private int id_prologo;

        public int Id_historia { get => id_historia; set => id_historia = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Portada_url { get => portada_url; set => portada_url = value; }
        public int Id_sinopsis { get => id_sinopsis; set => id_sinopsis = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public int Id_prologo { get => id_prologo; set => id_prologo = value; }
    }
}