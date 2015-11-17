using Entities.User;
using FluentNHibernate.Mapping;

namespace DAO.User
{
    public class NotValidatedUserMaps : ClassMap<NotValidatedUser>
    {
        public NotValidatedUserMaps()
        {
            Table("NotValidatedUser");
            Id(x => x.Email).Column("email");
            Map(x => x.Name).Column("name");
            Map(x => x.Surname).Column("surname");
            Map(x => x.Username).Column("username")
                .Unique();
            Map(x => x.RegisteredDate).Column("registeredDate");
            Map(x => x.EmailVerificationCode).Column("emailVerificationCode");
            Map(x => x.CountryId).Column("country_id");
        }
    }
}