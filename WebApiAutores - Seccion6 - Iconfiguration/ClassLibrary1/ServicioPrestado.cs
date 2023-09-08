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
    
    public partial class ServicioPrestado
    {
        public int IdServicioPrestado { get; set; }
        public string Correlativo { get; set; }
        public byte TipoServicio { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdOrdenIngreso { get; set; }
        public int IdAutorizacionRetiro { get; set; }
        public short IdRubro { get; set; }
        public string Observacion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioNetoUnitatio { get; set; }
        public short IdMoneda { get; set; }
        public decimal ImporteTotal { get; set; }
        public int IdFacturado { get; set; }
        public short IdResponsable { get; set; }
        public System.DateTime FechaReg { get; set; }
        public short IdUsuario { get; set; }
        public short IdUsuarioApruebaAnula { get; set; }
        public bool IsAprobado { get; set; }
        public bool IsAnulado { get; set; }
    
        public virtual AutorizacionRetiro AutorizacionRetiro { get; set; }
        public virtual Facturado Facturado { get; set; }
        public virtual OrdenIngreso OrdenIngreso { get; set; }
        public virtual Rubro Rubro { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}