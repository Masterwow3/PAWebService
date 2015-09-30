using System;

namespace Entities.User
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
        public int CountryId { get; set; }
    }
}