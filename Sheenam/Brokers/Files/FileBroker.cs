namespace Sheenam.Brokers.Files
{
    public class FileBroker
    {
        public async Task<string> SaveImageAsync(IFormFile file, string uploadsFolder)
        {
            string uniqueFileName = file.FileName;

            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            string relativePath = Path.Combine("images", uniqueFileName);
            return relativePath;
        }
    }
}