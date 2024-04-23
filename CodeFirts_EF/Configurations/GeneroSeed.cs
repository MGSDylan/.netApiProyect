using CodeFirts_EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirts_EF.Configurations
{
    public class GeneroSeed : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.HasData(
                new Genero { Id=2,Name="Terror",PeliculaId=1},
                new Genero { Id=3,Name="Ciencia-Ficcion",PeliculaId = 1 }
                );
        }
    }
}
