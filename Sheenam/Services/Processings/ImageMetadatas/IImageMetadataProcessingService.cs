using Sheenam.Models.Foundations.ImageMetadatas;

namespace Sheenam.Services.Processings.ImageMetadatas
{
    public interface IImageMetadataProcessingService
    {
        ValueTask<ImageMetadata> AddImageMetadataAsync(ImageMetadata imageMetadata);
        IQueryable<ImageMetadata> RetrieveAllImageMetadatas();
        ValueTask<ImageMetadata> RetrieveImageMetadataByIdAsync(Guid id);
        ValueTask<ImageMetadata> ModifyImageMetadataAsync(ImageMetadata imageMetadata);
        ValueTask<ImageMetadata> RemoveImageMetadataByIdAsync(Guid id);
    }
}
