using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ADO.Net_Demo_AccesoDatosSql.General
{
    public static class Helper
    {
        public static string GetConnString(string connString)
        {
            return ConfigurationManager.ConnectionStrings[connString].ConnectionString;
        }       
        
    }
}
