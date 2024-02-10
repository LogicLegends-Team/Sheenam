using Sheenam.Models.Foundations.Homes;

namespace Sheenam.Services.Processings.Homes
{
    public interface IHomeProcessingService
    {
        ValueTask<Home> AddHomeAsync(Home home);
        Task<List<Home>> RetrieveAllHomesAsync();
        ValueTask<Home> RetrieveHomeByIdAsync(Guid id);
        ValueTask<Home> ModifyHomeAsync(Home home);
        ValueTask<Home> RemoveHomeByIdAsync(Guid id);
    }
}