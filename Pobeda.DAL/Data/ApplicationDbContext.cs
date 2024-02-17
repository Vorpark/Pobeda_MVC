using Microsoft.EntityFrameworkCore;
using Pobeda.Domain.Entity;

namespace Pobeda.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
