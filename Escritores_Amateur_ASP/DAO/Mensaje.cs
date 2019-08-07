using System;
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
            if (edo == true)
            {
                cadenaWhere = "WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = " SELECT * FROM mensaje " + cadenaWhere;

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }
        public int creaMensaje(object obj)
        {
            BO.Mensaje data = (BO.Mensaje)obj;
            bd = new BaseDB();

            sql = "INSERT INTO mensaje VALUES(@texto, GETDATE(), @estado, @id_user_creador, @id_conversacion)";

            bd.Cmd.Parameters.AddWithValue("@texto", data.Tecto);
            bd.Cmd.Parameters.AddWithValue("@fecha", data.Fecha);
            bd.Cmd.Parameters.AddWithValue("@estado", data.Estado);
            bd.Cmd.Parameters.AddWithValue("@id_user_creador", data.Id_usuario);
            bd.Cmd.Parameters.AddWithValue("@id_conversacion", data.Id_conversacion);

            int i = bd.execNonQuery(sql);
            if (i == 0)
                return 0;
            else
                return 1;
        }

        public int eliminaDatos(object obj)
        {
            BO.Mensaje data = (BO.Mensaje)obj;
            bd = new BaseDB();

            sql = "DELETE FROM historia WHERE id_mensaje=@id_mensaje";
            bd.Cmd.Parameters.AddWithValue("@id_mensaje", data.Id_mensaje);
            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }
        public int actualizaMensaje(object obj)
        {
            BO.Mensaje data = (BO.Mensaje)obj;
            bd = new BaseDB();
            sql = "UPDATE mensaje " +
                  "SET texto=@texto," +
                  "fecha=@fecha," +
                  "estado=@estado," +
                  "id_user_creador=@id_user_creador," +
                  "id_conversacion=@id_conversacion" +

                  " WHERE id_mensaje=@id_mensaje";
            bd.Cmd.Parameters.AddWithValue("@id_mensaje", data.Id_mensaje);
            bd.Cmd.Parameters.AddWithValue("@texto", data.Tecto);
            bd.Cmd.Parameters.AddWithValue("@fecha", data.Fecha);
            bd.Cmd.Parameters.AddWithValue("@estado", data.Estado);
            bd.Cmd.Parameters.AddWithValue("@id_user_creador", data.Id_usuario);
            bd.Cmd.Parameters.AddWithValue("@id_conversacion", data.Id_conversacion);


            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }

    }
}