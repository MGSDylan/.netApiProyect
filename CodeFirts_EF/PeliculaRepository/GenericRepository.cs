using CodeFirts_EF.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace CodeFirts_EF.PeliculaRepository
{

    public interface IGenericRepository<T>
    {
        IQueryable<T> GetAll();
        Task<T> InsertEntity(T value);
        T GetById(int id);
        T save(T value);
        T update(T value);
        void deleteLogical(int id);


    }
    public abstract class GenericRepository<T> : IGenericRepository<T>
        where T : Pelicula
    {
        private readonly DbAppContext appContext;

        protected GenericRepository(DbAppContext appContext)
        {
            this.appContext = appContext;
        }

        protected DbSet<T> Entities=> appContext.Set<T>();

        public void deleteLogical(int id)
        {
            //Entities.Where(t=>t.Equals(id)).ExecuteDelete();
            var enti=Entities.Find(id);
            if (enti!=null)
            {
                enti.IsDeleted = true;
                appContext.SaveChanges();
            }
            
        }

        public IQueryable<T> GetAll()
        {
            return Entities;
        }

        public T GetById(int id)
        {
            return Entities.Find(id);
        }

        public async Task<T> InsertEntity(T value)
        {
            await appContext.AddAsync(value);
            return value;
        }

        public T save(T value)
        {
            throw new NotImplementedException();
        }

        public T update(T value)
        {
             Entities.Update(value);
            return value;
        }
    }
}
