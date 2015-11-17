using Entities.User.Address;

namespace DAO.User.Address
{
    public class CountryMaps :BaseMaps<Country>
    {
        public CountryMaps()
        {
            Table("Country");
            Map(x => x.PhoneCountryPräfix).Column("countryPhonePräfix");
            Map(x => x.IsoCountryId).Column("isoCountryId");
            Map(x => x.Name).Column("name");
            Map(x => x.Vat).Column("vat");
        }
    }
}