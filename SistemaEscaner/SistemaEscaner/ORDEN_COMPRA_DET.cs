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
    
    public partial class ORDEN_COMPRA_DET
    {
        public int NUMERO_ORDEN_DE_COMPRA { get; set; }
        public int NUMERO_DE_LINEA { get; set; }
        public string CODIGO_DE_ARTICULO { get; set; }
        public Nullable<decimal> CANTIDAD_A_COMPRAR { get; set; }
        public Nullable<decimal> VALOR_TOTAL { get; set; }
        public string IMPUESTO_INCLUIDO { get; set; }
        public string COMENTARIOS { get; set; }
        public string EXENTA { get; set; }
        public Nullable<int> NUMERO_DE_COTIZACION { get; set; }
        public string CODIGO_BIC { get; set; }
        public string NUMERO_DE_RESOLUCION_DEI { get; set; }
        public Nullable<int> LINEA { get; set; }
    
        public virtual ARTICULO_TABLA ARTICULO_TABLA { get; set; }
        public virtual ORDEN_COMPRA_CTRL ORDEN_COMPRA_CTRL { get; set; }
    }
}
