// -----------------------------------------------------------------------
// <copyright file="DataBaseContext.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RadiantRFID.RaaS.Tools.DataAccess
{
    using System.Data.Entity;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DataBaseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; } 
    }
}
