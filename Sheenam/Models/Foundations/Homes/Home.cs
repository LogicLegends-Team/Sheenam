using Newtonsoft.Json;
using Sheenam.Models.Foundations.Users;

namespace Sheenam.Models.Foundations.Homes
{
    public class Home
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Address { get; set; } = string.Empty;
        public HomeType HomeType { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public Guid UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
    }
}