// -----------------------------------------------------------------------
// <copyright file="IContextProvider.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RadiantRFID.RaaS.Tools.Common
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IContextProvider
    {
        void SetUserToSession(UserSession userSession);

        UserSession GetUserFromSession();
    }
}
