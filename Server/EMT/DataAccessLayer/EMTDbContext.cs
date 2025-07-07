using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class EMTDbContext : DbContext
    {
        public EMTDbContext(DbContextOptions<EMTDbContext> options) : base(options) { }

        public DbSet<Minigame> Minigames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Minigame>()
            .Property(m => m.Tags)
            .HasConversion(
                v => string.Join(';', v),
                v => v.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList()
    );

            base.OnModelCreating(modelBuilder);
        }
    }
}
