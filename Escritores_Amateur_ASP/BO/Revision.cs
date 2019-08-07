using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.BO
{
    public class Revision
    {
        private int id_admin;
        private int id_historia;
        private string fechaRevision;
        private int id_estado;

        public int Id_admin { get => id_admin; set => id_admin = value; }
        public int Id_historia { get => id_historia; set => id_historia = value; }
        public string FechaRevision { get => fechaRevision; set => fechaRevision = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
    }
}