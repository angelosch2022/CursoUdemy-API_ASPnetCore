using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAutores.DTOs;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/libros/{libroId:int}/comentarios")]
    public class ComentariosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ComentariosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        //[HttpGet]
        //public async Task<ActionResult<List<ComentarioDTO>>> Get()
        //{
        //    var comentarios = await context.Comentarios.ToListAsync();

        //    return mapper.Map<List<ComentarioDTO>>(comentarios);

        //}

        [HttpGet]
        public async Task<ActionResult<List<ComentarioDTO>>> Get(int libroId)
        {
            var existeLibro = await context.Libros.AnyAsync(x => x.Id == libroId); //devuelve un true or false

            if (!existeLibro)
            {
                return NotFound();
            }

            var comentarios = await context.Comentarios.Where(x => x.LibroId == libroId).ToListAsync();


            return mapper.Map<List<ComentarioDTO>>(comentarios);
        }

        [HttpGet("{id:int}", Name ="obtenerComentario")]
        public async Task<ActionResult<ComentarioDTO>> GetById(int id)
        {
            var existeComentario = await context.Comentarios.FirstOrDefaultAsync(x => x.Id == id);

            if (existeComentario==null)
            {
                return NotFound();
            }

            return mapper.Map<ComentarioDTO>(existeComentario);            

        }


        [HttpPost]
        public async Task<ActionResult> Post(int libroId, ComentarioCreacionDTO comentarioCreacionDTO)
        {
            var existeLibro = await context.Libros.AnyAsync(x => x.Id == libroId); //devuelve un true or false

            if(!existeLibro)
            {
                return NotFound();
            }

            var comentario = mapper.Map<Comentario>(comentarioCreacionDTO);
            comentario.LibroId = libroId;
            context.Add(comentario);
            await context.SaveChangesAsync();

            var comentarioDTO = mapper.Map<ComentarioDTO>(comentario);

            return CreatedAtRoute("obtenerComentario", new {id = comentario.Id, libroId }, comentarioDTO); //SE USA COMO BUENA PRACTICA QUE DEVUELVA LA RUTA DEL OBJETO CREADO, EL ID, Y EL OBJETO
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int libroId, ComentarioCreacionDTO comentarioCreacionDTO, int id)
        {
            var existeLibro = await context.Libros.AnyAsync(x => x.Id == libroId);

            if (!existeLibro)
            {
                return NotFound("No se encuentra el libro del comentario a editar");
            }

            var existeComentario = await context.Comentarios.AnyAsync(x => x.Id == id);

            if(!existeComentario)
            {
                return NotFound("No existe el comentario a editar");
            }

            var comentario = mapper.Map<Comentario>(comentarioCreacionDTO);
            comentario.Id = id;
            comentario.LibroId = libroId;

            context.Update(comentario);
            await context.SaveChangesAsync();

            return NoContent();

        }
    }
}
