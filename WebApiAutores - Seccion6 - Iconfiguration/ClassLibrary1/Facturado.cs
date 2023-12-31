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
    
    public partial class Facturado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturado()
        {
            this.CuentaCorrientes = new HashSet<CuentaCorriente>();
            this.DetBancoCobroPagos = new HashSet<DetBancoCobroPago>();
            this.DetFacturados = new HashSet<DetFacturado>();
            this.DetOrdenIngresoAreas = new HashSet<DetOrdenIngresoArea>();
            this.NotaCreditoFacAplicados = new HashSet<NotaCreditoFacAplicado>();
            this.NotaCreditos = new HashSet<NotaCredito>();
            this.NotaDebitos = new HashSet<NotaDebito>();
            this.ServicioPrestados = new HashSet<ServicioPrestado>();
        }
    
        public int IdFacturado { get; set; }
        public byte IdTipoFacturacion { get; set; }
        public byte IdTipoComprobantePago { get; set; }
        public string Serie { get; set; }
        public string Numdoc { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public int IdCliente { get; set; }
        public string Direccion { get; set; }
        public short IdMoneda { get; set; }
        public decimal TipoCambio { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public byte IdCondicionPago { get; set; }
        public decimal DctoItems { get; set; }
        public decimal DctoPorc { get; set; }
        public decimal DctoTotal { get; set; }
        public decimal Exonerado { get; set; }
        public decimal Inafecto { get; set; }
        public decimal Gravado { get; set; }
        public decimal PorcIgv { get; set; }
        public decimal MontoIgv { get; set; }
        public decimal Anticipo { get; set; }
        public bool IsAnticipo { get; set; }
        public bool IsAnticipoAplicado { get; set; }
        public decimal OtrosCargos { get; set; }
        public decimal Gratuito { get; set; }
        public decimal Total { get; set; }
        public decimal Cobrado { get; set; }
        public decimal Saldo { get; set; }
        public string Observacion { get; set; }
        public bool IsAnulado { get; set; }
        public short IdMotivoAnulComprobante { get; set; }
        public decimal ImporteDetraccion { get; set; }
        public Nullable<System.DateTime> FechaProgDetraccion { get; set; }
        public Nullable<System.DateTime> FechaPagoDetraccion { get; set; }
        public int IdContrato { get; set; }
        public string Mes { get; set; }
        public System.DateTime FechaReg { get; set; }
        public short IdUsuario { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual CondicionPago CondicionPago { get; set; }
        public virtual Contrato Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaCorriente> CuentaCorrientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetBancoCobroPago> DetBancoCobroPagos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetFacturado> DetFacturados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetOrdenIngresoArea> DetOrdenIngresoAreas { get; set; }
        public virtual Moneda Moneda { get; set; }
        public virtual MotivoAnulComprobante MotivoAnulComprobante { get; set; }
        public virtual TipoComprobantePago TipoComprobantePago { get; set; }
        public virtual TipoFacturacione TipoFacturacione { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCreditoFacAplicado> NotaCreditoFacAplicados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCredito> NotaCreditos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaDebito> NotaDebitos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicioPrestado> ServicioPrestados { get; set; }
    }
}
