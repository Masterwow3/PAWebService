using System.Runtime.Serialization;

namespace Entities.Organizer
{
    [DataContract]
    public class Organizer
    {
        public uint UserId { get; set; }
        public bool Disabled { get; set; }
    }
}