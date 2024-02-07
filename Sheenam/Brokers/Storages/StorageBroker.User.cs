using Microsoft.EntityFrameworkCore;
using Sheenam.Models.Foundations.Users;

namespace Sheenam.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }

        public async ValueTask<User> InsertUserAsync(User user) =>
            await InsertAsync(user);

        public IQueryable<User> SelectAllUsers() =>
            SelectAll<User>();

        public async ValueTask<User> SelectUserByIdAsync(Guid userId)
        {
            var user = await this.Users
                .Include(u => u.UserHomes)
                .FirstOrDefaultAsync(u => u.UserId == userId);

            return user;
        }

        public async ValueTask<User> UpdateUserAsync(User user) =>
            await UpdateAsync(user);

        public async ValueTask<User> DeleteUserAsync(User user) =>
            await DeleteAsync(user);
    }
}