using System.Runtime.Serialization;

namespace Entities
{
    [DataContract]
    public class BaseEntity
    {
        [DataMember]
        public virtual uint Id { get; set; }
    }
}