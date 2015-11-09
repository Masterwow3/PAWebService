namespace DAO.User.Address
{
    public class AddressMaps : BaseMaps<Entities.User.Address.Address>
    {
        public AddressMaps()
        {
            Map(x => x.UserId).Column("user_id");
            Map(x => x.Street).Column("street");
            Map(x => x.HouseNumber).Column("houseNumber");
            Map(x => x.PlaceId).Column("place_id");
            Map(x => x.CountryId).Column("country_id");
        }
    }
}