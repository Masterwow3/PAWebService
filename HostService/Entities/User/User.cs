using System;
using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
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