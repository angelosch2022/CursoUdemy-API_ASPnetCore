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
    
    public partial class MovCajaBancosVi
    {
        public int IdMovCajaBanco { get; set; }
        public System.DateTime FechaMov { get; set; }
        public int IdComprobanteIngreso { get; set; }
        public int IdComprobanteEgreso { get; set; }
        public decimal ImporteIng { get; set; }
        public decimal ImporteEgr { get; set; }
        public bool IsAnuladoCompEgreso { get; set; }
        public bool IsAnuladoCompIngreso { get; set; }
        public string DescripcionEgr { get; set; }
        public string DescripcionIng { get; set; }
        public string NombreMedioPagoIng { get; set; }
        public string NombreMedioPagoEgr { get; set; }
        public string NombreConceptoIng { get; set; }
        public string NombreConceptoEgr { get; set; }
        public string NombreCliente { get; set; }
        public string RazonSocial { get; set; }
        public string NombreEmpleadoEgresos { get; set; }
        public string NombreCajaIng { get; set; }
        public string NombreCajaEgr { get; set; }
        public short IdRubroIng { get; set; }
        public short IdConceptoIng { get; set; }
        public string NombreRubroIng { get; set; }
        public short IdRubroEgr { get; set; }
        public string NombreRubroEgr { get; set; }
        public short IdConceptoEgr { get; set; }
        public string NombreEmpleadoIngresos { get; set; }
        public string NombreUsuarioIngresos { get; set; }
        public short IdUsuarioIngresos { get; set; }
        public string NombreUsuarioEgresos { get; set; }
        public short IdUsuarioEgresos { get; set; }
        public string NumdocComprobanteIngreso { get; set; }
        public string NumdocComprobanteEgreso { get; set; }
        public short IdMoneda { get; set; }
        public short IdMedioPagoCompIngreso { get; set; }
        public short IdCajaCompIngreso { get; set; }
        public short IdMonedaCompEgreso { get; set; }
        public short IdMedioPagoCompEgreso { get; set; }
        public short IdCajaCompEgreso { get; set; }
    }
}