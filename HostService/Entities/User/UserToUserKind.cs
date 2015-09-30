using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class UserToUserKind
    {
        public uint UserId { get; set; }
        public UserKind UserKind { get; set; }
        public bool Disabled { get; set; }
    }
}