namespace RadiantRFID.RaaS.Tools.Common
{
    using System.Web;

    using RadiantRFID.RaaS.Tools.DataAccess;

    public class ContextProvider : IContextProvider
    {
        private readonly ISession session;
        private readonly IRandomToken randomToken;

        private const string ParamName = "User";

        public ContextProvider(ISession session, IRandomToken randomToken)
        {
            this.session = session;
            this.randomToken = randomToken;
        }

        public void SaveUserToSession(UserSession userSession)
        {
            var token = this.randomToken.GetRandomToken();
            this.session.Add(token, userSession);
            HttpContext.Current.Response.Cookies.Add(new HttpCookie(ParamName, token) { HttpOnly = true });
        }

        public UserSession GetUserFromSession()
        {
            var token = HttpContext.Current.Request[ParamName];

            return null == token ? null : this.session.Get<UserSession>(token);
        }
    }
}