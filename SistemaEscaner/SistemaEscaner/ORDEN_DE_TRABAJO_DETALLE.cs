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
    
    public partial class ORDEN_DE_TRABAJO_DETALLE
    {
        public string PREFIJO_PARTIDA_CONTABLE { get; set; }
        public int NUMERO_DE_SERVICIO { get; set; }
        public int NUMERO_DE_LINEA { get; set; }
        public string CODIGO_DE_ARTICULO { get; set; }
        public string CODIGO_DE_BODEGA { get; set; }
        public string CODIGO_DE_EMPAQUE { get; set; }
        public string CODIGO_UNIDAD_DE_MEDIDA { get; set; }
        public Nullable<decimal> CANTIDAD_ENTREGADA { get; set; }
        public string TECNICO_CODIGO_BIC { get; set; }
        public string VENDEDOR_CODIGO_BIC { get; set; }
        public string OBSERVACIONES { get; set; }
        public Nullable<decimal> PRECIO_DE_VENTA { get; set; }
        public Nullable<decimal> PORCENTAJE_DEL_IMPUESTO { get; set; }
        public Nullable<decimal> VALOR_DEL_IMPUESTO { get; set; }
    
        public virtual ARTICULO_BODEGA_PRES ARTICULO_BODEGA_PRES { get; set; }
        public virtual ARTICULO_TABLA ARTICULO_TABLA { get; set; }
        public virtual BODEGA_TABLA BODEGA_TABLA { get; set; }
        public virtual ORDEN_DE_TRABAJO_CONTROL ORDEN_DE_TRABAJO_CONTROL { get; set; }
    }
}
