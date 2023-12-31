﻿using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WebApiAutores.DTOs;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/libros")]
    public class LibrosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public LibrosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        [HttpGet]
        public async Task<ActionResult<List<LibroDTO>>> Get()
        {
            var libros = await context.Libros
                .ToListAsync();

            return mapper.Map<List<LibroDTO>>(libros);
        }


        /*       [HttpGet("{id:int}")]
               public async Task<ActionResult<LibroDTO>> Get(int id)
               {
                   var libro = await context.Libros
                       .Include(x => x.Comentarios)
                       .FirstOrDefaultAsync(x => x.Id == id);
                   return mapper.Map<LibroDTO>(libro);
               }

               */

        [HttpGet("{id:int}", Name = "obtenerLibro")]
        public async Task<ActionResult<LibroDTOConAutores>> Get(int id)
        {
            var libro = await context.Libros
                .Include(x => x.Comentarios)
                .Include(x => x.AutoresLibros)
                .ThenInclude(x=> x.Autor)
                .FirstOrDefaultAsync(x => x.Id == id);

            if(libro == null)
            {
                return NotFound();
            }

            return mapper.Map<LibroDTOConAutores>(libro);
        }


        [HttpPost]
        public async Task<ActionResult> Post(LibroCreacionDTO libroCreacionDTO)
        {
            if (libroCreacionDTO.AutoresIds == null)
            {
                return BadRequest("No se puede crear un libro sin autores");
            }

            var autoresIds = await context.Autores
                .Where(x => libroCreacionDTO.AutoresIds.Contains(x.Id))
                .Select(x => x.Id).ToListAsync();

            if (libroCreacionDTO.AutoresIds.Count != autoresIds.Count)
            {
                return BadRequest("No existe uno de los autores enviados");
            }

            var libro = mapper.Map<Libro>(libroCreacionDTO);

            context.Add(libro);
            await context.SaveChangesAsync();

            var libroDTO = mapper.Map<LibroDTO>(libro);

            return CreatedAtRoute("obtenerLibro", new { id = libro.Id}, libroDTO); //SE USA COMO BUENA PRACTICA QUE DEVUELVA LA RUTA DEL OBJETO CREADO, EL ID, Y EL OBJETO
        }

        
        
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, LibroCreacionDTO libroCreacionDTO)
        {
            var libroDB = await context.Libros
                .Include(x => x.AutoresLibros)
                .FirstOrDefaultAsync( x => x.Id == id);

            if(libroDB == null)
            {
                return NotFound();
            }

            libroDB = mapper.Map(libroCreacionDTO,libroDB); //con esto auomaticamente se actualiza el libro

            await context.SaveChangesAsync();

            return NoContent();

        }

        [HttpPatch("{id:int}")]
        public async Task<ActionResult> Patch(int id, JsonPatchDocument<LibroPatchDTO> patchDocument)
        {
            if(patchDocument == null)
            {
                return BadRequest();
            }

            var libroBD = await context.Libros.FirstOrDefaultAsync(x => x.Id == id);

            if(libroBD == null)
            {
                return NotFound();
            }

            var libroDTO = mapper.Map<LibroPatchDTO>(libroBD);

            patchDocument.ApplyTo(libroDTO, ModelState); 


            var isValido = TryValidateModel(libroDTO);
            if(!isValido)
            {
                return BadRequest(ModelState);
            }

            mapper.Map(libroDTO, libroBD);

            await context.SaveChangesAsync();

            return NoContent();


        }



        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Libros.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound();
            }

            context.Remove(new Libro() { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
