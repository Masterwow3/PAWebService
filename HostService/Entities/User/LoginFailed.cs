﻿using System;
using System.Runtime.Serialization;

namespace Entities.User
{
    [DataContract]
    public class LoginFailed : BaseEntity
    {
        [DataMember]
        public virtual uint UserId { get; set; }
        [DataMember]
        public virtual DateTime FailedLoginDate { get; set; }
    }
}