using CodeFirts_EF.Configurations;
using CodeFirts_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirts_EF
{
    public class DbAppContext : DbContext
    {

        public DbSet<Pelicula> peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbAppContext(DbContextOptions<DbAppContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Pelicula>().HasQueryFilter(x => !x.IsDeleted);

            modelBuilder.ApplyConfiguration(new PeliculaSeed());
            modelBuilder.ApplyConfiguration(new GeneroSeed());

            

            modelBuilder.Entity<Pelicula>().HasData(
                new Pelicula { Id=1,Name="star wars" },
                new Pelicula { Id=2,Name="Matrix2"}
                ); 


            modelBuilder.Entity<Pelicula>(p =>
            {
                p.HasKey(x => x.Id);
                p.Property(x => x.Name).HasMaxLength(100);

 
            }
            );

            modelBuilder.Entity<Genero>(g =>
            {
                g.HasKey(x => x.Id);
                g.Property(x => x.Name);
                g.HasOne(p => p.Pelicula).WithMany(x => x.Generos)
                .HasForeignKey(z => z.PeliculaId).OnDelete(DeleteBehavior.Restrict); 

            });
                
            
        }
    }
}
