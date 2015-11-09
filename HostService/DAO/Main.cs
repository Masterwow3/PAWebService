using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.User;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace DAO
{
    public class Main
    {
        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
              .Database(MySQLConfiguration.Standard)
              .Mappings(m =>
                m.FluentMappings
                  .AddFromAssemblyOf<UserMaps>())
              .BuildSessionFactory();
        }
    }
}
