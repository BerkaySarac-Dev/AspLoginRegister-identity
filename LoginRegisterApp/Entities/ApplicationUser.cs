using Microsoft.AspNetCore.Identity;

namespace LoginRegisterApp.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? PersonName { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public bool Banned { get; set; } = false;
        public DateTime LastProcessDate { get; set; } = DateTime.UtcNow;
        public int LastProcessPrice { get; set; }
        public string? BuyedProducts { get; set; }
        public string? Reviews { get; set; }
        public string? Cart { get; set; }
        public string? LikedProducts { get; set; }
        public string? Messages { get; set; }
        public string? Notifications { get; set; }
        public string? CryptoWalletCode { get; set; }
        public string? SocialLinks { get; set; }
    }
}
