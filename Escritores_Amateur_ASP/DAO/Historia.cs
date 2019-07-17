using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Escritores_Amateur_ASP.DAO
{
    public class Historia
    {
        string sql;
        BaseDB bd;

        public Historia()
        {

        }

        public DataTable getPreviewLastStories()
        {
            BO.Historia data = new BO.Historia();
            bd = new BaseDB();

            sql = " SELECT * FROM VIEW_PREW_LAST_STORIES ";

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }

        public DataTable devuelveDatos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            BO.Historia data = (BO.Historia)obj;
            bd = new BaseDB();

            if (data.Id_historia > 0)
            {
                cadenaWhere += " id_historia=@id_historia and";
                bd.Cmd.Parameters.Add("@id_historia", SqlDbType.Int);
                bd.Cmd.Parameters["@id_historia"].Value = data.Id_historia;
                edo = true;
            }

            sql = " SELECT * FROM historia " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
    }
}