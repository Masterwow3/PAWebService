using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Entities.User;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using Microsoft.Win32;


namespace WebService
{
    public class WebService
    {
        private static readonly ILog logger =
          LogManager.GetLogger(typeof(WebService));

        public WebService(string url)
        {
            URL = url;
        }

        public void StartWebService()
        {
            //BasicConfigurator.Configure( new PatternLayout("%d [%t] %-5p %c %m%n"), @".\test.txt");
            RestDemoServices DemoServices = new RestDemoServices();
            WebServiceHost _serviceHost = new WebServiceHost(DemoServices, new Uri(URL));
            _serviceHost.Open();


        }

        public void StopWebService()
        {

        }

        #region properties

        public string URL { get; private set; }
        #endregion
    }
}
