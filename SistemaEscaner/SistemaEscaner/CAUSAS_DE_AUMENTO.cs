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
    
    public partial class CAUSAS_DE_AUMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAUSAS_DE_AUMENTO()
        {
            this.EMPLEADO_TABLA = new HashSet<EMPLEADO_TABLA>();
            this.HISTORIAL_SALARIAL = new HashSet<HISTORIAL_SALARIAL>();
        }
    
        public string CODIGO_CAUSA_AUMENTO { get; set; }
        public string DESCRIPCION_CAUSA_AUMENTO { get; set; }
        public string ABREVIATURA_CAUSA_AUMENTO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_TABLA> EMPLEADO_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORIAL_SALARIAL> HISTORIAL_SALARIAL { get; set; }
    }
}
