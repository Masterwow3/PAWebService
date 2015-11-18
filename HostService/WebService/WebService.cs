using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.User;
using Microsoft.Win32;


namespace WebService
{
    public class WebService
    {
        static void Main()
        {


            var connect = DAO.Main.TestConnection();
        }
        public void StartWebService()
        {

        }

        public void StopWebService()
        {

        }
    }
}
