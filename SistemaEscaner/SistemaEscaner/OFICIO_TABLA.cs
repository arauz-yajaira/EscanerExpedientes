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
    
    public partial class OFICIO_TABLA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OFICIO_TABLA()
        {
            this.EMPLEADO_OFICIO = new HashSet<EMPLEADO_OFICIO>();
        }
    
        public string OFICIO { get; set; }
        public string NOMBRE_DE_OFICIO { get; set; }
        public string ABREVIATURA_DE_OFICIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_OFICIO> EMPLEADO_OFICIO { get; set; }
    }
}
