using System.Runtime.Serialization;

namespace Entities.User.Address
{
    [DataContract]
    public class Country : BaseEntity
    {
        [DataMember]
        public virtual string PhoneCountryPräfix { get; set; }
        [DataMember]
        public virtual string IsoCountryId { get; set; }
        [DataMember]
        public virtual string Name { get; set; }
        [DataMember]
        public virtual int Vat { get; set; }
    }
}