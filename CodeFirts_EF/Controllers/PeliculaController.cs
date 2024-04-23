using CodeFirts_EF.Models;
using CodeFirts_EF.PeliculaRepository;
using CodeFirts_EF.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace CodeFirts_EF.Controllers
{
    [ApiController]
    [Route("api/pelicula")]
    public class PeliculaController : ControllerBase
    {


        private readonly IPeliculaRepository peliculaRepository;
        private readonly InsertPeliculaWthGeneroService insertPeliculaWthGenero;

        public PeliculaController(IPeliculaRepository peliculaRepository, InsertPeliculaWthGeneroService insertPeliculaWthGenero)
        {
            this.peliculaRepository = peliculaRepository;
            this.insertPeliculaWthGenero = insertPeliculaWthGenero;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //return Ok(await peliculaRepository.GetPelicula());
            return Ok(await peliculaRepository.GetAll().ToListAsync());
        }

        /*
        [HttpPost]
        public async Task save([FromBody] Pelicula pelicula)
        {
            await insertPeliculaWthGenero.Execute(pelicula);
 
        }*/

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //return Ok( peliculaRepository.GetPeliculaById(id));
            return Ok(peliculaRepository.GetById(id));
        }

        [HttpDelete("{id}")]
        public void DeleteById(int id)
        {
            peliculaRepository.deleteLogical(id);

        }

        [HttpPut("update")]
        public IActionResult update([FromBody] Pelicula pelicula)
        {
            return Ok(peliculaRepository.update(pelicula));
        }

        [HttpPost("save")]
        public IActionResult GetById([FromBody] Pelicula pelicula)
        {
            return Ok(peliculaRepository.save(pelicula));
        }

        [HttpGet("name/{pelicula}")]
        public IActionResult GetByName( string pelicula)
        {
            return Ok(peliculaRepository.getPeliculaByName(pelicula));
        }


        /*
        [HttpGet("getpage")]
        public async Task<IActionResult> Index2(int pageNum, int pageSize, string search)
        {
            return Ok(await peliculaRepository.GetPeliculaByPage(pageNum,pageSize,search));
        }


        [HttpGet("getpel2")]
        public async Task<IActionResult> Index3()
        {
            return Ok(await peliculaRepository.GetPelicula2());
        }
        
        [HttpDelete("delete")]
        public  IActionResult delete([FromBody] int id)
        {
            var pel2 = peliculaRepository.deleteLogicalPelicula(id);
            if (pel2 != null)
            {
                 return Ok(pel2.Name + " Pelicula eliminada!!!");
            }
            return Ok("pelicula no encontrada!!! ");

        }*/
    }
}
