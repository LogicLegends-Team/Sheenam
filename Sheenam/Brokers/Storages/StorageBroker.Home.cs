using Microsoft.EntityFrameworkCore;
using Sheenam.Models.Foundations.Homes;

namespace Sheenam.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Home> Homes { get; set; }
    }
}