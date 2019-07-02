using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Escritores_Amateur_ASP.Servicios
{
    public class PrologoCtrl
    {
        DAO.Prologo objDAO;

        public PrologoCtrl()
        {
            objDAO = new DAO.Prologo();
        }

        public DataTable devuelveObj(object obj)
        {
            DataTable dt = new DataTable();
            dt = objDAO.devuelveDatos(obj);
            return dt;
        }
    }
}