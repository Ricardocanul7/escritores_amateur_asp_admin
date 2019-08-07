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

            sql = "INSERT INTO categoria VALUES(@nombre_cat)";

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

            sql = "DELETE FROM categoria WHERE id_categoria=@id_categoria";

            bd.Cmd.Parameters.AddWithValue("@id_categoria", data.Id_categoria);

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
                  "SET nombre_cat=@nombre_cat" +
                  " WHERE id_categoria=@id_categoria";

            bd.Cmd.Parameters.AddWithValue("@id_categoria", data.Id_categoria);
            bd.Cmd.Parameters.AddWithValue("@nombre_cat", data.Nombre_cat);

            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}