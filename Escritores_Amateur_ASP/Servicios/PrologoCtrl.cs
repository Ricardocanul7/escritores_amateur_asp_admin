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
        public string creaPrologo(object obj)
        {
            int i = objDAO.creaPrologo(obj);
            if (i == 1)
            {
                return "La operación se realizó de manera correcta";
            }
            return "La operación no pudo realizarce con éxito";
        }
        public string actualizaObj(object obj)
        {
            int i = objDAO.actualizaPrologo(obj);
            if (i == 1)
            {
                return "La operación se realizó de manera correcta";
            }
            return "La operación no pudo realizarce con éxito";
        }
        public string eliminaObj(object obj)
        {
            int i = objDAO.eliminaDatos(obj);
            if (i == 1)
            {
                return "La operación se realizó de manera correcta";
            }
            return "La operación no pudo realizarce con éxito";
        }
    }
}