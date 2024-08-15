using Microsoft.EntityFrameworkCore;
using CMSExample.DataAccess.Models;

namespace CMSExample.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Article> Articles { get; set; }

    }
}
