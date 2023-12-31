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
    
    public partial class BancoCobroPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BancoCobroPago()
        {
            this.DetBancoCobroPagos = new HashSet<DetBancoCobroPago>();
        }
    
        public int IdBancoCobroPago { get; set; }
        public string SubDiario { get; set; }
        public bool IsCobro { get; set; }
        public short IdCuentaBanco { get; set; }
        public string NumMov { get; set; }
        public System.DateTime Fecha { get; set; }
        public short IdMoneda { get; set; }
        public decimal TipoCambio { get; set; }
        public short IdRubro { get; set; }
        public bool IsAnulado { get; set; }
        public string CorrelativoManualConcar { get; set; }
        public decimal Importe { get; set; }
        public string Area { get; set; }
        public System.DateTime FechaReg { get; set; }
        public short IdUsuario { get; set; }
    
        public virtual CuentaBanco CuentaBanco { get; set; }
        public virtual Moneda Moneda { get; set; }
        public virtual Rubro Rubro { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetBancoCobroPago> DetBancoCobroPagos { get; set; }
    }
}
