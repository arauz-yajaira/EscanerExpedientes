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
    
    public partial class CONCILIACION_BANCARIA_DET
    {
        public string CODIGO_BIC { get; set; }
        public string CUENTA_BANCARIA { get; set; }
        public int ANO_DEL_PERIODO { get; set; }
        public int NUMERO_DEL_PERIODO { get; set; }
        public decimal NUMERO_REGISTRO_CONCILIAC { get; set; }
        public string PREFIJO_PARTIDA_CONTABLE { get; set; }
        public string DOCUMENTO_CONTABLE { get; set; }
        public Nullable<System.DateTime> FECHA_CONTABLE { get; set; }
        public Nullable<decimal> DEBITO_CONTABLE { get; set; }
        public Nullable<decimal> CREDITO_CONTABLE { get; set; }
        public Nullable<System.DateTime> FECHA_IMPORTADO { get; set; }
        public Nullable<decimal> DEBITO_IMPORTADO { get; set; }
        public Nullable<decimal> CREDITO_IMPORTADO { get; set; }
        public string TEXTO_CONCILIACION { get; set; }
        public string ORIGEN_REGISTRO_CONCILIAC { get; set; }
        public string ESTADO_CONCILIACION { get; set; }
    
        public virtual CONCILIACION_BANCARIA_CTL CONCILIACION_BANCARIA_CTL { get; set; }
        public virtual NUMERACION_PARTIDAS NUMERACION_PARTIDAS { get; set; }
    }
}
