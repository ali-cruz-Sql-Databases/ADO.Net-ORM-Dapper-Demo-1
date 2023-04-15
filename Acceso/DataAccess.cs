using ADO.Net_Demo_AccesoDatosSql.General;
using ADO.Net_Demo_AccesoDatosSql.Modelos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ADO.Net_Demo_AccesoDatosSql.Acceso
{
    public class DataAccess
    {

        public List<People> GetPeople(string emailAddress)
        {
            using (IDbConnection conn = new SqlConnection(Helper.GetConnString("SamplesLocalHost")))
            {
                var output = conn
                                //.Query<People>("[dbo].[spSelectAllPeople] @null", 
                                .Query<People>("[dbo].[spSelectAllPeople]",
                                    new People
                                    { 
                                        EmailAddress = emailAddress 
                                    })
                                .ToList();
                return output;
            }

        }
    }
}
