//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaEscaner
{
    using System;
    using System.Collections.Generic;
    
    public partial class recideta
    {
        public decimal NUMERO_RECIBO_HOSPITALARI { get; set; }
        public decimal LINEA_DEL_RECIBO { get; set; }
        public string SERVICIO_HOSPITALARIO { get; set; }
        public Nullable<decimal> CANTIDAD_DEL_DETALLE { get; set; }
        public Nullable<decimal> CUOTA_DE_RECUPERACION_A_P { get; set; }
        public Nullable<decimal> CUOTA_DE_RECUPERACION_PAG { get; set; }
        public string CODIGO_ORIGEN_DEL_FONDO { get; set; }
        public Nullable<decimal> VALOR_DISTRIBUCION { get; set; }
        public string CODIGO_SUBSIDIO { get; set; }
        public string ESTATUS_DEL_SERVICIO { get; set; }
    }
}
