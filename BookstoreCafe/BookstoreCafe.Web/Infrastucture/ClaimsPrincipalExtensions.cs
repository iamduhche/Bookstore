using System.Security.Claims;

namespace BookstoreCafe.Infrastructure
{
    public static class ClaimsPrincipalExtensions
    {
        public static string? GetUserId(this ClaimsPrincipal user) =>
            user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        public static bool isAdmin(this ClaimsPrincipal user) =>
            user.IsInRole("Administrator");

        
    }
}