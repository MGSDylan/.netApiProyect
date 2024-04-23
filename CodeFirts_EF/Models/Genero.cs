namespace CodeFirts_EF.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PeliculaId { get; set; }
        public virtual Pelicula Pelicula { get; set; }
    }

}

