using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class PhoneNumber : BaseEntity
    {
        [DataMember]
        public virtual uint UserId { get; set; }
        [DataMember]
        public virtual uint Präfix { get; set; }
        [DataMember]
        public virtual int CountryPräfix { get; set; }
        [DataMember]
        public virtual uint Number { get; set; }
        [DataMember]
        public virtual bool IsLandline { get; set; }
        [DataMember]
        public virtual bool IsMobil { get; set; }
    }
}