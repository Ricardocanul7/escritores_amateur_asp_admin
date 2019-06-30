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



            sql = " SELECT * FROM sinopsis " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
    }
}