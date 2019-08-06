using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Escritores_Amateur_ASP.Servicios
{
    public class HistoriaCtrl
    {
        DAO.Historia objDAO;

        public HistoriaCtrl()
        {
            objDAO = new DAO.Historia();
        }

        public DataTable devuelveObj(object obj)
        {
            DataTable dt = new DataTable();
            dt = objDAO.devuelveDatos(obj);
            return dt;
        }
        public string creaUsuario(object obj)
        {
            int i = objDAO.AgregarHistoriaSP(obj);
            if (i == 1)
            {
                return "La operación se realizó de manera correcta";
            }
            return "La operación no pudo realizarce con éxito";
        }
        public string actualizaObj(object obj)
        {
            int i = objDAO.actualizaUsu(obj);
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