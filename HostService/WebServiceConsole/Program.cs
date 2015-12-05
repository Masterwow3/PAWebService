using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace WebServiceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbServer = "localhost";
            var dbUsername = "root";
            var dbName = "projectalpha";
            var dbPassword = "";
            DAOConnection daoConnection = new DAOConnection(dbServer, dbUsername, dbPassword, dbName);

            Console.WriteLine("Try connect to database");
            while (!daoConnection.TestConnection())
            {
                Console.WriteLine("DB connection failed");
            }
            Console.WriteLine("DB connection was successful");
            string url = "http://localhost:8000/DEMOService";
            WebService.WebService webService = new WebService.WebService(url);
            webService.StartWebService();
            Console.WriteLine("WebService Running");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("URL: " + webService.URL);
            Console.WriteLine("DB Connection ");
            Console.ReadKey();
            webService.StopWebService();
            Console.WriteLine("WebService was stopped");
        }
    }
}
