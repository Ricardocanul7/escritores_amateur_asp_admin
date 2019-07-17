using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.BO
{
    public class Prologo
    {
        private int id_prologo;
        private string cabecera;
        private string contenido;

        public int Id_prologo { get => id_prologo; set => id_prologo = value; }
        public string Cabecera { get => cabecera; set => cabecera = value; }
        public string Contenido { get => contenido; set => contenido = value; }
    }
}