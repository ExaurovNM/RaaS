// -----------------------------------------------------------------------
// <copyright file="IAuthService.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RadiantRFID.RaaS.DomainModel.Security
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Security;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IAuthService
    {
        bool ValidateUser(string userName, string password);

        void Logon(string user, bool remeber);

        void Logout();
    }

    public class AuthService : IAuthService
    {


        public bool ValidateUser(string userName, string password)
        {
            if (userName == "test" && password == "password")
            {
                return true;
            }
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
