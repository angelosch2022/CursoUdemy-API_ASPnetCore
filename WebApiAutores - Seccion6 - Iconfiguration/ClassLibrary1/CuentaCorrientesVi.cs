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
    
    public partial class CuentaCorrientesVi
    {
        public System.DateTime FechaFacturacion { get; set; }
        public int IdContrato { get; set; }
        public int IdFacturado { get; set; }
        public decimal Importe { get; set; }
        public int IdClienteFacturado { get; set; }
        public string NombreClienteFacturado { get; set; }
        public string Serie { get; set; }
        public string Numdoc { get; set; }
        public string NombreClienteContrato { get; set; }
        public int IdClienteContrato { get; set; }
        public string NumeroContrato { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public int IdCuentaCorriente { get; set; }
        public byte IdTipoDocIdentidadFacturado { get; set; }
        public string NumeroDocIdentidadFacturado { get; set; }
        public string NombreCortoTipoDocIdentidadFacturado { get; set; }
        public byte IdTipoDocIdentidadContrato { get; set; }
        public string NumeroDocIdentidadContrato { get; set; }
        public string NombreCortoTipoDocIdentidadContrato { get; set; }
        public short IdMonedaContrato { get; set; }
        public short IdMonedaFacturado { get; set; }
        public string DetalleFac { get; set; }
        public Nullable<System.DateTime> FechaTermino { get; set; }
        public bool IsAnulado { get; set; }
        public Nullable<System.DateTime> FechaResolucion { get; set; }
    }
}
