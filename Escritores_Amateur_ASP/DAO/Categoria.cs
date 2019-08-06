using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.DAO
{
    public class Categoria
    {
        string sql;
        BaseDB bd;

        public Categoria()
        {

        }

        public DataTable devuelveDatos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            BO.Categoria data = (BO.Categoria)obj;
            bd = new BaseDB();

            if (data.Id_categoria > 0)
            {
                cadenaWhere += " id_categoria=@id_categoria and";
                bd.Cmd.Parameters.Add("@id_categoria", SqlDbType.Int);
                bd.Cmd.Parameters["@id_categoria"].Value = data.Id_categoria;
                edo = true;
            }
            if (edo == true)
            {
                cadenaWhere = "WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM categoria " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
        public int creaCategoria(object obj)
        {
            BO.Categoria data = (BO.Categoria)obj;
            bd = new BaseDB();
            bd.Cmd.CommandType = CommandType.StoredProcedure;

            sql = "INSERT INTO categoria(nombre_cat) VALUES(@nombre_cat)";
            //sql = "EXEC SP_REGISTRO_USUARIO @nombre, @apellido_pat, @apellido_mat, @correo, @avatar, @municipio, @telefono, @sitio_web, @biografia, @username, @contrasenia, @tipo_usuario;";

            //bd.Cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
            //bd.Cmd.Parameters.Add("@apellido_pat", SqlDbType.VarChar);
            //bd.Cmd.Parameters.Add("@apellido_mat", SqlDbType.VarChar);
            //bd.Cmd.Parameters.Add("@correo", SqlDbType.VarChar);
            //bd.Cmd.Parameters.Add("@avatar", SqlDbType.VarChar);
            //bd.Cmd.Parameters.Add("@municipio", SqlDbType.Int);
            //bd.Cmd.Parameters.Add("@telefono", SqlDbType.Char);
            //bd.Cmd.Parameters.Add("@sitio_web", SqlDbType.VarChar);
            //bd.Cmd.Parameters.Add("@biografia", SqlDbType.Text);
            //bd.Cmd.Parameters.Add("@username", SqlDbType.VarChar);
            //bd.Cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar);
            //bd.Cmd.Parameters.Add("@tipo_usuario", SqlDbType.Int);

            //bd.Cmd.Parameters["@nombre"].Value = data.Nombre;
            //bd.Cmd.Parameters["@apellido_pat"].Value = data.Apellido_pat;
            //bd.Cmd.Parameters["@apellido_mat"].Value = data.Apellido_mat;
            //bd.Cmd.Parameters["@correo"].Value = data.Correo;
            //bd.Cmd.Parameters["@avatar"].Value = data.Avatar;
            //bd.Cmd.Parameters["@municipio"].Value = data.Municipio;
            //bd.Cmd.Parameters["@telefono"].Value = data.Telefono;
            //bd.Cmd.Parameters["@sitio_web"].Value = data.Sitio_web;
            //bd.Cmd.Parameters["@biografia"].Value = data.Biografia;
            //bd.Cmd.Parameters["@username"].Value = data.Username;
            //bd.Cmd.Parameters["@contrasenia"].Value = data.Contrasenia;
            //bd.Cmd.Parameters["@tipo_usuario"].Value = data.Tipo_usuario;

            bd.Cmd.Parameters.AddWithValue("@nombre_cat", data.Nombre_cat);
            int i = bd.execNonQuery(sql);
            if (i == 0)
                return 0;
            else
                return 1;
        }

        public int eliminaDatos(object obj)
        {
            BO.Categoria data = (BO.Categoria)obj;
            bd = new BaseDB();
            bd.Cmd.Parameters.Add("@id_categoria", SqlDbType.Int);
            bd.Cmd.Parameters["@id_categoria"].Value = data.Id_categoria;

            sql = "DELETE FROM categoria WHERE id_categoria=@id_categoria";
            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
        public int actualizaCategoria(object obj)
        {
            BO.Categoria data = (BO.Categoria)obj;
            bd = new BaseDB();
            sql = "UPDATE categoria " +
                  "SET nombre_cat=@nombre_cat," +
                  " WHERE id_categoria=@id_categoria";
            bd.Cmd.Parameters.Add("@id_categoria", SqlDbType.Int);
            bd.Cmd.Parameters.Add("@nombre_cat", SqlDbType.VarChar);

            bd.Cmd.Parameters["@id_categoria"].Value = data.Id_categoria;
            bd.Cmd.Parameters["@nombre_cat"].Value = data.Nombre_cat;

            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}