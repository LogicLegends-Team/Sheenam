using Sheenam.Models.Foundations.Homes;
using Sheenam.Services.Processings.Homes;

namespace Sheenam.Services.Orchestrations.Homes
{
    public class HomeOrchestrationService : IHomeOrchestrationService
    {
        private readonly IHomeProcessingService homeProcessingService;

        public HomeOrchestrationService(
            IHomeProcessingService homeProcessingService)
        {
            this.homeProcessingService = homeProcessingService;
        }

        public async Task<List<Home>> RetrieveAllHomesAsync() =>
            await this.homeProcessingService.RetrieveAllHomesAsync();

        public async ValueTask<Home> RetrieveHomeByIdAsync(Guid id) =>
            await this.homeProcessingService.RetrieveHomeByIdAsync(id);

        public async ValueTask<Home> AddHomeAsync(Home home) =>
            await this.homeProcessingService.AddHomeAsync(home);

        public async ValueTask<Home> ModifyHomeAsync(Home home) =>
            await this.homeProcessingService.ModifyHomeAsync(home);

        public async ValueTask<Home> RemoveHomeAsync(Guid id) =>
            await this.homeProcessingService.RemoveHomeByIdAsync(id);
    }
}
