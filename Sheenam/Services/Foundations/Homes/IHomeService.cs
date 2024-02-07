using Sheenam.Models.Foundations.Homes;

namespace Sheenam.Services.Foundations.Homes
{
    public interface IHomeService
    {
        ValueTask<Home> AddHomeAsync(Home home);
        IQueryable<Home> RetrieveAllHomes();
        ValueTask<Home> RetrieveHomeByIdAsync(Guid id);
        ValueTask<Home> ModifyHomeAsync(Home home);
        ValueTask<Home> RemoveHomeAsync(Home home);
    }
}