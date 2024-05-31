using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookstoreCafe.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; init; } = null!;

        [Required]
        public string LastName { get; init; } = null!;
    }
}