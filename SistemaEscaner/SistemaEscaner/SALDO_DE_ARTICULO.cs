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
    
    public partial class SALDO_DE_ARTICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SALDO_DE_ARTICULO()
        {
            this.ARTICULO_LOTE_SERIE = new HashSet<ARTICULO_LOTE_SERIE>();
            this.INVENTARIO_FISICO = new HashSet<INVENTARIO_FISICO>();
            this.TRN_INVENTARIO_HIST_DET = new HashSet<TRN_INVENTARIO_HIST_DET>();
        }
    
        public string CODIGO_DE_ARTICULO { get; set; }
        public int ANO_DE_INVENTARIO { get; set; }
        public string CODIGO_DE_BODEGA { get; set; }
        public string CODIGO_DE_EMPAQUE { get; set; }
        public string CODIGO_UNIDAD_DE_MEDIDA { get; set; }
        public Nullable<decimal> SALDO_INICIAL_MONEDA_FINA { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_1 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_2 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_3 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_4 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_5 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_6 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_7 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_8 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_9 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_10 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_11 { get; set; }
        public Nullable<decimal> DBT_MON_FIN_12_12 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_1 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_2 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_3 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_4 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_5 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_6 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_7 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_8 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_9 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_10 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_11 { get; set; }
        public Nullable<decimal> CRD_MON_FIN_12_12 { get; set; }
        public Nullable<decimal> SALDO_INICIAL_MONEDA_REEX { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_1 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_2 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_3 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_4 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_5 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_6 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_7 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_8 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_9 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_10 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_11 { get; set; }
        public Nullable<decimal> DBT_MON_REEXP_12_12 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_1 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_2 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_3 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_4 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_5 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_6 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_7 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_8 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_9 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_10 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_11 { get; set; }
        public Nullable<decimal> CRD_MON_REEXP_12_12 { get; set; }
        public Nullable<decimal> SALDO_INICIAL_UNIDADES { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_1 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_2 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_3 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_4 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_5 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_6 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_7 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_8 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_9 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_10 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_11 { get; set; }
        public Nullable<decimal> DEBITO_UNIDADES_12_12 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_1 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_2 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_3 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_4 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_5 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_6 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_7 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_8 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_9 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_10 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_11 { get; set; }
        public Nullable<decimal> CREDITO_UNIDADES_12_12 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULO_LOTE_SERIE> ARTICULO_LOTE_SERIE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIO_FISICO> INVENTARIO_FISICO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRN_INVENTARIO_HIST_DET> TRN_INVENTARIO_HIST_DET { get; set; }
    }
}
