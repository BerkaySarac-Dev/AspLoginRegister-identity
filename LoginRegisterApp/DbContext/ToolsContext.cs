using LoginRegisterApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LoginRegisterApp.DbContext
{
    public class ToolsContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ToolsContext(DbContextOptions<ToolsContext> options) : base(options)
        {
        }
        public DbSet<Tools> tools { get; set; }
    }
}
