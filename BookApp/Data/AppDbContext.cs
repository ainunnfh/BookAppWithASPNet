using BookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
    }
}
