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
    
    public partial class CENTRO_DE_COSTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CENTRO_DE_COSTO()
        {
            this.ARTICULO_REQUISICION = new HashSet<ARTICULO_REQUISICION>();
            this.DISTRIBUCION_COSTOS_INDIRECTOS = new HashSet<DISTRIBUCION_COSTOS_INDIRECTOS>();
            this.ORDEN_ATENCION_MEDICA_CTL = new HashSet<ORDEN_ATENCION_MEDICA_CTL>();
            this.RECETA_MASIVA_MEDICAMENTT = new HashSet<RECETA_MASIVA_MEDICAMENTT>();
            this.RECETA_TABLA = new HashSet<RECETA_TABLA>();
            this.RECETAS_SIN_DESPACHAR = new HashSet<RECETAS_SIN_DESPACHAR>();
            this.REQUISICION_CONTROL = new HashSet<REQUISICION_CONTROL>();
            this.REQUISICION_DETALLE = new HashSet<REQUISICION_DETALLE>();
        }
    
        public string CODIGO_CENTRO_DE_COSTO { get; set; }
        public string NOMBRE_CENTRO_DE_COSTO { get; set; }
        public string ABREVIATURA_CENTRO_DE_COS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULO_REQUISICION> ARTICULO_REQUISICION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISTRIBUCION_COSTOS_INDIRECTOS> DISTRIBUCION_COSTOS_INDIRECTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEN_ATENCION_MEDICA_CTL> ORDEN_ATENCION_MEDICA_CTL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETA_MASIVA_MEDICAMENTT> RECETA_MASIVA_MEDICAMENTT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETA_TABLA> RECETA_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETAS_SIN_DESPACHAR> RECETAS_SIN_DESPACHAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISICION_CONTROL> REQUISICION_CONTROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISICION_DETALLE> REQUISICION_DETALLE { get; set; }
    }
}
