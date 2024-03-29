﻿using Sheenam.Models.Foundations.Homes;

namespace Sheenam.Services.Orchestrations.Homes
{
    public interface IHomeOrchestrationService
    {
        ValueTask<Home> AddHomeAsync(Home home);
        Task<List<Home>> RetrieveAllHomesAsync();
        ValueTask<Home> RetrieveHomeByIdAsync(Guid id);
        ValueTask<Home> ModifyHomeAsync(Home home);
        ValueTask<Home> RemoveHomeAsync(Guid id);
    }
}
