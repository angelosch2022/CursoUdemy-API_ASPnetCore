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
    
    public partial class ContratoNave
    {
        public short IdContratoNave { get; set; }
        public int IdContrato { get; set; }
        public short IdNave { get; set; }
    
        public virtual Contrato Contrato { get; set; }
        public virtual Nave Nave { get; set; }
    }
}