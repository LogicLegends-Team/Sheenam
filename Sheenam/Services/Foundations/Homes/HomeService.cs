using Sheenam.Brokers.Storages;
using Sheenam.Models.Foundations.Homes;

namespace Sheenam.Services.Foundations.Homes
{
    public class HomeService : IHomeService
    {
        private readonly IStorageBroker storageBroker;

        public HomeService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<Home> AddHomeAsync(Home home) =>
            await this.storageBroker.InsertHomeAsync(home);

        public async Task<List<Home>> RetrieveAllHomesAsync() =>
            await this.storageBroker.SelectAllHomesAsync();

        public async ValueTask<Home> RetrieveHomeByIdAsync(Guid id) =>
            await this.storageBroker.SelectHomeByIdAsync(id);

        public async ValueTask<Home> ModifyHomeAsync(Home home) =>
            await this.storageBroker.UpdateHomeAsync(home);

        public async ValueTask<Home> RemoveHomeAsync(Home home) =>
            await this.storageBroker.DeleteHomeAsync(home);
    }
}