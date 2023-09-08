using WebApiAutores.Entidades;

namespace WebApiAutores.DTOs
{
    public class ComentarioDTO
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        //public int LibroId { get; set; }
        //public Libro Libro { get; set; } //propiedad de navegacion
    }
}
