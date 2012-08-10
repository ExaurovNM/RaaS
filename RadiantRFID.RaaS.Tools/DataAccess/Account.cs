// -----------------------------------------------------------------------
// <copyright file="Account.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RadiantRFID.RaaS.Tools.DataAccess
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Account
    {
        [Key]
        public Guid Id { get; set; }

        public string AccountName { get; set; }

        public string Password { get; set; }
    }
}
