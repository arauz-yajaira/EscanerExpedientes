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
    
    public partial class CUENTA_DE_BANCO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUENTA_DE_BANCO()
        {
            this.CHEQUES_NO_CONCILIADOS = new HashSet<CHEQUES_NO_CONCILIADOS>();
            this.CONCILIACION_BANCARIA_CTL = new HashSet<CONCILIACION_BANCARIA_CTL>();
            this.SALDO_EN_BANCOS_PHYSICAT = new HashSet<SALDO_EN_BANCOS_PHYSICAT>();
        }
    
        public string CODIGO_BIC { get; set; }
        public string CUENTA_BANCARIA { get; set; }
        public string NUMERO_DE_CUENTA_BANCARIA { get; set; }
        public string DESCRIPCION_CUENTA_BANCAR { get; set; }
        public string ABREVIATURA_CUENTA_BANCAR { get; set; }
        public string TIPO_CUENTA_BANCARIA { get; set; }
        public string CODIGO_DE_MONEDA { get; set; }
        public string CODIGO_DE_CUENTA { get; set; }
        public string NUMERO_DE_CHEQUE_PREFIJO { get; set; }
        public string NUMERO_DE_DEPOSITO_PREFIJ { get; set; }
        public string NUMERO_NOTA_DEBITO_PREFIJ { get; set; }
        public string NUMERO_NOTA_CREDITO_PREFI { get; set; }
        public string TRANSFERENCIA_RECIBIDA_PR { get; set; }
        public string TRANSFERENCIA_ENVIADA_PRE { get; set; }
        public string OTROS_DEBITOS_PREFIJO_PAR { get; set; }
        public string OTROS_CREDITOS_PREFIJO_PA { get; set; }
    
        public virtual BANCO_TABLA BANCO_TABLA { get; set; }
        public virtual CATALOGO_DE_CUENTAS CATALOGO_DE_CUENTAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHEQUES_NO_CONCILIADOS> CHEQUES_NO_CONCILIADOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONCILIACION_BANCARIA_CTL> CONCILIACION_BANCARIA_CTL { get; set; }
        public virtual MONEDA_TABLA MONEDA_TABLA { get; set; }
        public virtual NUMERACION_PARTIDAS NUMERACION_PARTIDAS { get; set; }
        public virtual NUMERACION_PARTIDAS NUMERACION_PARTIDAS1 { get; set; }
        public virtual NUMERACION_PARTIDAS NUMERACION_PARTIDAS2 { get; set; }
        public virtual NUMERACION_PARTIDAS NUMERACION_PARTIDAS3 { get; set; }
        public virtual TIPO_CUENTA_EN_BANCO TIPO_CUENTA_EN_BANCO { get; set; }
        public virtual ESTRUCTURA_ESTADO_CUENTA ESTRUCTURA_ESTADO_CUENTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALDO_EN_BANCOS_PHYSICAT> SALDO_EN_BANCOS_PHYSICAT { get; set; }
    }
}
