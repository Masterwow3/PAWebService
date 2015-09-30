using System.Runtime.Serialization;

namespace Entities.Organizer
{
    [DataContract]
    public class Organizer
    {
        [DataMember]
        public virtual uint UserId { get; set; }
        [DataMember]
        public virtual bool Disabled { get; set; }
    }
}