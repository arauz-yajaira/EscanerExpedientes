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
    
    public partial class TRN_INVENTARIO_HIST_VENCT
    {
        public string DEFINICION_DEL_PROCESO { get; set; }
        public int CORRELATIVO_ICP { get; set; }
        public int CORRELATIVO_INVENTARIO_HI { get; set; }
        public Nullable<System.DateTime> FECHA_VENCE_LOTE { get; set; }
        public string CODIGO_LOTE_SERIE { get; set; }
    
        public virtual TRN_INVENTARIO_HIST_DET TRN_INVENTARIO_HIST_DET { get; set; }
    }
}
