// -----------------------------------------------------------------------
// <copyright file="IAuthService.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RadiantRFID.RaaS.Tools.Security
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IAuthService
    {
        bool ValidateUser(string userName, string password);

        void LogonUser(string userName);

        void LogoutUser();
    }
}
