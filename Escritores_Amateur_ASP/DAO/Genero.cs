using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.DAO
{
    public class Genero
    {
        string sql;
        BaseDB bd;

        public Genero()
        {

        }

        public DataTable devuelveDatos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            BO.Genero data = (BO.Genero)obj;
            bd = new BaseDB();

            if (data.Id_genero > 0)
            {
                cadenaWhere += " id_genero=@id_genero and";
                bd.Cmd.Parameters.Add("@id_genero", SqlDbType.Int);
                bd.Cmd.Parameters["@id_genero"].Value = data.Id_genero;
                edo = true;
            }
            if (edo == true)
            {
                cadenaWhere = "WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM genero " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
        public int creaGenero(object obj)
        {
            BO.Genero data = (BO.Genero)obj;
            bd = new BaseDB();
            bd.Cmd.CommandType = CommandType.StoredProcedure;

            sql = "INSERT INTO genero(nombre_genero) VALUES(@nombre_genero)";
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

            bd.Cmd.Parameters.AddWithValue("@nombre_genero", data.Nombre_genero);
            int i = bd.execNonQuery(sql);
            if (i == 0)
                return 0;
            else
                return 1;
        }

        public int eliminaDatos(object obj)
        {
            BO.Genero data = (BO.Genero)obj;
            bd = new BaseDB();
            bd.Cmd.Parameters.Add("@id_genero", SqlDbType.Int);
            bd.Cmd.Parameters["@id_genero"].Value = data.Id_genero;

            sql = "DELETE FROM genero WHERE id_genero=@id_genero";
            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
        public int actualizaGenero(object obj)
        {
            BO.Genero data = (BO.Genero)obj;
            bd = new BaseDB();
            sql = "UPDATE genero " +
                  "SET nombre_genero=@nombre_genero," +
                  " WHERE id_genero=@id_genero";
            bd.Cmd.Parameters.Add("@id_genero", SqlDbType.Int);
            bd.Cmd.Parameters.Add("@nombre_genero", SqlDbType.VarChar);

            bd.Cmd.Parameters["@id_genero"].Value = data.Id_genero;
            bd.Cmd.Parameters["@nombre_genero"].Value = data.Nombre_genero;

            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
