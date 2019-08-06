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
    }
}