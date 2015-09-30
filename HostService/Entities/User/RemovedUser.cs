using System;
using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class RemovedUser
    {
        [DataMember]
        public uint UserId { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string UserSurname { get; set; }
        [DataMember]
        public string UserEmail { get; set; }
        [DataMember]
        public int PhotografFeedbackScore { get; set; }
        [DataMember]
        public DateTime RemovedDate { get; set; }
    }
}