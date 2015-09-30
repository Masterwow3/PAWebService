using System.Runtime.Serialization;

namespace Entities.Organizer
{
    [DataContract]
    public class Organizer
    {
        [DataMember]
        public uint UserId { get; set; }
        [DataMember]
        public bool Disabled { get; set; }
    }
}