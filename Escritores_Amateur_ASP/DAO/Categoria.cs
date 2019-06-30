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



            sql = " SELECT * FROM categoria " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
    }
}