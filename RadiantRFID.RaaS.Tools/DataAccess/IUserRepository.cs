// -----------------------------------------------------------------------
// <copyright file="IUserRepository.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RadiantRFID.RaaS.Tools.DataAccess
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IUserRepository
    {
        ICollection<Account> GetItems();

        void CreateItem(Account account);

        Account GetItem(Guid Id);
    }
}
