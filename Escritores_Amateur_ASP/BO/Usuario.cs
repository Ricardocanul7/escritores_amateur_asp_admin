using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.BO
{
    public class Usuario
    {
        private int id_usuario;
        private string nombre;
        private string apellido_pat;
        private string apellido_mat;
        private string correo;
        private string avatar;
        private string municipio;
        private string telefono;
        private string sitio_web;
        private string biografia;
        private string username;
        private string contrasenia;
        private int tipo_usuario;

        public Usuario()
        {

        }

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_pat { get => apellido_pat; set => apellido_pat = value; }
        public string Apellido_mat { get => apellido_mat; set => apellido_mat = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Sitio_web { get => sitio_web; set => sitio_web = value; }
        public string Biografia { get => biografia; set => biografia = value; }
        public string Username { get => username; set => username = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public int Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
    }
}