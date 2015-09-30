using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Language
    {
        public string Key { get; set; }
        public string Text { get; set; }
        public uint CountryId { get; set; }
    }
}