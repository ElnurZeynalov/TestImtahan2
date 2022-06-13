using Microsoft.EntityFrameworkCore;
using TestImtahan2.Models;

namespace TestImtahan2.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<Transmision> Transmisiones { get; set; }
    }
}
