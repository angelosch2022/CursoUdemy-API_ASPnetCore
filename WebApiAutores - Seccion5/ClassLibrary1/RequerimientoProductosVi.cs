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
    
    public partial class RequerimientoProductosVi
    {
        public int IdRequerimientoProducto { get; set; }
        public System.DateTime FechaRequerimiento { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public short IdEmpleado { get; set; }
        public short IdSeccion { get; set; }
        public decimal MontoTotalReferencial { get; set; }
        public string Observacion { get; set; }
        public System.DateTime FechaReg { get; set; }
        public short IdUsuario { get; set; }
        public string NombreEmpleado { get; set; }
        public string NombreCargo { get; set; }
        public short IdCargo { get; set; }
        public string NombreSeccion { get; set; }
        public string NombreSubArea { get; set; }
        public short IdSubArea { get; set; }
        public short IdArea { get; set; }
        public string NombreArea { get; set; }
        public string NumReqProd { get; set; }
        public bool IsAnulado { get; set; }
        public bool IsAprobado { get; set; }
        public bool IsAtendido { get; set; }
        public string NombreUsuario { get; set; }
    }
}