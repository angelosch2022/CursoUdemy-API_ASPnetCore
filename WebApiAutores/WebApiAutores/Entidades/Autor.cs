using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiAutores.Validaciones;

namespace WebApiAutores.Entidades
{
    public class Autor : IValidatableObject //validacion por modelo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DisplayName("Nombres")]
        [StringLength(maximumLength:120, ErrorMessage ="El campo {0} no debe tener mas de {1} caracteres")]
        //[PrimeraLetraMayuscula] // validacion personalizada
        public string Nombre { get; set; }

        //[NotMapped]
        //[Range(18, 120)]
        //public int edad { get; set; }

        //[NotMapped]
        //[CreditCard]
        //public string TarjetaDeCredito { get; set; }

        //[Url]
        //public string Url { get; set; }

        //public int Menor { get; set; }

        //public int Mayor { get; set; }

        public List<Libro> Libros { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Nombre))
            {
                var primeraletra = Nombre[0].ToString();

                if(primeraletra != primeraletra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra debe ser mayúscula", new string[] {nameof(Nombre)});
                }
            }

            //if(Menor > Mayor)
            //{
            //    yield return new ValidationResult("Este valor no puede ser mas grande que el campo mayor", new string[] {nameof(Menor)});
            //}
            //throw new NotImplementedException();
        }
    }
}
