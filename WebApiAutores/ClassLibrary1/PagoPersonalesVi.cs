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
    
    public partial class PagoPersonalesVi
    {
        public int IdPagoPersonal { get; set; }
        public System.DateTime FechaProg { get; set; }
        public short IdEmpleado { get; set; }
        public decimal Importe { get; set; }
        public decimal Pagado { get; set; }
        public decimal Saldo { get; set; }
        public string Observacion { get; set; }
        public bool IsAprobado { get; set; }
        public bool IsAnulado { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string NombreEmpleado { get; set; }
        public short IdGrupoPago { get; set; }
        public string NombreGrupoPago { get; set; }
        public string NombreMotivoAnulPagoPersonal { get; set; }
        public string NombreUsuario { get; set; }
        public short IdUsuario { get; set; }
        public short IdMotivoAnulPagoPersonal { get; set; }
    }
}
