using CodeFirts_EF.Models;

namespace CodeFirts_EF.PeliculaRepository
{


    public interface IUniToWork :IDisposable
    {
        public IPeliculaRepository peliculaRepository { get; }
        public IGeneroRepository generoRepository { get; }
        Task<int> save( );
    }
    public class UniToWork: IUniToWork
    {
        public IPeliculaRepository peliculaRepository { get; }
        public IGeneroRepository generoRepository { get; }

        private readonly DbAppContext appContext;

        public UniToWork(IPeliculaRepository peliculaRepository, IGeneroRepository generoRepository, DbAppContext appContext)
        {
            this.peliculaRepository = peliculaRepository;
            this.generoRepository = generoRepository;
            this.appContext = appContext;
        }

        public void Dispose()
        {
            appContext.Dispose();
        }

        public async Task<int> save()
        {

            return await appContext.SaveChangesAsync();
   
        }
    }
}
