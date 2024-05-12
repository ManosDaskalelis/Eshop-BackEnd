using Eshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Album>()
        //        .HasOne(e => e.Genre)
        //        .WithMany(e => e.Albums)
        //        .HasForeignKey(e => e.GenreId)
        //        .IsRequired(false);
        //}

        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
