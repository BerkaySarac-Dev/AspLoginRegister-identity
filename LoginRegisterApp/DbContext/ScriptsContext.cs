using LoginRegisterApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginRegisterApp.DbContext
{
    public class ScriptsContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ScriptsContext(DbContextOptions<ScriptsContext> options) : base(options) 
        {
            
        }
        public DbSet<Scripts> Script { get; set; }
    }
}
