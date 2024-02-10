using Microsoft.EntityFrameworkCore;
using Sheenam.Models.Foundations.Homes;

namespace Sheenam.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Home> Homes { get; set; }

        public async ValueTask<Home> InsertHomeAsync(Home home) =>
            await InsertAsync(home);

        public async Task<List<Home>> SelectAllHomesAsync()
        {
            return await this.Homes
                .Include(h => h.ImageMetadata)
                .ToListAsync(); 
        }

        public async ValueTask<Home> SelectHomeByIdAsync(Guid homeId) =>
             await this.Homes.Include(u => u.ImageMetadata)
                    .FirstOrDefaultAsync(u => u.UserId == homeId);

        public async ValueTask<Home> UpdateHomeAsync(Home home) =>
            await UpdateAsync(home);

        public async ValueTask<Home> DeleteHomeAsync(Home home) =>
            await DeleteAsync(home);
    }
}