﻿using Sheenam.Models.Foundations.Users;

namespace Sheenam.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user);
        IQueryable<User> SelectAllUsers();
    }
}