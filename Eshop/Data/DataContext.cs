using Eshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
    }
}
