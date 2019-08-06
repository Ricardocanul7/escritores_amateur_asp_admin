using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.DAO
{
    public class Sinopsis
    {
        string sql;
        BaseDB bd;

        public Sinopsis()
        {

        }

        public DataTable devuelveDatos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            BO.Sinopsis data = (BO.Sinopsis)obj;
            bd = new BaseDB();

            if (data.Id_sinopsis > 0)
            {
                cadenaWhere += " id_sinopsis=@id_sinopsis and";
                bd.Cmd.Parameters.Add("@id_sinopsis", SqlDbType.Int);
                bd.Cmd.Parameters["@id_sinopsis"].Value = data.Id_sinopsis;
                edo = true;
            }
            if (edo == true)
            {
                cadenaWhere = "WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM sinopsis " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
        public int creaSinopsis(object obj)
        {
            BO.Sinopsis data = (BO.Sinopsis)obj;
            bd = new BaseDB();
            bd.Cmd.CommandType = CommandType.StoredProcedure;

            sql = "INSERT INTO sinopsis(contenido) VALUES(@contenido)";
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

            bd.Cmd.Parameters.AddWithValue("@contenido", data.Contenido);
            int i = bd.execNonQuery(sql);
            if (i == 0)
                return 0;
            else
                return 1;
        }

        public int eliminaDatos(object obj)
        {
            BO.Sinopsis data = (BO.Sinopsis)obj;
            bd = new BaseDB();
            bd.Cmd.Parameters.Add("@id_sinopsis", SqlDbType.Int);
            bd.Cmd.Parameters["@id_sinopsis"].Value = data.Id_sinopsis;

            sql = "DELETE FROM sinopsis WHERE id_sinopsis=@id_sinopsis";
            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
        public int actualizaSinopsis(object obj)
        {
            BO.Sinopsis data = (BO.Sinopsis)obj;
            bd = new BaseDB();
            sql = "UPDATE sinopsis " +
                  "SET contenido=@contenido," +
                  " WHERE id_sinopsis=@id_sinopsis";
            bd.Cmd.Parameters.Add("@id_sinopsis", SqlDbType.Int);
            bd.Cmd.Parameters.Add("@contenido", SqlDbType.VarChar);

            bd.Cmd.Parameters["@id_sinopsis"].Value = data.Id_sinopsis;
            bd.Cmd.Parameters["@contenido"].Value = data.Contenido;

            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}