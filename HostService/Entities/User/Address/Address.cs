using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Address : BaseEntity
    {
        [DataMember]
        public virtual uint UserId { get; set; }
        [DataMember]
        public virtual string Street { get; set; }
        [DataMember]
        public virtual string HouseNumber { get; set; }
        [DataMember]
        public virtual uint PlaceId { get; set; }
        [DataMember]
        public virtual uint CountryId { get; set; }

    }
}