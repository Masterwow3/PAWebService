using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class PhoneNumber : BaseEntity
    {
        [DataMember]
        public uint UserId { get; set; }
        [DataMember]
        public uint Präfix { get; set; }
        [DataMember]
        public int CountryPräfix { get; set; }
        [DataMember]
        public uint Number { get; set; }
        [DataMember]
        public bool IsLandline { get; set; }
        [DataMember]
        public bool IsMobil { get; set; }
    }
}