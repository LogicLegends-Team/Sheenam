using Sheenam.Models.Foundations.Users;
using Sheenam.Services.Processings.Users;

namespace Sheenam.Services.Orchestrations.Users
{
    public class UserOrchestrationService : IUserOrchestrationService
    {
        private readonly IUserProcessingService userProcessingService;

        public UserOrchestrationService(
            IUserProcessingService userProcessingService)
        {
            this.userProcessingService = userProcessingService;
        }

        public async ValueTask<User> AddUserAsync(User user) =>
            await this.userProcessingService.AddUserAsync(user);

        public async ValueTask<User> ModifyUserAsync(User user) =>
            await this.userProcessingService.ModifyUserAsync(user);

        public async ValueTask<User> RemoveUserAsync(Guid id) =>
            await this.userProcessingService.RemoveUserByIdAsync(id);

        public IQueryable<User> RetrieveAllUsers() =>
            this.userProcessingService.RetrieveAllUsers();

        public async ValueTask<User> RetrieveUserByIdAsync(Guid id) =>
            await this.userProcessingService.RetrieveUserByIdAsync(id);
    }
}