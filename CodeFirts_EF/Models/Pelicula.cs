using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CodeFirts_EF.Models
{
    public class Pelicula
    {

        public int Id { get; set; }

        [ConcurrencyCheck]
        public string Name { get; set; }

        public bool IsDeleted { get; set; } = false;
        public virtual List<Genero> Generos { get; set; } = new List<Genero>();
       
        
    }
}
