using Microsoft.EntityFrameworkCore;
using Sheenam.Models.Foundations.ImageMetadatas;

namespace Sheenam.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<ImageMetadata> ImageMetadatas { get; set; }
    }
}
