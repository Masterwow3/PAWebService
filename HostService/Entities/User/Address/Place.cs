using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Place : BaseEntity
    {
        [DataMember]
        public uint CountryId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ZipCode { get; set; }
    }
}