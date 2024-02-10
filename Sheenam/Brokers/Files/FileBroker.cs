namespace Sheenam.Brokers.Files
{
    public class FileBroker : IFileBroker
    {
        public async ValueTask<string> SaveFileAsync(
            MemoryStream memoryStream, string fileName, string uploadsFolder)
        {
            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            var relativePath = Path.Combine("images", uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                memoryStream.Seek(0, SeekOrigin.Begin);
                await memoryStream.CopyToAsync(fileStream);
            }

            return relativePath;
        }
    }
}