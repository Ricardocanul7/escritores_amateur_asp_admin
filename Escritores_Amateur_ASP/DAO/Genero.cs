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



            sql = " SELECT * FROM genero " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
    }
}