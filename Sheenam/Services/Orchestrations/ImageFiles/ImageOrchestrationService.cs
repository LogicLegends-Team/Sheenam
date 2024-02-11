using System.Xml.Linq;
using Sheenam.Models.Foundations.ImageMetadatas;
using Sheenam.Services.Processings.File;
using Sheenam.Services.Processings.ImageMetadatas;

namespace Sheenam.Services.Orchestrations.Images
{
    public class ImageOrchestrationService : IImageOrchestrationService
    {
        private readonly IImageMetadataProcessingService imageMetadtaProcessingService;
        private readonly IFileProcessingService fileProcessingService;

        public ImageOrchestrationService(
            IImageMetadataProcessingService imageMetadtaProcessingService, 
            IFileProcessingService fileProcessingService)
        {
            this.imageMetadtaProcessingService = imageMetadtaProcessingService;
            this.fileProcessingService = fileProcessingService;
        }

        public async ValueTask<string> StoreImageAsync(
            MemoryStream memoryStream, 
            string extension, Guid homeId)
        {
            Guid imageId = Guid.NewGuid();
            string name = imageId.ToString() + extension;

            var format =
                (ImageFormat)Enum.Parse(typeof(ImageFormat), extension.Substring(1), true);

            string filePath = 
                await this.fileProcessingService.UploadFileAsync(memoryStream, name);

            var imageMetadata = new ImageMetadata
            {
                Id = imageId,
                Name = name,
                Size = memoryStream.Length,
                Format = format,
                HomeId = homeId,
                FilePath = filePath,
            };

            await this.imageMetadtaProcessingService.AddImageMetadataAsync(imageMetadata);

            return imageMetadata.FilePath;
        }

        public async ValueTask<string> RemoveImageFileByIdAsync(Guid id)
        {
            ImageMetadata image = 
                await this.imageMetadtaProcessingService.RetrieveImageMetadataByIdAsync(id);

            await this.imageMetadtaProcessingService.RemoveImageMetadataByIdAsync(id);

            return this.fileProcessingService.DeleteImageFile(image.Name);
        }
    }
}