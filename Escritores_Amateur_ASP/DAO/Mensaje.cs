﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Escritores_Amateur_ASP.DAO
{
    public class Mensaje
    {
        string sql;
        BaseDB bd;

        public Mensaje()
        {

        }

        public DataTable devuelveDatos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            BO.Mensaje data = (BO.Mensaje)obj;
            bd = new BaseDB();

            if (data.Id_mensaje > 0)
            {
                cadenaWhere += " id_mensaje=@id_mensaje and";
                bd.Cmd.Parameters.Add("@id_mensaje", SqlDbType.Int);
                bd.Cmd.Parameters["@id_mensaje"].Value = data.Id_mensaje;
                edo = true;
            }

            sql = " SELECT * FROM mensaje " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
    }
}