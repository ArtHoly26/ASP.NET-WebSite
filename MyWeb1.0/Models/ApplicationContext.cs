using Microsoft.EntityFrameworkCore;

namespace MyWeb1._0.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
