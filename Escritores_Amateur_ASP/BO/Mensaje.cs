using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.BO
{
    public class Mensaje
    {
        private int id_mensaje;
        private string tecto;
        private DateTime fecha;
        private int estado;
        private int id_usuario;
        private int id_conversacion;

        public int Id_mensaje { get => id_mensaje; set => id_mensaje = value; }
        public string Tecto { get => tecto; set => tecto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_conversacion { get => id_conversacion; set => id_conversacion = value; }
    }
}