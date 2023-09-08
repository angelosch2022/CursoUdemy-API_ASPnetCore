using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validaciones;

namespace WebApiAutores.DTOs
{
    public class LibroCreacionDTO
    {
        [PrimeraLetraMayuscula] // validacion personalizada
        [StringLength(maximumLength: 120, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        [Required]

        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public List<int> AutoresIds { get; set; }
    }
}
