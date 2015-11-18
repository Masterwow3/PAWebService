using System.Runtime.Serialization;
using Entities.User.Address;

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
        public virtual Country Country { get; set; }
        [DataMember]
        public virtual uint Number { get; set; }
        [DataMember]
        public virtual bool IsLandline { get; set; }
        [DataMember]
        public virtual bool IsMobil { get; set; }
    }
}