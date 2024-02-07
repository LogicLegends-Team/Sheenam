using Sheenam.Models.Foundations.Homes;
using Sheenam.Services.Foundations.Homes;

namespace Sheenam.Services.Processings.Homes
{
    public class HomeProcessingService : IHomeProcessingService
    {
        private readonly IHomeService homeService;

        public HomeProcessingService(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        public async ValueTask<Home> AddHomeAsync(Home home) =>
            await this.homeService.AddHomeAsync(home);

        public IQueryable<Home> RetrieveAllHomes() =>
            this.homeService.RetrieveAllHomes();

        public async ValueTask<Home> RetrieveHomeByIdAsync(Guid id) =>
            await this.homeService.RetrieveHomeByIdAsync(id);

        public async ValueTask<Home> ModifyHomeAsync(Home home) =>
            await this.homeService.ModifyHomeAsync(home);

        public async ValueTask<Home> RemoveHomeByIdAsync(Guid id)
        {
            var home =
                await this.homeService.RetrieveHomeByIdAsync(id);

            return await this.homeService.RemoveHomeAsync(home);
        }
    }
}
