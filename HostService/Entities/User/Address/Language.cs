using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Language
    {
        [DataMember]
        public virtual string Key { get; set; }
        [DataMember]
        public virtual string Text { get; set; }
        [DataMember]
        public virtual uint CountryId { get; set; }
    }
}