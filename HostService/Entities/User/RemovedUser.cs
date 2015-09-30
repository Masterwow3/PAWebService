using System;
using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class RemovedUser
    {
        [DataMember]
        public virtual uint UserId { get; set; }
        [DataMember]
        public virtual string UserName { get; set; }
        [DataMember]
        public virtual string UserSurname { get; set; }
        [DataMember]
        public virtual string UserEmail { get; set; }
        [DataMember]
        public virtual int PhotografFeedbackScore { get; set; }
        [DataMember]
        public virtual DateTime RemovedDate { get; set; }
    }
}