using System.Text.Json.Serialization;
using Sheenam.Models.Foundations.Homes;
using Sheenam.Models.Foundations.Users;

namespace Sheenam.Models.Foundations.ImageMetadatas
{
    public class ImageMetadata
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Size { get; set; }
        public ImageFormat Format { get; set; }
        public string FilePath { get; set; }
        public Guid? HomeId { get; set; }
        [JsonIgnore]
        public virtual Home Home { get; set; }
    }
}