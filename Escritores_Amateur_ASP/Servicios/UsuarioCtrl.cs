using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.Servicios
{
    public class UsuarioCtrl
    {
        DAO.Usuario objDAO;

        public UsuarioCtrl()
        {
            objDAO = new DAO.Usuario();
        }

        public DataTable devuelveObj(object obj)
        {
            DataTable dt = new DataTable();
            dt = objDAO.devuelveDatos(obj);
            return dt;
        }
    }
}