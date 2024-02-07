﻿using Sheenam.Models.Foundations.Users;
using Sheenam.Services.Foundations.Users;

namespace Sheenam.Services.Processings.Users
{
    public class UserProcessingService : IUserProcessingService
    {
        private readonly IUserService userService;

        public UserProcessingService(IUserService userService)
        {
            this.userService = userService;
        }

        public async ValueTask<User> AddUserAsync(User user) =>
            await this.userService.AddUserAsync(user);

        public IQueryable<User> RetrieveAllUsers() =>
            this.userService.RetrieveAllUsers();

        public async ValueTask<User> RetrieveUserByIdAsync(Guid id) =>
            await this.userService.RetrieveUserByIdAsync(id);

        public async ValueTask<User> ModifyUserAsync(User user) =>
            await this.userService.ModifyUserAsync(user);

        public async ValueTask<User> RemoveUserByIdAsync(Guid id)
        {
            var mayBeUser =
                await this.userService.RetrieveUserByIdAsync(id);

            return await this.userService.RemoveUserAsync(mayBeUser);
        }
    }
}