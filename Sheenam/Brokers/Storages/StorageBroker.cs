using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace Sheenam.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext
    {
        public StorageBroker()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data source = Sheenam.db";
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseSqlite(connectionString);
        }

        public override void Dispose() { }
    }
}
