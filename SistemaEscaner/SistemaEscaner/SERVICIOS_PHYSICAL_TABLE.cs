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
    
    public partial class SERVICIOS_PHYSICAL_TABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICIOS_PHYSICAL_TABLE()
        {
            this.CONTRATO_SERVICIOS_NEG_ESP = new HashSet<CONTRATO_SERVICIOS_NEG_ESP>();
            this.TIPOS_DE_SERVICIOS_PHYSIT = new HashSet<TIPOS_DE_SERVICIOS_PHYSIT>();
        }
    
        public string CODIGO_DE_SERVICIO { get; set; }
        public string NOMBRE_DEL_SERVICIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_SERVICIOS_NEG_ESP> CONTRATO_SERVICIOS_NEG_ESP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIPOS_DE_SERVICIOS_PHYSIT> TIPOS_DE_SERVICIOS_PHYSIT { get; set; }
    }
}
