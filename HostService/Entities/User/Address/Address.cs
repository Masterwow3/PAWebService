namespace Entities.User.Address
{
    public class Address : BaseEntity
    {
        public uint UserId { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public uint PlaceId { get; set; }
        public uint CountryId { get; set; }

    }
}