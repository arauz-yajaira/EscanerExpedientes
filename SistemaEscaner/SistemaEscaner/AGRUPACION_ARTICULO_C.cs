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
    
    public partial class AGRUPACION_ARTICULO_C
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AGRUPACION_ARTICULO_C()
        {
            this.AGRUPACION_ARTICULO_D = new HashSet<AGRUPACION_ARTICULO_D>();
            this.ARTICULO_AGRUPACION = new HashSet<ARTICULO_AGRUPACION>();
        }
    
        public string CODIGO_DE_AGRUPACION { get; set; }
        public string NOMBRE_DE_AGRUPACION { get; set; }
        public string ABREVIATURA_DE_AGRUPACION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGRUPACION_ARTICULO_D> AGRUPACION_ARTICULO_D { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULO_AGRUPACION> ARTICULO_AGRUPACION { get; set; }
    }
}
