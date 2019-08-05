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
        
        public DataTable recuperaHistoria()
        {
            BO.Historia data = new BO.Historia();
            bd = new BaseDB();

            sql = " SELECT * FROM VISTA_HISTORIA";

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;

        }

        public DataTable GetStoriesByAuthor(string id_autor)
        {
            bd = new BaseDB();

            sql = "DEVOLVER_HISTORIA";
            bd.Cmd.CommandType = CommandType.StoredProcedure;

            bd.Cmd.Parameters.AddWithValue("@id_autor", id_autor);

            DataTable dt = new DataTable();
            bd.execQuery(sql).Fill(dt);
            return dt;
        }

        public int AgregarHistoriaSP(int id_autor, string titulo, string portada_url, string sinopsis, string prologo, int id_categoria)
        {
            bd = new BaseDB();

            sql = "SP_INSERTAR_HISTORIA";
            bd.Cmd.CommandType = CommandType.StoredProcedure;

            bd.Cmd.Parameters.AddWithValue("@id_autor", id_autor);
            bd.Cmd.Parameters.AddWithValue("@titulo", titulo);
            bd.Cmd.Parameters.AddWithValue("@portada_url", portada_url);
            bd.Cmd.Parameters.AddWithValue("@sinopsis", sinopsis);
            bd.Cmd.Parameters.AddWithValue("@prologo", prologo);
            bd.Cmd.Parameters.AddWithValue("@id_categoria", id_categoria);

            int i = bd.execNonQuery(sql);
            if (i == 0)
                return 0;
            else
                return 1;
        }
    }
}