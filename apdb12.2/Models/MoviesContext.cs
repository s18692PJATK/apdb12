using Microsoft.EntityFrameworkCore;

namespace apdb12._2.Models
{
    public class MovieContext : DbContext

    {
        public DbSet<Movie> Movie { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(m => m.Id);

                entity.Property(m => m.Id).ValueGeneratedOnAdd();
                entity.ToTable("Movie");
            });
        }
    }
}