using Sheenam.Models.Foundations.Homes;

namespace Sheenam.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Home> InsertHomeAsync(Home home);
        Task<List<Home>> SelectAllHomesAsync();
        ValueTask<Home> SelectHomeByIdAsync(Guid id);
        ValueTask<Home> UpdateHomeAsync(Home home);
        ValueTask<Home> DeleteHomeAsync(Home home);
    }
}