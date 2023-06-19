using Microsoft.AspNetCore.Identity;

namespace LoginRegisterApp.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? PersonName { get; set; }
        public string? CryptoWalletCode { get; set; }
    }
}
