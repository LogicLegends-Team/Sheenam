using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using Sheenam.Services.Orchestrations.Images;

namespace Sheenam.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : RESTFulController
    {
        private readonly IImageOrchestrationService imageFileOrchestrationService;

        public ImageController(
            IImageOrchestrationService imageFileOrchestrationService)
        {
            this.imageFileOrchestrationService = imageFileOrchestrationService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadImage(
            IFormFile image, Guid homeId)
        {
            string imagePath;

            using (var memoryStream = new MemoryStream())
            {
                string extension = Path.GetExtension(image.FileName);
                image.CopyTo(memoryStream);
                memoryStream.Position = 0;

                imagePath = await this.imageFileOrchestrationService.StoreImageAsync(
                    memoryStream, extension, homeId);
            }

            return Ok(imagePath);
        }

        [HttpDelete]
        public ActionResult<ValueTask<string>> DeleteImage(Guid imageId)
        {
            return this.imageFileOrchestrationService.RemoveImageFileByIdAsync(imageId);
        }
    }
}