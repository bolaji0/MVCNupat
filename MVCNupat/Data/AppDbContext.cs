using Microsoft.EntityFrameworkCore;
using MVCNupat.Models;

namespace MVCNupat.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
