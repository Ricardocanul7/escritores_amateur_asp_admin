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

            sql = "INSERT INTO sinopsis VALUES(@contenido)";
            
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

            sql = "DELETE FROM sinopsis WHERE id_sinopsis=@id_sinopsis";
            bd.Cmd.Parameters.AddWithValue("@id_sinopsis", data.Id_sinopsis);
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
                  "SET contenido=@contenido" +
                  " WHERE id_sinopsis=@id_sinopsis";

            bd.Cmd.Parameters.AddWithValue("@id_sinopsis", data.Id_sinopsis);
            bd.Cmd.Parameters.AddWithValue("@contenido", data.Contenido);

            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}