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
    
    public partial class DespachosVi
    {
        public int IdDespacho { get; set; }
        public string Correlativo { get; set; }
        public string NombreRetira { get; set; }
        public string Dni { get; set; }
        public string Placa { get; set; }
        public string Descripcion { get; set; }
        public short IdEntregadoPor { get; set; }
        public string Observacion { get; set; }
        public System.DateTime FechaReg { get; set; }
        public short IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreEmpleado { get; set; }
        public bool IsAprobado { get; set; }
        public bool IsAnulado { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public System.DateTime Fecha { get; set; }
    }
}
