using Sheenam.Models.Foundations.Users;

namespace Sheenam.Services.Foundations.Users
{
    public interface IUserService
    {
        ValueTask<User> AddUserAsync(User user);
        IQueryable<User> RetrieveAllUsers();
        ValueTask<User> RetrieveUserByIdAsync(Guid id);
        ValueTask<User> ModifyUserAsync(User user);
        ValueTask<User> RemoveUserAsync(User user);
    }
}
