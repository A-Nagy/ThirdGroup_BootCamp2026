using Microsoft.EntityFrameworkCore;
using ThirdGroup_1.Models;

namespace ThirdGroup_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
