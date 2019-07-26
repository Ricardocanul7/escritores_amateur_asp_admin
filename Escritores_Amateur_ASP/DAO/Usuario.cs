using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.DAO
{
    public class Usuario
    {
        string sql;
        BaseDB bd;

        public Usuario()
        {

        }

        public DataTable devuelveDatos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            BO.Usuario data = (BO.Usuario)obj;
            bd = new BaseDB();

            if(data.Id_usuario > 0)
            {
                cadenaWhere += " id_usuario=@id_usuario and";
                bd.Cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                bd.Cmd.Parameters["@id_usuario"].Value = data.Id_usuario;
                edo = true;
            }
            if(data.Username != null)
            {
                cadenaWhere += " username=@username and";
                bd.Cmd.Parameters.Add("@username", SqlDbType.VarChar);
                bd.Cmd.Parameters["@username"].Value = data.Username;
                edo = true;
            }
            if (data.Contrasenia != null)
            {
                cadenaWhere += " contrasenia=@contrasenia and";
                bd.Cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar);
                bd.Cmd.Parameters["@contrasenia"].Value = data.Contrasenia;
                edo = true;
            }
            if (edo == true)
            {
                cadenaWhere = "WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM usuario " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
    }
}