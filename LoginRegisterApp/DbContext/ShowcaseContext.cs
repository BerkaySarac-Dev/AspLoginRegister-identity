using LoginRegisterApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginRegisterApp.DbContext
{
    public class ShowcaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ShowcaseContext(DbContextOptions<ShowcaseContext> options) :base(options) { }
        public DbSet<Showcases> showcases { get; set; } 
    }
}
