using System;
using Sheenam.Services.Foundations.Files;

namespace Sheenam.Services.Processings.File
{
    public class FileProcessingService : IFileProcessingService
    {
        private readonly IFileService fileService;

        public FileProcessingService(IFileService fileService)
        {
            this.fileService = fileService;
        }

        public async ValueTask<string> UploadFileAsync(
            MemoryStream memoryStream, 
            string fileName)
        {
            var uploadsFolder =
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            return await this.fileService.UploadFileAsync(memoryStream, fileName, uploadsFolder);
        }

        public string DeleteImageFile(string imageName)
        {
            string filePath = Path.Combine("wwwroot\\images", imageName);

            if (System.IO.File.Exists(filePath))
            {
                this.fileService.RemoveImageFile(filePath);
                return "Image deleted successfully.";
            }
            else
            {
                return "Image not found.";
            }
        }
    }
}
