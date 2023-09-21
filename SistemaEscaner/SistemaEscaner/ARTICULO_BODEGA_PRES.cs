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
    
    public partial class ARTICULO_BODEGA_PRES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTICULO_BODEGA_PRES()
        {
            this.COMPRA_DETALLE = new HashSet<COMPRA_DETALLE>();
            this.FACTURA_DIARIA_DETALLE = new HashSet<FACTURA_DIARIA_DETALLE>();
            this.ORDEN_DE_TRABAJO_DETALLE = new HashSet<ORDEN_DE_TRABAJO_DETALLE>();
            this.REQUISICION_DETALLE = new HashSet<REQUISICION_DETALLE>();
        }
    
        public string CODIGO_DE_ARTICULO { get; set; }
        public string CODIGO_DE_BODEGA { get; set; }
        public string CODIGO_DE_EMPAQUE { get; set; }
        public string CODIGO_UNIDAD_DE_MEDIDA { get; set; }
        public Nullable<decimal> EXISTENCIA_MINIMA { get; set; }
        public Nullable<decimal> EXISTENCIA_MAXIMA { get; set; }
        public Nullable<decimal> LOTE_ECONOMICO { get; set; }
        public Nullable<decimal> PUNTO_DE_REORDEN { get; set; }
        public string CLASIFICACION_ABC { get; set; }
        public Nullable<decimal> DIAS_DE_REABASTECIMIENTO { get; set; }
        public string UBICACION { get; set; }
    
        public virtual ARTICULO_TABLA ARTICULO_TABLA { get; set; }
        public virtual BODEGA_TABLA BODEGA_TABLA { get; set; }
        public virtual PRESENTACION_TABLA PRESENTACION_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_DETALLE> COMPRA_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA_DIARIA_DETALLE> FACTURA_DIARIA_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEN_DE_TRABAJO_DETALLE> ORDEN_DE_TRABAJO_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISICION_DETALLE> REQUISICION_DETALLE { get; set; }
    }
}
