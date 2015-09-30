using System;
using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class NotValidatedUser : BaseEntity
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
        public DateTime RegisteredDate{ get; set; }
        [DataMember]
        public string EmailVerificationCode { get; set; }
        [DataMember]
        public uint CountryId { get; set; }
    }
}