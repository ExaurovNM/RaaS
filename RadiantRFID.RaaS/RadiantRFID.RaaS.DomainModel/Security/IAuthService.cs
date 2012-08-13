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

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IAuthService
    {
        bool ValidateUser(string userName, string password);

        void Logon(string user, bool remeber);

        void Logout();
    }
}
