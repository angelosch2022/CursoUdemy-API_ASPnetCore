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
    
    public partial class EmpresaTransporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmpresaTransporte()
        {
            this.OrdenIngresos = new HashSet<OrdenIngreso>();
        }
    
        public short IdEmpresaTransporte { get; set; }
        public string NombreEmpresaTransporte { get; set; }
        public string CodigoEmpresaTransporte { get; set; }
        public byte IdTipoTransporte { get; set; }
    
        public virtual TipoTransporte TipoTransporte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenIngreso> OrdenIngresos { get; set; }
    }
}
