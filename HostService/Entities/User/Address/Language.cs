using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Language
    {
        [DataMember]
        public string Key { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public uint CountryId { get; set; }
    }
}