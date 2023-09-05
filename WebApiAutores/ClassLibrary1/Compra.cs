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
    
    public partial class Compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compra()
        {
            this.ComprobanteEgresos = new HashSet<ComprobanteEgreso>();
            this.DetBancoCobroPagos = new HashSet<DetBancoCobroPago>();
            this.DetCompras = new HashSet<DetCompra>();
        }
    
        public int IdCompra { get; set; }
        public byte IdTipoComprobantePago { get; set; }
        public string Serie { get; set; }
        public string Numdoc { get; set; }
        public int IdOrdenCompra { get; set; }
        public int IdOrdenServicio { get; set; }
        public int IdProveedor { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public int DiasCredito { get; set; }
        public System.DateTime FechaVcto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal MontoIgv { get; set; }
        public decimal NoGravado { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Percepcion { get; set; }
        public decimal Importe { get; set; }
        public decimal Pagado { get; set; }
        public decimal Saldo { get; set; }
        public decimal MontoAPagar { get; set; }
        public decimal TipoCambio { get; set; }
        public short IdMedioPago { get; set; }
        public byte IdCondicionPago { get; set; }
        public short IdMoneda { get; set; }
        public string Observacion { get; set; }
        public bool IsCerrada { get; set; }
        public bool IsPagoAprobado { get; set; }
        public bool IsAnulado { get; set; }
        public short IdSeccion { get; set; }
        public short IdCentroCosto { get; set; }
        public decimal ImporteDetraccion { get; set; }
        public System.DateTime FechaPagoDetraccion { get; set; }
        public short IdCuentaContabeDetraccion { get; set; }
        public System.DateTime FechaReg { get; set; }
        public short IdUsuario { get; set; }
    
        public virtual CentroCosto CentroCosto { get; set; }
        public virtual CondicionPago CondicionPago { get; set; }
        public virtual CuentaContable CuentaContable { get; set; }
        public virtual MedioPago MedioPago { get; set; }
        public virtual Moneda Moneda { get; set; }
        public virtual Proveedore Proveedore { get; set; }
        public virtual TipoComprobantePago TipoComprobantePago { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComprobanteEgreso> ComprobanteEgresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetBancoCobroPago> DetBancoCobroPagos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetCompra> DetCompras { get; set; }
    }
}