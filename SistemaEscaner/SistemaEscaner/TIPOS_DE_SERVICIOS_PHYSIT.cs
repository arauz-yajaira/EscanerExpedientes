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
    
    public partial class TIPOS_DE_SERVICIOS_PHYSIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOS_DE_SERVICIOS_PHYSIT()
        {
            this.CONTRATO_SERVICIOS_NEG_ESP = new HashSet<CONTRATO_SERVICIOS_NEG_ESP>();
            this.DETALLE_DEL_SERVICIO_PHYT = new HashSet<DETALLE_DEL_SERVICIO_PHYT>();
        }
    
        public string CODIGO_DE_SERVICIO { get; set; }
        public string CODIGO_TIPO_SERVICIO { get; set; }
        public string DESCRIPCION_TIPO_SERVICIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_SERVICIOS_NEG_ESP> CONTRATO_SERVICIOS_NEG_ESP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_DEL_SERVICIO_PHYT> DETALLE_DEL_SERVICIO_PHYT { get; set; }
        public virtual SERVICIOS_PHYSICAL_TABLE SERVICIOS_PHYSICAL_TABLE { get; set; }
    }
}
