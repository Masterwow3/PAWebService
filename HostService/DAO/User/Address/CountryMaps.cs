using Entities.User.Address;

namespace DAO.User.Address
{
    public class CountryMaps :BaseMaps<Country>
    {
        public CountryMaps()
        {
            Map(x => x.PhoneCountryPräfix).Column("phoneCountryPräfix");
            Map(x => x.IsoCountryId).Column("isoCountryId");
            Map(x => x.Name).Column("name");
            Map(x => x.Vat).Column("vat");
        }
    }
}