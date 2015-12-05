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
    public class DAOConnection
    {
        public DAOConnection(string sqlServer, string dbUsername, string dbPassword, string dbName)
        {
            this.SQLServer = sqlServer;
            this.DBName = dbName;
            this.DBUsername = dbUsername;
            this.DBPassword = dbPassword;
        }
        public IResult<ISessionFactory> CreateSessionFactory()
        {
            var connectionString = $"Server={SQLServer};Database={DBName};User ID={DBUsername};Password={DBPassword};";
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
                return new IResult<ISessionFactory>(null, ResultState.Error, ex.Message, ex);
            }
        }

        public bool TestConnection()
        {
            var connection = CreateSessionFactory();
            bool canConnect = connection.Result == ResultState.Success;
            return canConnect;
        }

        public void Test()
        {
            using (var session = CreateSessionFactory().Data.OpenSession())
            {
                var test = session.Query<Entities.User.User>().ToList();
            }
        }

        #region Properties

        public string SQLServer { get;private set; }
        public string DBUsername { get; private set; }
        public string DBName { get; private set; }
        public string DBPassword { get; private set; }
        #endregion
    }
}
