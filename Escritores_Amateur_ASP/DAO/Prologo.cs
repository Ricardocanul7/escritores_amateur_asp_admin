using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Escritores_Amateur_ASP.DAO
{
    public class Prologo
    {
        string sql;
        BaseDB bd;

        public Prologo()
        {

        }

        public DataTable devuelveDatos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            BO.Prologo data = (BO.Prologo)obj;
            bd = new BaseDB();

            if (data.Id_prologo > 0)
            {
                cadenaWhere += " id_prologo=@id_prologo and";
                bd.Cmd.Parameters.Add("@id_prologo", SqlDbType.Int);
                bd.Cmd.Parameters["@id_prologo"].Value = data.Id_prologo;
                edo = true;
            }

            sql = " SELECT * FROM prologo " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
    }
}