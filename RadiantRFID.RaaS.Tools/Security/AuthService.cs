namespace RadiantRFID.RaaS.Tools.Security
{
    using System;
    using System.Linq;
    using System.Web.Security;

    using RadiantRFID.RaaS.Tools.DataAccess;

    public class AuthService : IAuthService
    {
        private readonly IUserRepository userRepository;

        public AuthService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
            if(userRepository == null)
                throw new NotImplementedException();
        }

        public bool ValidateUser(string userName, string password)
        {
            var user = this.userRepository.GetItems().ToList().SingleOrDefault(it => it.AccountName == userName && it.Password == password);
            if(user == null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// The logon user.
        /// </summary>
        /// <param name="userName">
        /// The user name.
        /// </param>
        public void LogonUser(string userName)
        {
            FormsAuthentication.SetAuthCookie(userName, true);
        }

        /// <summary>
        /// The logout user.
        /// </summary>
        public void LogoutUser()
        {
            FormsAuthentication.SignOut();
        }
    }
}