using LoginRegisterApp.Models;
using Microsoft.EntityFrameworkCore;
namespace LoginRegisterApp.DbContext
{
    public class CommentContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CommentContext(DbContextOptions<CommentContext> options) : base(options)
        {
            
        }
        public DbSet<Comments> comments { get; set; }
    }
}
