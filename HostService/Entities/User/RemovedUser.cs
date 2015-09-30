using System;

namespace Entities.User
{
    public class RemovedUser
    {
        public uint UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        public int PhotografFeedbackScore { get; set; }
        public DateTime RemovedDate { get; set; }
    }
}