using System;
using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class NotValidatedUser : BaseEntity
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
        public virtual DateTime RegisteredDate{ get; set; }
        [DataMember]
        public virtual string EmailVerificationCode { get; set; }
        [DataMember]
        public virtual uint CountryId { get; set; }
    }
}