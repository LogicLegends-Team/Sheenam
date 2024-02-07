using System.Text.Json.Serialization;
using Sheenam.Models.Foundations.Homes;
using Sheenam.Models.Foundations.ImageMetadatas;

namespace Sheenam.Models.Foundations.Users
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public GenderType Gender { get; set; }
        public Role Role { get; set; }
        [JsonIgnore]
        public virtual ICollection<Home> UserHomes { get; set; }
        [JsonIgnore]
        public virtual ICollection<ImageMetadata> ImageMetadata { get; set; }
    }
}