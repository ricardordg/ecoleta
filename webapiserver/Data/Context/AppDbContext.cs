using Microsoft.EntityFrameworkCore;
using webapiserver.Domain.Entities;

namespace webapiserver.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions opt) : base(opt)
        {
            
        }

        public DbSet<Point> Points { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<PointItem> PointItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PointItem>()
                .HasKey(pi => new { pi.ItemId, pi.PointId });  

            modelBuilder.Entity<PointItem>()
                .HasOne(pi => pi.Point)
                .WithMany(p => p.PointItems)
                .HasForeignKey(pi => pi.PointId);  

            modelBuilder.Entity<PointItem>()
                .HasOne(pi => pi.Item)
                .WithMany(i => i.PointItems)
                .HasForeignKey(pi => pi.ItemId);
        }
    }
}