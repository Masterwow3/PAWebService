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
            Map(x => x.Disabled).Column("disabled");
            References(x => x.UserKind).Column("userKindNumber");
        }
    }
}