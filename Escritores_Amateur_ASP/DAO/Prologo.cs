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
            if (edo == true)
            {
                cadenaWhere = "WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM prologo " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
        public int creaPrologo(object obj)
        {
            BO.Prologo data = (BO.Prologo)obj;
            bd = new BaseDB();
            bd.Cmd.CommandType = CommandType.StoredProcedure;

            sql = "INSERT INTO prologo(contenido) VALUES(@contenido)";

            bd.Cmd.Parameters.AddWithValue("@contenido", data.Contenido);
            int i = bd.execNonQuery(sql);
            if (i == 0)
                return 0;
            else
                return 1;
        }

        public int eliminaDatos(object obj)
        {
            BO.Prologo data = (BO.Prologo)obj;
            bd = new BaseDB();
            bd.Cmd.Parameters.Add("@id_prologo", SqlDbType.Int);
            bd.Cmd.Parameters["@id_prologo"].Value = data.Id_prologo;

            sql = "DELETE FROM prologo WHERE id_prologo=@id_prologo";
            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
        public int actualizaPrologo(object obj)
        {
            BO.Prologo data = (BO.Prologo)obj;
            bd = new BaseDB();
            sql = "UPDATE prologo " +
                  "SET contenido=@contenido," +
                  " WHERE id_prologo=@id_prologo";
            bd.Cmd.Parameters.Add("@id_prologo", SqlDbType.Int);
            bd.Cmd.Parameters.Add("@contenido", SqlDbType.VarChar);

            bd.Cmd.Parameters["@id_prologo"].Value = data.Id_prologo;
            bd.Cmd.Parameters["@contenido"].Value = data.Contenido;

            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}