using System;
using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class User : BaseEntity
    {
        [DataMember]
        public virtual string Name { get; set; }
        [DataMember]
        public virtual string Surname { get; set; }
        [DataMember]
        public virtual string Username { get; set; }
        [DataMember]
        public virtual string Email { get; set; }
        [DataMember]
        public virtual DateTime LastLogin { get; set; }
        [DataMember]
        public virtual int CountryId { get; set; }
    }
}