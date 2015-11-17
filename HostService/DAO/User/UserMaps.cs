using System.Security.Cryptography.X509Certificates;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;

namespace DAO.User
{
    public class UserMaps : BaseMaps<Entities.User.User>
    {
        public UserMaps()
        {
            Table("User");
            Map(x => x.Name).Column("name");
            Map(x => x.Surname).Column("surname");
            Map(x => x.Username).Column("username")
                .Unique();
            Map(x => x.Email).Column("email")
                .Unique();
            Map(x => x.LastLogin).Column("lastLogin");
            Map(x => x.CountryId).Column("country_id");
            HasMany(x => x.UserKinds)
                .KeyColumn("id")
                .Cascade.DeleteOrphan();
        }
    }
}