using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApiAutores.Entidades;
using WebApiAutores.Filtros;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class AutoresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger<AutoresController> log;

        public AutoresController(ApplicationDbContext context,
                                    ILogger<AutoresController> log)
        {
            this.context = context;
            this.log = log;
        }

        [HttpGet] // api/autores
        [HttpGet("listado")] // api/autores/listado
        [HttpGet("/listado")] // listado
        [ResponseCache(Duration =10)] //duracion del listado en memoria caché 
        [ServiceFilter(typeof(MiFiltroDeAccion))] // Filtro personalizado
        public async Task<ActionResult<List<Autor>>> Get()
        {
            log.LogInformation("Estamos Listando todos los Autores");
            //return await context.Autores.ToListAsync();
            return await context.Autores.Include(x => x.Libros).ToListAsync(); //incluye el listado de libros
        }

        //TIPOS DE VALORES DE RETORNO
        [HttpGet("iar/{id:int}")] 
        public IActionResult GetIActionReult(int id)  //no es conveniente usarlo porque se puede retornar cualqeuir cosa dentro del Ok(+++)
        {
            //return await context.Autores.ToListAsync();
            return Ok(context.Autores.FirstOrDefault(x => x.Id == id)); //incluye el listado de libros
        }



        [HttpGet("{id:int}/{param2?}")] //obliga a que el parametr sea entero
        public async Task<ActionResult<Autor>> Get(int id, string param2) //param2 es opcional
        {
            var encontrado = await context.Autores.FirstOrDefaultAsync(x => x.Id == id);

            if(encontrado == null)
            {
                return NotFound();
            }

            return Ok(encontrado);
        }


        [HttpGet("{nombre}")] 
        public async Task<ActionResult<Autor>> Get([FromRoute] string nombre) //[FromRoute]: enviar param. desde la ruta
        {
            var encontrado = await context.Autores.FirstOrDefaultAsync(x => x.Nombre.Contains(nombre));

            if (encontrado == null)
            {
                return NotFound();
            }

            return Ok(encontrado);
        }


        [HttpGet("primero")]
        public async Task<ActionResult<Autor>> Primero([FromHeader] int miValor, [FromQuery]string nombre) //Enviar miValor al header -- [FromQuery]: envia el nombre y valor a la ruta (ejemplo: htt.../api/autores/primero?nombre=angelo)
        {
            return await context.Autores.Include(x => x.Libros).FirstOrDefaultAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Autor autor) //[FromBody]: enviar autor Desde el cuerpo
        {

            var existeAutorConElMismoNpombre = await context.Autores.AnyAsync(x => x.Nombre == autor.Nombre);

            if (existeAutorConElMismoNpombre)
            {
                return BadRequest($"Ya exister un autor con el nombre {autor.Nombre}");
            }

            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")] //api/autores/2
        public async Task<ActionResult> Put (Autor autor, int id)
        {
            if(autor.Id != id)
            {
                return BadRequest("El id del autor no coincide con el id de la Url");
            }

            var existe = await context.Autores.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound();
            }

            context.Update(autor);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]//api/autores/1
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Autores.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound();
            }

            context.Remove(new Autor() { Id=id });
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
