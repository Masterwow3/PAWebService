using System;
using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class User : BaseEntity
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public DateTime LastLogin { get; set; }
        [DataMember]
        public int CountryId { get; set; }
    }
}