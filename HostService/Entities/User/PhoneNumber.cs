namespace Entities.User
{
    public class PhoneNumber : BaseEntity
    {
        public uint UserId { get; set; }
        public uint Präfix { get; set; }
        public int CountryPräfix { get; set; }
        public uint Number { get; set; }
        public bool IsLandline { get; set; }
        public bool IsMobil { get; set; }
    }
}