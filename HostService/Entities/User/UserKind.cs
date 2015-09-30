using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class UserKind : BaseEntity
    {
        public string Name { get; set; }
    }
}