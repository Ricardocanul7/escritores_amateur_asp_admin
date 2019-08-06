using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.DAO
{
    public class BaseDB
    {
        private SqlConnection cnn;
        private SqlDataReader dr;
        private string stringConexion;
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da;

        public SqlConnection Cnn { get => cnn; set => cnn = value; }
        public SqlDataReader Dr { get => dr; set => dr = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlDataAdapter Da { get => da; set => da = value; }

        public BaseDB()
        {
            establecerConexion();
        }

        private void establecerConexion()
        {
            stringConexion = "Data source = Alan\\SQLEXPRESS; initial catalog = db_escritores_amateur; integrated security=true;";
            Cnn = new SqlConnection(stringConexion);
        }

        public void abrirConexion()
        {
            Cnn.Open();
        }

        public void cerrarConexion()
        {
            Cnn.Close();
        }

        public SqlDataAdapter execQuery(string query)
        {
            Da = new SqlDataAdapter();
            if(Cnn.State != System.Data.ConnectionState.Open)
            {
                abrirConexion();
                Cmd.Connection = Cnn;
                Cmd.CommandText = query;
                Cmd.ExecuteReader();
                Da.SelectCommand = Cmd;
                cerrarConexion();
                return Da;
            }
            else
            {
                cerrarConexion();
                Da = null;
                return Da;
            }
        }

        public int execNonQuery(string query)
        {   
            Da = new SqlDataAdapter();
            if(Cnn.State != System.Data.ConnectionState.Open)
            {
                abrirConexion();
                //Cmd = new SqlCommand(query, Cnn);
                Cmd.Connection = Cnn;
                Cmd.CommandText = query;
                //Dr = Cmd.ExecuteReader();
                int i = cmd.ExecuteNonQuery();
                cerrarConexion();
                if (i == 0)
                    return 0;
                else
                    return 1;
            }
            else
            {
                cerrarConexion();
                return 1;
            }
        }
    }
}