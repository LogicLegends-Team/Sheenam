﻿using Sheenam.Models.Foundations.Homes;

namespace Sheenam.Models.Foundations.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public GenderType Gender { get; set; }
        public Role Role { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public virtual ICollection<Home> UserHomes { get; set; }
    }
}