using System;
using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class LoginFailed
    {
        [DataMember]
        public uint UserId { get; set; }
        [DataMember]
        public DateTime FailedLoginDate { get; set; }
    }
}