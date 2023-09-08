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
    
    public partial class OrdenCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenCompra()
        {
            this.DetOrdenCompras = new HashSet<DetOrdenCompra>();
        }
    
        public int IdOrdenCompra { get; set; }
        public string Correla { get; set; }
        public int IdEmpleado { get; set; }
        public short IdSeccion { get; set; }
        public bool IsEmailEnviado { get; set; }
        public int IdProveedor { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal PorcIgv { get; set; }
        public decimal MontoIgv { get; set; }
        public decimal Monto { get; set; }
        public short IdMoneda { get; set; }
        public byte IdCondicionPago { get; set; }
        public short IdMedioPago { get; set; }
        public string CotizacionReferencial { get; set; }
        public string Observacion { get; set; }
        public bool IsAprobado { get; set; }
        public int Estado { get; set; }
        public bool IsAnulado { get; set; }
        public short IdMotivoAnulOc { get; set; }
        public int IdRequriemientoProducto { get; set; }
        public System.DateTime FechaReg { get; set; }
        public short IdUsuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetOrdenCompra> DetOrdenCompras { get; set; }
        public virtual MedioPago MedioPago { get; set; }
        public virtual Moneda Moneda { get; set; }
        public virtual MotivoAnulOc MotivoAnulOc { get; set; }
        public virtual Proveedore Proveedore { get; set; }
        public virtual RequerimientoProducto RequerimientoProducto { get; set; }
        public virtual Seccione Seccione { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}