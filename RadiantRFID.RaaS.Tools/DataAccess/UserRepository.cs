namespace RadiantRFID.RaaS.Tools.DataAccess
{
    using System.Collections.Generic;
    using System.Linq;

    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// The data base context.
        /// </summary>
        private readonly DataBaseContext dataBaseContext;

        public UserRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public ICollection<Account> GetItems()
        {
            return this.dataBaseContext.Accounts.ToList();
        }
    }
}