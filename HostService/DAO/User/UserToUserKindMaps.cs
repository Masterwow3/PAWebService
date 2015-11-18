using Entities.User;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;

namespace DAO.User
{
    public class UserToUserKindMaps : ClassMap<UserToUserKind>
    {
        public UserToUserKindMaps()
        {
            Table("UserToUserKind");
            Id(x => x.UserId).Column("user_id");
            Map(x => x.Disabled).Column("disabled");
            Id(x => x.UserKind)
                .CustomType<int>()
                .Column("userKindNumber");
        }
    }
}