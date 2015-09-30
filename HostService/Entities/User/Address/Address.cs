using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Address : BaseEntity
    {
        [DataMember]
        public uint UserId { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string HouseNumber { get; set; }
        [DataMember]
        public uint PlaceId { get; set; }
        [DataMember]
        public uint CountryId { get; set; }

    }
}