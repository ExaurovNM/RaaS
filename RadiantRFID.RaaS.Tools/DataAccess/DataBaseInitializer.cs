// -----------------------------------------------------------------------
// <copyright file="DataBaseInitializer.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RadiantRFID.RaaS.Tools.DataAccess
{
    using System.Data.Entity;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DataBaseInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            base.Seed(context);

            context.SaveChanges();
        }
    }
}
