using System.Security.Principal;
using WebApiAutores.Validaciones;

namespace WebApiAutores.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        [PrimeraLetraMayuscula] // validacion personalizada
        public string Titulo { get; set; }
        [PrimeraLetraMayuscula] // validacion personalizada
        public int AutorId { get; set; }
        public Autor autor { get; set; }
    }
}
