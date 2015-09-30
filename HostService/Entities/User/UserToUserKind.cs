using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class UserToUserKind
    {
        [DataMember]
        public uint UserId { get; set; }
        [DataMember]
        public UserKind UserKind { get; set; }
        [DataMember]
        public bool Disabled { get; set; }
    }
}