using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using WebApiAutores.Validaciones;

namespace WebApiAutores.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        [PrimeraLetraMayuscula] // validacion personalizada
        [StringLength(maximumLength:250, ErrorMessage ="El campo {0} no debe tener mas de {1} caracteres")]
        [Required]
        public string Titulo { get; set; }

        public List<Comentario> Comentarios { get; set; }
    }
}
