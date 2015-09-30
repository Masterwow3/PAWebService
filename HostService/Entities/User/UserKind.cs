using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class UserKind : BaseEntity
    {
        [DataMember]
        public virtual string Name { get; set; }
    }
}