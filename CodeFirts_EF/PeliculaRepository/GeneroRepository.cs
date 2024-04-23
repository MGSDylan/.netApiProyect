using CodeFirts_EF.Models;

namespace CodeFirts_EF.PeliculaRepository
{

    public interface IGeneroRepository
    {
        Task save(List<Genero> generos);
    }

    public class GeneroRepository:IGeneroRepository
    {
        private readonly DbAppContext appContext;

        public GeneroRepository(DbAppContext appContext)
        {
            this.appContext = appContext;
        }

        public async Task save(List<Genero> generos)
        {
            await appContext.AddRangeAsync(generos);
        }
    }
}
