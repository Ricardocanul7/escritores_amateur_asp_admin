using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.DAO
{
    public class Localizacion
    {
        string sql;
        BaseDB bd;

        public Localizacion()
        {

        }

        public DataTable GetPaises()
        {
            bd = new BaseDB();

            sql = " SELECT * FROM pais";

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }

        public DataTable GetEstados()
        {
            bd = new BaseDB();

            sql = " SELECT * FROM estado";

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }

        public DataTable GetCiudades()
        {
            bd = new BaseDB();

            sql = " SELECT * FROM ciudad";

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
    }
}