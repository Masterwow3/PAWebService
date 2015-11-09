using Entities.User;

namespace DAO.User
{
    public class PhoneNumberMaps : BaseMaps<PhoneNumber>
    {
        public PhoneNumberMaps()
        {
            Map(x => x.UserId).Column("user_id");
            Map(x => x.CountryPräfix).Column("countryPräfix");
            Map(x => x.Präfix).Column("präfix");
            Map(x => x.Number).Column("number");
            Map(x => x.IsLandline).Column("isLandline");
            Map(x => x.IsMobil).Column("isMobil");
        }
    }
}