using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.User;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Driver;
using NHibernate.Linq;
using WebService.Global;

namespace DAO
{
    public class Main
    {
        public static IResult<ISessionFactory> CreateSessionFactory()
        {
            var dbServer = "localhost";
            var dbUsername = "root";
            var dbName = "projectalpha";
            var dbPassword = "";
            var connectionString = $"Server={dbServer};Database={dbName};User ID={dbUsername};Allow Zero Datetime=true;Password={dbPassword};";
            try
            {
                var session = Fluently.Configure()
                    .Database(MySQLConfiguration.Standard
                        .ConnectionString(connectionString))
                    .Mappings(m =>
                        m.FluentMappings
                            .AddFromAssemblyOf<UserMaps>())
                    .BuildSessionFactory();
                return new IResult<ISessionFactory>(session);
            }
            catch (Exception ex)
            {
                return new IResult<ISessionFactory>(null,ResultState.Error,ex.Message,ex);
            }
        }

        public static bool TestConnection()
        {
            var connection = CreateSessionFactory();
            bool canConnect = connection.Result == ResultState.Success;
            return canConnect;
        }

        public static void Test()
        {
            using (var session = DAO.Main.CreateSessionFactory().Data.OpenSession())
            {
                var test = session.Query<Entities.User.User>().ToList();
            }
        }
    }
}
