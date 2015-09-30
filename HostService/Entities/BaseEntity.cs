using System.Runtime.Serialization;

namespace Entities
{
    [DataContract]
    public class BaseEntity
    {
        [DataMember]
        public uint Id { get; set; }
    }
}