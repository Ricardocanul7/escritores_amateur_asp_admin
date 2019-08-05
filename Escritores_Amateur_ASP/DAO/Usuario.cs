using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Escritores_Amateur_ASP.BO;

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

        public int creaUsuario(object obj)
        {
            BO.Usuario data = (BO.Usuario)obj;
            bd = new BaseDB();
            bd.Cmd.CommandType = CommandType.StoredProcedure;

            sql = "SP_REGISTRO_USUARIO";
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

            bd.Cmd.Parameters.AddWithValue("@nombre", data.Nombre);
            bd.Cmd.Parameters.AddWithValue("@apellido_pat", data.Apellido_pat);

            if(data.Apellido_mat == string.Empty)
                bd.Cmd.Parameters.AddWithValue("@apellido_mat", DBNull.Value);
            else
                bd.Cmd.Parameters.AddWithValue("@apellido_mat", data.Apellido_mat);

            bd.Cmd.Parameters.AddWithValue("@correo", data.Correo);
            bd.Cmd.Parameters.AddWithValue("@avatar", DBNull.Value);
            bd.Cmd.Parameters.AddWithValue("@municipio", data.Municipio);
            bd.Cmd.Parameters.AddWithValue("@telefono", data.Telefono);
            bd.Cmd.Parameters.AddWithValue("@sitio_web", DBNull.Value);
            bd.Cmd.Parameters.AddWithValue("@biografia", DBNull.Value);
            bd.Cmd.Parameters.AddWithValue("@username", data.Username);
            bd.Cmd.Parameters.AddWithValue("@contrasenia", data.Contrasenia);
            bd.Cmd.Parameters.AddWithValue("@tipo_usuario", data.Tipo_usuario);

            int i = bd.execNonQuery(sql);
            if (i == 0)
                return 0;
            else
                return 1;
        }

        public int eliminaDatos(object obj)
        {
            BO.Usuario data = (BO.Usuario)obj;
            bd = new BaseDB();
            bd.Cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
            bd.Cmd.Parameters["@id_usuario"].Value = data.Id_usuario;

            sql = "DELETE FROM Flor WHERE id_usuario=@id_usuario";
            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
        public int actualizaUsuario(object obj)
        {
            BO.Usuario data = (BO.Usuario)obj;
            bd = new BaseDB();
            sql = "UPDATE usuario " +
                  "SET nombre=@nombre," +
                  "apellido_pat=@apellido_pat," +
                  "apellido_mat=@apellido_mat," +
                  "correo=@correo," +
                  "avatar=@avatar," +
                  "municipio=@municipio" +
                  "telefono=@telefono," +
                  "sitio_web=@sitio_web," +
                  "biografia=@biografia," +
                  "username=@username," +
                  "contrasenia=@contrasenia" +
                  "tipo_usuario=@tipo_usuario" +
                  " WHERE IdFlor=@id_usuario";
            bd.Cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
            bd.Cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@apellido_pat", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@apellido_mat", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@correo", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@avatar", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@municipio", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@telefono", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@sitio_web", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@biografia", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@username", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@tipo_usuario", SqlDbType.VarChar);

            bd.Cmd.Parameters["@id_usuario"].Value = data.Id_usuario;
            bd.Cmd.Parameters["@nombre"].Value = data.Nombre;
            bd.Cmd.Parameters["@apellido_pat"].Value = data.Apellido_pat;
            bd.Cmd.Parameters["@apellido_mat"].Value = data.Apellido_mat;
            bd.Cmd.Parameters["@correo"].Value = data.Correo;
            bd.Cmd.Parameters["@avatar"].Value = data.Avatar;
            bd.Cmd.Parameters["@municipio"].Value = data.Municipio;
            bd.Cmd.Parameters["@telefono"].Value = data.Telefono;
            bd.Cmd.Parameters["@sitio_web"].Value = data.Sitio_web;
            bd.Cmd.Parameters["@biografia"].Value = data.Biografia;
            bd.Cmd.Parameters["@username"].Value = data.Username;
            bd.Cmd.Parameters["@contrasenia"].Value = data.Contrasenia;
            bd.Cmd.Parameters["@tipo_usuario"].Value = data.Tipo_usuario;

            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}