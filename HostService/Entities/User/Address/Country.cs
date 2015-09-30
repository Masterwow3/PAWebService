using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Country : BaseEntity
    {
        [DataMember]
        public string IsoCountryId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Vat { get; set; }
    }
}