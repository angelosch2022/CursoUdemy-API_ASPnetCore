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
    
    public partial class DetOrdenCompra
    {
        public int IdDetOrdenCompra { get; set; }
        public int IdOrdenCompra { get; set; }
        public int IdArticulo { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal PorcIgv { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal CantidadPendiente { get; set; }
    
        public virtual Articulo Articulo { get; set; }
        public virtual OrdenCompra OrdenCompra { get; set; }
    }
}