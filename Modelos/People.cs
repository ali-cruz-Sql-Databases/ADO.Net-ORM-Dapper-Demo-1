using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADO.Net_Demo_AccesoDatosSql.Modelos
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName 
        {
            get
            {
                return $"{FirstName}{LastName}";
            }        
        }


    }
}
