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
    
    public partial class TRN_PRESUPUESTO_PRIVADA_DET
    {
        public string PREFIJO_PARTIDA_CONTABLE { get; set; }
        public int NUMERO_DE_PARTIDA { get; set; }
        public string CODIGO_DE_CUENTA { get; set; }
        public string CODIGO_DE_MONEDA { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_01 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_02 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_03 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_04 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_05 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_06 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_07 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_08 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_09 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_10 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_11 { get; set; }
        public Nullable<decimal> DEBITO_PRESUPUESTO_12 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_01 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_02 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_03 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_04 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_05 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_06 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_07 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_08 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_09 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_10 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_11 { get; set; }
        public Nullable<decimal> CREDITO_PRESUPUESTO_12 { get; set; }
        public string COMENTARIOS { get; set; }
        public Nullable<System.DateTime> HORA_ADICION { get; set; }
        public Nullable<System.DateTime> FECHA_ADICION { get; set; }
        public string USUARIO_ADICION { get; set; }
        public Nullable<System.DateTime> HORA_ULTIMO_CAMBIO { get; set; }
        public Nullable<System.DateTime> FECHA_ULTIMO_CAMBIO { get; set; }
        public string USUARIO_ULTIMO_CAMBIO { get; set; }
    
        public virtual CATALOGO_DE_CUENTAS CATALOGO_DE_CUENTAS { get; set; }
        public virtual MONEDA_TABLA MONEDA_TABLA { get; set; }
        public virtual TRN_PRESUPUESTO_PRIVADA_CTL TRN_PRESUPUESTO_PRIVADA_CTL { get; set; }
    }
}
