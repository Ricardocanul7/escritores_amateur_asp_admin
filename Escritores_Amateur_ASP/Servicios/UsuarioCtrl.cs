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
        public string creaUsuario(object obj)
        {
            int i = objDAO.creaUsuario(obj);
            if (i == 1)
            {
                return "La operación se realizó de manera correcta";
            }
            return "La operación no pudo realizarce con éxito";
        }
        public string actualizaObj(object obj)
        {
            int i = objDAO.actualizaUsuario(obj);
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