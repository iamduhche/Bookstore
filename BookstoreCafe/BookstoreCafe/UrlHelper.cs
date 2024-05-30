using System.Text.RegularExpressions;

namespace BookstoreCafe
{
    public static class UrlHelper
    {
        public static string GenerateSlug(string title, string author)
        {
            string slug = $"{title}-{author}";
            // Remove special characters
            slug = Regex.Replace(slug, @"[^a-zA-Z0-9\s-]", "");
            // Replace spaces with hyphens
            slug = slug.Replace(" ", "-");
            // Convert to lowercase
            slug = slug.ToLower();
            // Remove multiple consecutive hyphens
            slug = Regex.Replace(slug, @"-+", "-");
            return slug;
        }
    }
}
