using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace DAO
{
    public class Class1
    {
        ISessionFactory sessionFactory = Fluently.Configure()
  .Database(SQLiteConfiguration.Standard.InMemory)
  .Mappings(m =>
    m.FluentMappings
      .AddFromAssemblyOf<YourEntity>())
  .BuildSessionFactory();
    }
}
