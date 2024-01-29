using Sheenam.Models.Foundations.Users;

namespace Sheenam.Services.Orchestrations.Users
{
    public interface IUserOrchestrationService
    {
        ValueTask<User> AddUserAsync(User user);
        IQueryable<User> RetrieveAllUsers();
        ValueTask<User> RetrieveUserByIdAsync(Guid id);
        ValueTask<User> ModifyUserAsync(User user);
        ValueTask<User> RemoveUserAsync(Guid id);
    }
}