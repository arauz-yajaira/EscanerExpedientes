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
    
    public partial class requicon
    {
        public string DEFINICION_DEL_PROCESO { get; set; }
        public int NUMERO_DE_REQUISICION { get; set; }
        public Nullable<System.DateTime> FECHA_DE_REQUISICION { get; set; }
        public Nullable<System.DateTime> FECHA_DE_APROBACION_REQUI { get; set; }
        public Nullable<System.DateTime> FECHA_DE_DESPACHO_REQUISI { get; set; }
        public string CODIGO_CENTRO_DE_COSTO { get; set; }
        public string CODIGO_DE_DEPARTAMENTO { get; set; }
        public string CODIGO_DE_BODEGA { get; set; }
        public string SOLICITADO_POR_CODIGO_BIC { get; set; }
        public string APROBADO_POR_CODIGO_BIC { get; set; }
        public string DESPACHADO_POR_CODIGO_BIC { get; set; }
        public string ESTATUS_DE_LA_REQUISICION { get; set; }
        public string OBSERVACIONES { get; set; }
        public Nullable<decimal> AÑO_DE_PRESUPUESTO { get; set; }
        public Nullable<int> PERIODO_DEL_PRESUPUESTO { get; set; }
        public string TIPO_DE_REQUISICION { get; set; }
    }
}
