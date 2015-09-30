using System;

namespace Entities.User
{
    public class LoginFailed
    {
        public uint UserId { get; set; }
        public DateTime FailedLoginDate { get; set; }
    }
}