﻿using Sheenam.Brokers.Files;

namespace Sheenam.Services.Foundations.Files
{
    public class FileService : IFileService
    {
        private readonly IFileBroker fileBroker;

        public FileService(IFileBroker fileBroker)
        {
            this.fileBroker = fileBroker;
        }

        public ValueTask<string> UploadFileAsync(
            MemoryStream memoryStream, string fileName, string uploadsFolder) =>
            this.fileBroker.SaveFileAsync(memoryStream, fileName, uploadsFolder);
    }
}