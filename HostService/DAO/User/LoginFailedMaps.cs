using Entities.User;

namespace DAO.User
{
    public class LoginFailedMaps : BaseMaps<LoginFailed>
    {
        public LoginFailedMaps()
        {
            Map(x => x.UserId).Column("user_id");
            Map(x => x.FailedLoginDate).Column("failedLoginDate");
        }
    }
}