using System.Text.Json.Serialization;
using Sheenam.Models.Foundations.ImageMetadatas;
using Sheenam.Models.Foundations.Users;

namespace Sheenam.Models.Foundations.Homes
{
    public class Home
    {
        public Guid HomeId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
        public HomeType HomeType { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public Guid UserId { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }
        [JsonIgnore]
        public virtual  ICollection<ImageMetadata> ImageMetadata { get; set; }
    }
}