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
    
    public partial class ReciboHonorariosVi
    {
        public int IdReciboHonorario { get; set; }
        public string Numdoc { get; set; }
        public int IdProveedor { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public decimal Importe { get; set; }
        public decimal ImporteRetenido { get; set; }
        public decimal Pagado { get; set; }
        public decimal Saldo { get; set; }
        public decimal TipoCambio { get; set; }
        public string Glosa { get; set; }
        public string Observacion { get; set; }
        public bool IsAnulado { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string RazonSocial { get; set; }
        public string SimboloMoneda { get; set; }
        public System.DateTime FechaPagoRetencion { get; set; }
        public short IdCuentaContabeRetencion { get; set; }
        public int IdTipoDocIdentidad { get; set; }
        public string NumeroDocIdentidad { get; set; }
        public string CodigoTipoDocIdentidad { get; set; }
        public string NombreCortoTipoDocIdentidad { get; set; }
        public bool IsAprobado { get; set; }
        public bool IsPagoAprobado { get; set; }
        public decimal MontoAPagar { get; set; }
        public short IdCuentaContabeRecibo { get; set; }
        public string NombreUsuario { get; set; }
        public short IdMoneda { get; set; }
        public short IdUsuario { get; set; }
    }
}
