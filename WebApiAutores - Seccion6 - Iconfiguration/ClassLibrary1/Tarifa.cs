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
    
    public partial class Tarifa
    {
        public int IdTarifa { get; set; }
        public short IdRubro { get; set; }
        public int IdCliente { get; set; }
        public decimal PrecioUnitario { get; set; }
        public short IdMoneda { get; set; }
        public string Observacion { get; set; }
        public System.DateTime FechaReg { get; set; }
        public short IdUsuario { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Rubro Rubro { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
