using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Architecs.QuejasService.Dominio
{
    public class ConexionUtil
    {
        public static string CadenaConeccion()
        {
            return "workstation id=CondominiosDB.mssql.somee.com;packet size=4096;user id=condominio_SQLLogin_1;pwd=ipne14kk3k;data source=CondominiosDB.mssql.somee.com;persist security info=False;initial catalog=CondominiosDB";
            //return "workstation id=CondominiosDB.mssql.somee.com;packet size=4096;user id=julioanyosa_SQLLogin_1;pwd=spnnkydfl1;data source=CondominiosDB.mssql.somee.com;persist security info=False;initial catalog=CondominiosDB";
            //return "Data Source = DESARROLLO\\SQLSERVER2008_R2; Initial Catalog = CondominiosDB; Integrated Security = True";
        }
    }
}