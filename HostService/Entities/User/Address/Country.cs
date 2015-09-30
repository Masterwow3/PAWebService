using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Country : BaseEntity
    {
        public string IsoCountryId { get; set; }
        public string Name { get; set; }
        public int Vat { get; set; }
    }
}