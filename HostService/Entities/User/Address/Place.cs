using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Place : BaseEntity
    {
        public uint CountryId { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
    }
}