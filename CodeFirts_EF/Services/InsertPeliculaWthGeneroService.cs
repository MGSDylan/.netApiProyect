using CodeFirts_EF.Models;
using CodeFirts_EF.PeliculaRepository;

namespace CodeFirts_EF.Services
{
    public class InsertPeliculaWthGeneroService
    {
        
        private readonly IUniToWork uniToWork;

        public InsertPeliculaWthGeneroService(IUniToWork uniToWork)
        {
            this.uniToWork = uniToWork;
        }

        public async Task Execute(Pelicula pelicula)
        {

            /*var gen = new Genero() { Name = "Comediaa222"  ,Pelicula=pelicula};
            var gen2 = new Genero() { Name = "Drama222" ,Pelicula = pelicula };
            
            var listGen = new List<Genero>() { gen,gen2} ;*/

            var listGen = new List<Genero>();

            // Iterar sobre los géneros de la película y crear objetos de género
            foreach (var generoNombre in pelicula.Generos)
            {
                listGen.Add(new Genero { Name = generoNombre.Name, Pelicula = pelicula });
            }




           // await uniToWork.peliculaRepository.InsertPelicula(pelicula);
            await uniToWork.generoRepository.save(listGen);
            await uniToWork.save();

        }
    }
}
