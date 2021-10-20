using Microsoft.EntityFrameworkCore;
using Conference.Models;

#nullable disable

namespace Conference.Data
{
    public partial class ConferenceDbContext : DbContext
    {
        public ConferenceDbContext(DbContextOptions<ConferenceDbContext> options)
        : base(options)
        {
        }
        public virtual DbSet<Conferences> Conferences { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.Entity<Conferences>(entity =>
            {
                entity.ToTable("Conference");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
                entity.Property(e => e.OrganizerEmail);
                entity.Property(e => e.StartDate);
                entity.Property(e => e.EndDate);
                entity.Property(e => e.ConferenceTypeId);
                entity.Property(e => e.LocationId);
            });
        }
    }
}
