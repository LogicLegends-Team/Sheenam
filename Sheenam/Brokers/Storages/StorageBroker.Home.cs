using Microsoft.EntityFrameworkCore;
using Sheenam.Models.Foundations.Homes;

namespace Sheenam.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Home> Homes { get; set; }

        public async ValueTask<Home> InsertHomeAsync(Home home) =>
            await InsertAsync(home);

        public IQueryable<Home> SelectAllHomes() =>
            SelectAll<Home>();

        public async ValueTask<Home> SelectHomeByIdAsync(Guid id) =>
            await SelectAsync<Home>(id);
    }
}