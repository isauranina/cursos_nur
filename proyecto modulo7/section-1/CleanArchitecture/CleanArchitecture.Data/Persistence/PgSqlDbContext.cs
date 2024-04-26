using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitecture.Infrastructure.Persistence
{
    public class PgSqlDbContext : DbContext
    {
        public PgSqlDbContext(DbContextOptions<PgSqlDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseNpgsql("Host=localhost;port:5432;Database=db_nur;Username=postgres;Password=Clave**");

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = "system";
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = "system";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }


       // protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
            

            //modelBuilder.Entity<Streamer>()
            //    .HasMany(m => m.Videos)
            //    .WithOne(m => m.Streamer)
            //    .HasForeignKey(m => m.StreamerId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Restrict);



            //modelBuilder.Entity<Video>()
            //    .HasMany(p => p.Actores)
            //    .WithMany(t => t.Videos)
            //    .UsingEntity<VideoActor>(
            //        pt => pt.HasKey(e => new { e.ActorId, e.VideoId })
            //    );


       // }


        public DbSet<Propiedad>? Propiedades { get; set; }
        public DbSet<TipoPropiedad>? TipoPropiedades { get; set; }


    }
}
