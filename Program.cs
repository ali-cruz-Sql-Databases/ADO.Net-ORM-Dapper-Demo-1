using ADO.Net_Demo_AccesoDatosSql.Acceso;
using ADO.Net_Demo_AccesoDatosSql.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADO.Net_Demo_AccesoDatosSql
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peopleList = new List<People>();

            // Llamar data
            DataAccess db = new DataAccess();
            peopleList = db.GetPeople("email.com");

            PrintData(peopleList);

            Console.ReadLine();

        }

        private static void PrintData(List<People> peopleList)
        {
            Console.WriteLine("\tC1\t\tC2\t\tC3\t\tC4\t\tC5");

            foreach (People people in peopleList)
            {
                Console.WriteLine($"\t[{people.FirstName}] \t\t[{people.LastName}]\t\t [{people.EmailAddress}]\t\t [{people.PhoneNumber}]");
            }
        }


    }
}
