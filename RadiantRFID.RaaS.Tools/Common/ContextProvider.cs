namespace RadiantRFID.RaaS.Tools.Common
{
    using System;
    using System.Web;
    using System.Web.SessionState;

    public class ContextProvider : IContextProvider
    {
        private HttpSessionState session;

        public ContextProvider()
        {
            session = HttpContext.Current.Session;
        }

        public void SetUserToSession(UserSession userSession)
        {
            this.session.Add("CurrentUser", userSession);
        }

        public UserSession GetUserFromSession()
        {
            return this.session["CurrentUser"] as UserSession;
        }
    }
}