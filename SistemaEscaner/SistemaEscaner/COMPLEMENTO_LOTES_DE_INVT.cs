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
    
    public partial class COMPLEMENTO_LOTES_DE_INVT
    {
        public string DEFINICION_DEL_PROCESO { get; set; }
        public int CORRELATIVO_ICP { get; set; }
        public string CODIGO_DE_ARTICULO { get; set; }
        public int ANO_DE_INVENTARIO { get; set; }
        public string CODIGO_DE_BODEGA { get; set; }
        public string CODIGO_DE_EMPAQUE { get; set; }
        public string CODIGO_UNIDAD_DE_MEDIDA { get; set; }
        public string CODIGO_LOTE_SERIE { get; set; }
        public int LOTE { get; set; }
        public Nullable<decimal> Cantidad_Lote_Usado { get; set; }
        public Nullable<decimal> Costo_Lote_Usado { get; set; }
    
        public virtual ARTICULO_LOTE_SERIE ARTICULO_LOTE_SERIE { get; set; }
        public virtual INFORMACION_CENTRAL INFORMACION_CENTRAL { get; set; }
    }
}
