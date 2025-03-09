using CleanArchitecture.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.Entities.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
