namespace Entities.User
{
    public class UserToUserKind
    {
        public uint UserId { get; set; }
        public UserKind UserKind { get; set; }
        public bool Disabled { get; set; }
    }
}