using System;

namespace Entities.User
{
    public class NotValidatedUser : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredDate{ get; set; }
        public string EmailVerificationCode { get; set; }
        public uint CountryId { get; set; }
    }
}