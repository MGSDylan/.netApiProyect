using CodeFirts_EF.Configurations;
using CodeFirts_EF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirts_EF.PeliculaRepository
{

    public interface IPeliculaRepository :IGenericRepository<Pelicula>
    {
        /*Task<List<Pelicula>> GetPelicula();
        Task<List<Pelicula>> GetPelicula2();
        Task<Pelicula> InsertPelicula(Pelicula pelicula);
        Pelicula GetPeliculaById(int id);
        void DeletePeliculaById(int id);
        Pelicula savePeliculaById(Pelicula pelicula);
        Pelicula updatePeliculaById(Pelicula pelicula);
        Pelicula deleteLogicalPelicula(int id);
        public Pelicula getPeliculaByName(string name)

        Task<List<Pelicula>> GetPeliculaByPage(int pageNum, int pageSize, string search);
    /*/
        public Pelicula getPeliculaByName(string name);
    }

    


    public class PeliculaRepository : GenericRepository<Pelicula>,IPeliculaRepository
    {
        private readonly DbAppContext context;

        public PeliculaRepository(DbAppContext context):base(context)
        {
            this.context = context;
        }


        public Pelicula getPeliculaByName(string name)
        {
            return context.peliculas.FromSqlInterpolated($"select * from peliculas where name={name}").FirstOrDefault();
        }


       /* public async Task<List<Pelicula>> GetPelicula()
        {
             return await context.peliculas.Include(p=>p.Generos).ToListAsync();
        }
        public async Task<List<Pelicula>> GetPelicula2()
        {
            return await context.peliculas.Where(p=>p.IsDeleted==false).ToListAsync();
        }

        public async Task<Pelicula> InsertPelicula(Pelicula pelicula)
        {
            context.peliculas.Add(pelicula);
            return  pelicula;
        }

        
        public  Pelicula GetPeliculaById(int id)
        {
            return  context.peliculas.Include(p=>p.Generos).Where(p=>p.Id==id).First();
        }

        public void DeletePeliculaById(int id)
        {
             context.peliculas.Where(p=>p.Id==id).ExecuteDelete();
        }

        public Pelicula updatePeliculaById(Pelicula pelicula)
        {

            var pel = context.peliculas.Find(pelicula.Id);
            if (pel != null)
            {
                pel.Name = pelicula.Name;
                pel.Generos = pelicula.Generos;
                context.SaveChanges();
                
                return pel;
            }
            
            return null;
        }

        public Pelicula savePeliculaById(Pelicula pelicula)
        {
                context.peliculas.Add(pelicula);
                context.SaveChanges();
            return pelicula;
            
        }

        public async Task<List<Pelicula>> GetPeliculaByPage(int pageNum, int pageSize, string search)
        {
            return await context.peliculas.Include(p => p.Generos)
                .Where(p=>p.Name.Contains(search))
                .Skip((pageNum-1)*pageSize)
                .Take(pageSize).ToListAsync();
        }

        public Pelicula deleteLogicalPelicula(int id)
        {
            var peli=context.peliculas.Find(id);
            if(peli != null)
            {
                peli.IsDeleted= true;
                context.SaveChanges();
                return peli;
            }
            
            return null;
        }*/
    }
}
