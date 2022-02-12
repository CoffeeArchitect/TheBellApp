using Microsoft.EntityFrameworkCore;
using TheBellApp.Models;

namespace TheBellApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}
