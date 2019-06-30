using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Escritores_Amateur_ASP.Servicios
{
    public class SinopsisCtrl
    {
        DAO.Sinopsis objDAO;

        public SinopsisCtrl()
        {
            objDAO = new DAO.Sinopsis();
        }

        public DataTable devuelveObj(object obj)
        {
            DataTable dt = new DataTable();
            dt = objDAO.devuelveDatos(obj);
            return dt;
        }
    }
}