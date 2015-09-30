namespace Entities.User.Address
{
    public class Country : BaseEntity
    {
        public string IsoCountryId { get; set; }
        public string Name { get; set; }
        public int Vat { get; set; }
    }
}