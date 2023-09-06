using AutoMapper;
using WebApiAutores.DTOs;
using WebApiAutores.Entidades;
using WebApiAutores.Migrations;

namespace WebApiAutores.Utilidades
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AutorCreacionDTO, Autor>();
            CreateMap<Autor, AutorDTO>(); //el orden depende desde donde y hacia donde se envia la informacion.
            CreateMap<Autor, AutorDTOConLibros>() //Mapeando a esta clase se evita que al no usar estructura ciclica, aparezcan los arrays como null
                 .ForMember(x => x.Libros, opciones => opciones.MapFrom(MapAutorDTOLibros));

            CreateMap<LibroCreacionDTO, Libro>();

            CreateMap<LibroCreacionDTO, Libro>()
                .ForMember(x => x.AutoresLibros, opciones => opciones.MapFrom(MapAutoresLibros));


            CreateMap<Libro, LibroDTO>();
            CreateMap<Libro, LibroDTOConAutores>().
                ForMember(x => x.Autores, opciones=> opciones.MapFrom(MapLibroDTOAutores));


            CreateMap<ComentarioCreacionDTO, Comentario>();
            CreateMap<Comentario, ComentarioDTO>();


        }

        private List<LibroDTO> MapAutorDTOLibros(Autor autor, AutorDTO autorDTO)
        {
            var resultado = new List<LibroDTO>();

            if (autor.AutoresLibros == null) { return resultado; }

            foreach (var autorLibro in autor.AutoresLibros)
            {
                resultado.Add(new LibroDTO()
                {
                    Id = autorLibro.LibroId,
                    Titulo = autorLibro.Libro.Titulo
                });
            }

            return resultado;
        }

        private List<AutorDTO> MapLibroDTOAutores(Libro libro, LibroDTO libroDTO)
        {
            var resultado = new List<AutorDTO>();

            if(libro.AutoresLibros == null) { return resultado; }

            foreach(var autorLibro in libro.AutoresLibros)
            {
                resultado.Add(new AutorDTO()
                {
                    Id = autorLibro.AutorId,
                    Nombre = autorLibro.Autor.Nombre
                });
            }

            return resultado;
        }

        private List<AutorLibro> MapAutoresLibros(LibroCreacionDTO libroCreacionDTO, Libro libro)
        {
            var resultado = new List<AutorLibro>();

            if(libroCreacionDTO.AutoresIds == null)
            {
                return resultado;
            }

            foreach(var autorId in libroCreacionDTO.AutoresIds)
            {
                resultado.Add(new AutorLibro() { AutorId = autorId });
            }

            return resultado;
        }
    }
}
