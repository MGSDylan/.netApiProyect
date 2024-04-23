using CodeFirts_EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirts_EF.Configurations
{
    public class PeliculaSeed : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {

            for (var i=1;i < 50;i++){
                builder.HasData(
                    new Pelicula {Id=59+i,Name="resident evil"+i }
                                );
            }
            
        }
    }
}
