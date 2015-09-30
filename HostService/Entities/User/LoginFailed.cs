using System;
using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class LoginFailed
    {
        public uint UserId { get; set; }
        public DateTime FailedLoginDate { get; set; }
    }
}