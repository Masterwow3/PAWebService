using Entities.User;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;

namespace DAO.User
{
    public class UserToUserKindMaps : ClassMap<UserToUserKind>
    {
        public UserToUserKindMaps()
        {
            Map(x => x.Disabled).Column("disabled");
            References(x => x.UserKind).Column("userKind_id");
        }
    }
}