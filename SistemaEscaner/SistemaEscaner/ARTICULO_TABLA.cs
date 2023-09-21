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
    
    public partial class ARTICULO_TABLA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTICULO_TABLA()
        {
            this.ARTICULO_AGRUPACION = new HashSet<ARTICULO_AGRUPACION>();
            this.ARTICULO_BODEGA_PRES = new HashSet<ARTICULO_BODEGA_PRES>();
            this.ARTICULO_PRESUPUESTO_TRIT = new HashSet<ARTICULO_PRESUPUESTO_TRIT>();
            this.ARTICULO_REQUISICION = new HashSet<ARTICULO_REQUISICION>();
            this.ARTICULOS_ALTERNOS = new HashSet<ARTICULOS_ALTERNOS>();
            this.COMPRA_DETALLE = new HashSet<COMPRA_DETALLE>();
            this.ENSAMBLE_DE_ARTICULO = new HashSet<ENSAMBLE_DE_ARTICULO>();
            this.FACTURA_DIARIA_DETALLE = new HashSet<FACTURA_DIARIA_DETALLE>();
            this.LISTA_DE_PRECIO_DETALLE = new HashSet<LISTA_DE_PRECIO_DETALLE>();
            this.MATERIA_PRIMA_Y_MAT_DET = new HashSet<MATERIA_PRIMA_Y_MAT_DET>();
            this.ORDEN_COMPRA_DET = new HashSet<ORDEN_COMPRA_DET>();
            this.ORDEN_DE_TRABAJO_DETALLE = new HashSet<ORDEN_DE_TRABAJO_DETALLE>();
            this.PACIENTE_CRONICO_CONTROL = new HashSet<PACIENTE_CRONICO_CONTROL>();
            this.RECETA_MASIVA_MEDICAM6HXT = new HashSet<RECETA_MASIVA_MEDICAM6HXT>();
            this.RECETA_PLANTILLA_MEDICAMT = new HashSet<RECETA_PLANTILLA_MEDICAMT>();
            this.RECETA_TABLA = new HashSet<RECETA_TABLA>();
            this.RECETAS_SIN_DESPACHAR = new HashSet<RECETAS_SIN_DESPACHAR>();
            this.REQUISICION_DETALLE = new HashSet<REQUISICION_DETALLE>();
            this.TRANSFERENCIA_INVENTA3E4T = new HashSet<TRANSFERENCIA_INVENTA3E4T>();
            this.TRN_INVENTARIO_HIST_DET = new HashSet<TRN_INVENTARIO_HIST_DET>();
            this.IMPUESTOS_TABLA = new HashSet<IMPUESTOS_TABLA>();
            this.ARTICULO_TABLA1 = new HashSet<ARTICULO_TABLA>();
            this.ARTICULO_TABLA2 = new HashSet<ARTICULO_TABLA>();
        }
    
        public string CODIGO_DE_ARTICULO { get; set; }
        public string NOMBRE_DEL_ARTICULO { get; set; }
        public string DESCRIPCION_DEL_ARTICULO { get; set; }
        public string NOMBRE_CORTO_DEL_ARTICULO { get; set; }
        public string TIPO_DE_ARTICULO { get; set; }
        public string ESTATUS_DEL_ARTICULO { get; set; }
        public string CODIGO_TIPO_INVENTARIO { get; set; }
        public string SUBTIPO_DE_INVENTARIO { get; set; }
        public string SUBSUBTIPO_DE_INVENTARIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULO_AGRUPACION> ARTICULO_AGRUPACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULO_BODEGA_PRES> ARTICULO_BODEGA_PRES { get; set; }
        public virtual ARTICULO_DESC_ADIC ARTICULO_DESC_ADIC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULO_PRESUPUESTO_TRIT> ARTICULO_PRESUPUESTO_TRIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULO_REQUISICION> ARTICULO_REQUISICION { get; set; }
        public virtual TIPO_INVENTARIO TIPO_INVENTARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULOS_ALTERNOS> ARTICULOS_ALTERNOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_DETALLE> COMPRA_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENSAMBLE_DE_ARTICULO> ENSAMBLE_DE_ARTICULO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA_DIARIA_DETALLE> FACTURA_DIARIA_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LISTA_DE_PRECIO_DETALLE> LISTA_DE_PRECIO_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATERIA_PRIMA_Y_MAT_DET> MATERIA_PRIMA_Y_MAT_DET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEN_COMPRA_DET> ORDEN_COMPRA_DET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEN_DE_TRABAJO_DETALLE> ORDEN_DE_TRABAJO_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PACIENTE_CRONICO_CONTROL> PACIENTE_CRONICO_CONTROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETA_MASIVA_MEDICAM6HXT> RECETA_MASIVA_MEDICAM6HXT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETA_PLANTILLA_MEDICAMT> RECETA_PLANTILLA_MEDICAMT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETA_TABLA> RECETA_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETAS_SIN_DESPACHAR> RECETAS_SIN_DESPACHAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISICION_DETALLE> REQUISICION_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFERENCIA_INVENTA3E4T> TRANSFERENCIA_INVENTA3E4T { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRN_INVENTARIO_HIST_DET> TRN_INVENTARIO_HIST_DET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMPUESTOS_TABLA> IMPUESTOS_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULO_TABLA> ARTICULO_TABLA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULO_TABLA> ARTICULO_TABLA2 { get; set; }
    }
}
