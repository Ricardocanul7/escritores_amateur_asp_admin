using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.DAO
{
    public class Revision
    {
        string sql;
        BaseDB bd;

        public Revision()
        {

        }

        public DataTable devuelveDatos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            BO.Revision data = (BO.Revision)obj;
            bd = new BaseDB();

            if (data.Id_admin > 0)
            {
                cadenaWhere += " id_admin=@id_admin and";
                bd.Cmd.Parameters.Add("@id_admin", SqlDbType.Int);
                bd.Cmd.Parameters["@id_admin"].Value = data.Id_admin;
                edo = true;
            }
            if (data.Id_historia > 0)
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

            sql = " SELECT * FROM admin_revision " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
        public int creaRevision(object obj)
        {
            BO.Revision data = (BO.Revision)obj;
            bd = new BaseDB();

            sql = "INSERT INTO admin_revision VALUES(@id_admin, @id_historia, GETDATE(), @id_estatus)";

            bd.Cmd.Parameters.AddWithValue("@id_admin", data.Id_admin);
            bd.Cmd.Parameters.AddWithValue("@id_historia", data.Id_historia);
            //bd.Cmd.Parameters.AddWithValue("@fecha_aprovacion", data.FechaRevision);
            bd.Cmd.Parameters.AddWithValue("@id_estatus", data.Id_estado);

            int i = bd.execNonQuery(sql);
            if (i == 0)
                return 0;
            else
                return 1;
        }

        public int eliminaDatos(object obj)
        {
            BO.Revision data = (BO.Revision)obj;
            bd = new BaseDB();

            sql = "DELETE FROM admin_revision WHERE id_historia=@id_historia";

            bd.Cmd.Parameters.AddWithValue("@id_categoria", data.Id_historia);

            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
        public int actualizaRevision(object obj)
        {
            BO.Revision data = (BO.Revision)obj;
            bd = new BaseDB();

            sql = "UPDATE admin_revision " +
                  "SET id_admin=@id_admin" +
                  //" id_historia=@id_historia" +
                  " fecha_aprovacion = GETDATE()" +
                  " id_estatus = @id_estatus" +
                  " WHERE id_historia=@id_historia";

            bd.Cmd.Parameters.AddWithValue("@id_admin", data.Id_admin);
            bd.Cmd.Parameters.AddWithValue("@id_estatus", data.Id_estado);
            bd.Cmd.Parameters.AddWithValue("@id_historia", data.Id_historia);

            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }

        public DataTable GetStatus()
        {
            bd = new BaseDB();

            sql = " SELECT * FROM status_historia";

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
    }
}