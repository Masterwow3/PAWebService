using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Entities;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;

namespace DAO
{
    public abstract class BaseMaps<T>: ClassMap<T> where T: BaseEntity
    {
        public BaseMaps()
        {
            Id(x => x.Id).Column("id");
        }
    }
}