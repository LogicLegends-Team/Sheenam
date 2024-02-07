using Microsoft.EntityFrameworkCore;
using Sheenam.Models.Foundations.ImageMetadatas;

namespace Sheenam.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<ImageMetadata> ImageMetadatas { get; set; }

        public async ValueTask<ImageMetadata> InsertHomeAsync(ImageMetadata imageMetadata) =>
            await this.InsertAsync(imageMetadata);

        public IQueryable<ImageMetadata> SelectAllImageMetadatas() =>
            this.SelectAll<ImageMetadata>();
    }
}
