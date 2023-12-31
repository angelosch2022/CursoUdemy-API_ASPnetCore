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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.ActaAperturas = new HashSet<ActaApertura>();
            this.Articulos = new HashSet<Articulo>();
            this.AutorizacionRetiros = new HashSet<AutorizacionRetiro>();
            this.BancoCobroPagos = new HashSet<BancoCobroPago>();
            this.Cajas = new HashSet<Caja>();
            this.Clientes = new HashSet<Cliente>();
            this.Compras = new HashSet<Compra>();
            this.ComprobanteEgresos = new HashSet<ComprobanteEgreso>();
            this.ComprobanteIngresos = new HashSet<ComprobanteIngreso>();
            this.Conceptos = new HashSet<Concepto>();
            this.ConstanciaEntregas = new HashSet<ConstanciaEntrega>();
            this.Contratos = new HashSet<Contrato>();
            this.CorrelativoComprobantes = new HashSet<CorrelativoComprobante>();
            this.Cotizaciones = new HashSet<Cotizacione>();
            this.Desgloses = new HashSet<Desglos>();
            this.DetHistorialCotizaciones = new HashSet<DetHistorialCotizacione>();
            this.Empleados = new HashSet<Empleado>();
            this.Facturados = new HashSet<Facturado>();
            this.GuiaRemisions = new HashSet<GuiaRemision>();
            this.InventarioNaves = new HashSet<InventarioNave>();
            this.Inventarios = new HashSet<Inventario>();
            this.ModuloOperaciones = new HashSet<ModuloOperacione>();
            this.NotaCreditos = new HashSet<NotaCredito>();
            this.NotaDebitos = new HashSet<NotaDebito>();
            this.NotaSalidas = new HashSet<NotaSalida>();
            this.OrdenCompras = new HashSet<OrdenCompra>();
            this.OrdenIngresos = new HashSet<OrdenIngreso>();
            this.PagoPersonales = new HashSet<PagoPersonale>();
            this.Pesados = new HashSet<Pesado>();
            this.ReciboHonorarios = new HashSet<ReciboHonorario>();
            this.RequerimientoProductos = new HashSet<RequerimientoProducto>();
            this.Rubros = new HashSet<Rubro>();
            this.ServicioPrestados = new HashSet<ServicioPrestado>();
            this.ServicioPrestados1 = new HashSet<ServicioPrestado>();
            this.Tarifas = new HashSet<Tarifa>();
            this.TipoCambios = new HashSet<TipoCambio>();
            this.TransferenciaNaves = new HashSet<TransferenciaNave>();
            this.Transferencias = new HashSet<Transferencia>();
            this.Vigilancias = new HashSet<Vigilancia>();
        }
    
        public short IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string AliasUsuario { get; set; }
        public string Password { get; set; }
        public string DirectorioReportes { get; set; }
        public string ImpresoraTicketesIngEgr { get; set; }
        public bool ImprimirTicketIngreso { get; set; }
        public short NumCopiasTicketIngreso { get; set; }
        public bool ImprimirTicketEgreso { get; set; }
        public short NumCopiasTicketEgreso { get; set; }
        public string ImpresoraMovBancos { get; set; }
        public bool ImprimirMovBancos { get; set; }
        public short NumCopiasMovBancos { get; set; }
        public System.DateTime FechaReg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActaApertura> ActaAperturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo> Articulos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutorizacionRetiro> AutorizacionRetiros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BancoCobroPago> BancoCobroPagos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja> Cajas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Compras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComprobanteEgreso> ComprobanteEgresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComprobanteIngreso> ComprobanteIngresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Concepto> Conceptos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConstanciaEntrega> ConstanciaEntregas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contratos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CorrelativoComprobante> CorrelativoComprobantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacione> Cotizaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Desglos> Desgloses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetHistorialCotizacione> DetHistorialCotizaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturado> Facturados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuiaRemision> GuiaRemisions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioNave> InventarioNaves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventario> Inventarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModuloOperacione> ModuloOperaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCredito> NotaCreditos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaDebito> NotaDebitos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaSalida> NotaSalidas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenIngreso> OrdenIngresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoPersonale> PagoPersonales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pesado> Pesados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReciboHonorario> ReciboHonorarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequerimientoProducto> RequerimientoProductos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rubro> Rubros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicioPrestado> ServicioPrestados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicioPrestado> ServicioPrestados1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarifa> Tarifas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoCambio> TipoCambios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferenciaNave> TransferenciaNaves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transferencia> Transferencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vigilancia> Vigilancias { get; set; }
    }
}
