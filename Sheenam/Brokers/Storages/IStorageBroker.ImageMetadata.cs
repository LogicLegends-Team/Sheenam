using Sheenam.Models.Foundations.ImageMetadatas;

namespace Sheenam.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<ImageMetadata> InsertHomeAsync(ImageMetadata imageMetadata);
        IQueryable<ImageMetadata> SelectAllImageMetadatas();
    }
}