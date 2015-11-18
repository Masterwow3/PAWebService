using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class UserToUserKind
    {
        [DataMember]
        public virtual uint UserId { get; set; }
        [DataMember]
        public virtual UserKinds UserKind { get; set; }
        [DataMember]
        public virtual bool Disabled { get; set; }
    }
}