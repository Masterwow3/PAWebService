using System.Runtime.Serialization;

namespace Entities
{
    [DataContract]
    public abstract class BaseEntity
    {
        [DataMember]
        public virtual uint Id { get; set; }
    }
}