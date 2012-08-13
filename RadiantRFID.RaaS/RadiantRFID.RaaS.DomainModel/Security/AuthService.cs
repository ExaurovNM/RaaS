namespace RadiantRFID.RaaS.DomainModel.Security
{
    using System.Web.Security;

    public class AuthService : IAuthService
    {


        public bool ValidateUser(string userName, string password)
        {
            if (userName == "test" && password == "password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Logon(string userName, bool remember)
        {
            FormsAuthentication.SetAuthCookie(userName, remember);
        }

        public void Logout()
        {
            FormsAuthentication.SignOut();
        }
    }
}