//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TerminalAlmacenamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TerminalAlmacenamiento()
        {
            this.OrdenIngresos = new HashSet<OrdenIngreso>();
        }
    
        public short IdTerminalAlmacenamiento { get; set; }
        public string NombreTerminalAlmacenamiento { get; set; }
        public string CodigoTerminalAlmacenamiento { get; set; }
        public short IdJurisdiccion { get; set; }
        public string RepresentanteLegal { get; set; }
        public byte Estado { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
    
        public virtual Jurisdiccione Jurisdiccione { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenIngreso> OrdenIngresos { get; set; }
    }
}
