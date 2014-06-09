using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Architecs.PagosService.Persistencia
{
    public static class Utilitario
    {
        public static string CadenaConeccion()
        {
            //return "workstation id=CondominiosDB.mssql.somee.com;packet size=4096;user id=condominio_SQLLogin_1;pwd=ipne14kk3k;data source=CondominiosDB.mssql.somee.com;persist security info=False;initial catalog=CondominiosDB";
            //"Data Source = DESARROLLO\\SQLSERVER2008_R2; Initial Catalog = CondominiosDB; Integrated Security = True";
            string cadenaConexion = ConfigurationManager.ConnectionStrings["CnxDBPagos"].ToString(); 
            return cadenaConexion;
        }
    }
}
