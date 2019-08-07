using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Escritores_Amateur_ASP.DAO
{
    public class Capitulo
    {
        string sql;
        BaseDB bd;

        public Capitulo()
        {

        }

        public DataTable devuelveDatos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            BO.Capitulo data = (BO.Capitulo)obj;
            bd = new BaseDB();

            if (data.Id_capitulo > 0)
            {
                cadenaWhere += " id_capitulo=@id_capitulo and";
                bd.Cmd.Parameters.Add("@id_capitulo", SqlDbType.Int);
                bd.Cmd.Parameters["@id_capitulo"].Value = data.Id_capitulo;
                edo = true;
            }
            if(data.Id_historia > 0)
            {
                cadenaWhere += " id_historia=@id_historia and";
                bd.Cmd.Parameters.Add("@id_historia", SqlDbType.Int);
                bd.Cmd.Parameters["@id_historia"].Value = data.Id_historia;
                edo = true;
            }
            if (edo == true)
            {
                cadenaWhere = "WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM capitulo " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
        public int creaCapitulo(object obj)
        {
            BO.Capitulo data = (BO.Capitulo)obj;
            bd = new BaseDB();

            sql = "INSERT INTO capitulo VALUES(@titulo, @contenido, @id_historia)";

            bd.Cmd.Parameters.AddWithValue("@titulo", data.Titulo);
            bd.Cmd.Parameters.AddWithValue("@contenido", data.Contenido);
            bd.Cmd.Parameters.AddWithValue("@id_historia", data.Id_historia);

            int i = bd.execNonQuery(sql);
            if (i == 0)
                return 0;
            else
                return 1;
        }

        public int eliminaDatos(object obj)
        {
            BO.Capitulo data = (BO.Capitulo)obj;
            bd = new BaseDB();
            bd.Cmd.Parameters.Add("@id_capitulo", SqlDbType.Int);
            bd.Cmd.Parameters["@id_capitulo"].Value = data.Id_capitulo;

            sql = "DELETE FROM capitulo WHERE id_capitulo=@id_capitulo";
            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
        public int actualizaCapitulo(object obj)
        {
            BO.Capitulo data = (BO.Capitulo)obj;
            bd = new BaseDB();
            sql = "UPDATE capitulo " +
                  "SET titulo=@titulo," +
                  "contenido=@contenido" +
                  //"id_historia=@id_historia" +
                  " WHERE id_capitulo=@id_capitulo";
            bd.Cmd.Parameters.Add("@id_capitulo", SqlDbType.Int);
            bd.Cmd.Parameters.Add("@titulo", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@contenido", SqlDbType.VarChar);
            //bd.Cmd.Parameters.Add("@id_historia", SqlDbType.Int);

            bd.Cmd.Parameters["@id_capitulo"].Value = data.Id_capitulo;
            bd.Cmd.Parameters["@titulo"].Value = data.Titulo;
            bd.Cmd.Parameters["@contenido"].Value = data.Contenido;
            //bd.Cmd.Parameters["@id_historia"].Value = data.Id_historia;


            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}