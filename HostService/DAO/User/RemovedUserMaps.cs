﻿using Entities.User;
using FluentNHibernate.Mapping;

namespace DAO.User
{
    public class RemovedUserMaps : ClassMap<RemovedUser>
    {
        public RemovedUserMaps()
        {
            Map(x => x.UserId).Column("user_id");
            Map(x => x.UserName).Column("user_name");
            Map(x => x.UserSurname).Column("user_surname");
            Map(x => x.UserEmail).Column("user_email");
            Map(x => x.PhotografFeedbackScore).Column("photograf_feedbackScore");
            Map(x => x.RemovedDate).Column("removedDateTime");
        }
    }
}