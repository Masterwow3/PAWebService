using Entities.User.Address;

namespace DAO.User.Address
{
    public class PlaceMaps : BaseMaps<Place>
    {
        public PlaceMaps()
        {
            Table("Place");
            Map(x => x.CountryId).Column("country_id");
            Map(x => x.Name).Column("name");
            Map(x => x.ZipCode).Column("zipCode");
        }
    }
}