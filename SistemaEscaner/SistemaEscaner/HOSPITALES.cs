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
    
    public partial class HOSPITALES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOSPITALES()
        {
            this.ARTICULO_PRESUPUESTO_TRIT = new HashSet<ARTICULO_PRESUPUESTO_TRIT>();
        }
    
        public string CODIGO_DEL_HOSPITAL { get; set; }
        public string NOMBRE_DEL_HOSPITAL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULO_PRESUPUESTO_TRIT> ARTICULO_PRESUPUESTO_TRIT { get; set; }
    }
}
