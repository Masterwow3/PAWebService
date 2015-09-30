using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Place : BaseEntity
    {
        [DataMember]
        public virtual uint CountryId { get; set; }
        [DataMember]
        public virtual string Name { get; set; }
        [DataMember]
        public virtual string ZipCode { get; set; }
    }
}