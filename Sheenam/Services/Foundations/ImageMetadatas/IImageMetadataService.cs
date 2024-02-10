﻿using Sheenam.Models.Foundations.ImageMetadatas;

namespace Sheenam.Services.Foundations.ImageMetadatas
{
    public interface IImageMetadataService
    {
        ValueTask<ImageMetadata> AddImageMetadataAsync(ImageMetadata imageMetadata);
        IQueryable<ImageMetadata> RetrieveAllImageMetadatas();
        ValueTask<ImageMetadata> RetrieveImageMetadataByIdAsync(Guid id);
        ValueTask<ImageMetadata> ModifyImageMetadataAsync(ImageMetadata imageMetadata);
        ValueTask<ImageMetadata> RemoveImageMetadataAsync(ImageMetadata imageMetadata);
    }
}
