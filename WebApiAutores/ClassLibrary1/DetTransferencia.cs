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
    
    public partial class DetTransferencia
    {
        public int IdDetTransferencia { get; set; }
        public int IdTransferencia { get; set; }
        public int IdArticulo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
    
        public virtual Transferencia Transferencia { get; set; }
    }
}