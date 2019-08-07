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

            sql = "INSERT INTO genero VALUES(@nombre_genero)";
            

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

            bd.Cmd.Parameters.AddWithValue("@id_genero", data.Id_genero);

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
                  "SET nombre_genero=@nombre_genero" +
                  " WHERE id_genero=@id_genero";

            bd.Cmd.Parameters.AddWithValue("@id_genero", data.Id_genero);
            bd.Cmd.Parameters.AddWithValue("@nombre_genero", data.Nombre_genero);

            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
