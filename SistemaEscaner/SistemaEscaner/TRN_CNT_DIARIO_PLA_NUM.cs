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
    
    public partial class TRN_CNT_DIARIO_PLA_NUM
    {
        public string CODIGO_CLASE_DE_PLANILLA { get; set; }
        public string CODIGO_TIPO_DE_PLANILLA { get; set; }
        public int ANO_PLANILLA { get; set; }
        public int PERIODO_PLANILLA { get; set; }
        public string CODIGO_DEF_TRN_PLANILLA { get; set; }
        public string OBF007 { get; set; }
        public Nullable<int> LAST_NUMERO_TRN_DIARIO_DE { get; set; }
    
        public virtual DEF_TRN_PLA_CTL DEF_TRN_PLA_CTL { get; set; }
        public virtual PERIODO_DE_PLANILLA PERIODO_DE_PLANILLA { get; set; }
    }
}
