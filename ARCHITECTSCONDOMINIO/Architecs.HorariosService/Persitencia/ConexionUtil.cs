using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Architecs.HorariosService.Persitencia
{
    public class ConexionUtil
    {
        public static string CadenaConeccion()
         
        {
            return "workstation id=CondominiosDB.mssql.somee.com;packet size=4096;user id=julioanyosa_SQLLogin_1;pwd=spnnkydfl1;data source=CondominiosDB.mssql.somee.com;persist security info=False;initial catalog=CondominiosDB";
        }
        
    }
}