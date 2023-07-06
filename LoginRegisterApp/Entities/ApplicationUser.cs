using Microsoft.AspNetCore.Identity;

namespace LoginRegisterApp.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? PersonName { get; set; }
        public DateTime? RegisteredDate { get; set; } = DateTime.UtcNow;
        public bool Banned { get; set; } = false;
        public DateTime LastProcessDate { get; set; } 
        public int LastProcessPrice { get; set; }
        public string? BuyedProducts { get; set; }
        public string? Reviews { get; set; }
        public string? Cart { get; set; }
        public string? LikedProducts { get; set; }
        public string? Messages { get; set; }
        public string? Notifications { get; set; }
        public string? CryptoWalletCode { get; set; }
        public string? SocialLinks { get; set; }
        public bool IsVendor { get; set; } = false;
        public string? RejectedProducts { get; set; }
        public string? WaitedProducts { get; set; }
        public bool? AccountWaitingVerify { get; set; } = false;
    }
}