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
    
    public partial class SERVICIO_HOSPITAL_COMPONENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICIO_HOSPITAL_COMPONENTE()
        {
            this.SERVICIOS_HOSPITAL_COMPONENTEART = new HashSet<SERVICIOS_HOSPITAL_COMPONENTEART>();
            this.SERVICIOS_HOSPITAL_COMPONENTECTO = new HashSet<SERVICIOS_HOSPITAL_COMPONENTECTO>();
        }
    
        public string SERVICIO_HOSPITALARIO { get; set; }
        public string LH6zaA { get; set; }
        public string TIENE_ARTICULOS { get; set; }
        public Nullable<System.DateTime> HORA_ADICION { get; set; }
        public Nullable<System.DateTime> FECHA_ADICION { get; set; }
        public string USUARIO_ADICION { get; set; }
        public Nullable<System.DateTime> HORA_ULTIMO_CAMBIO { get; set; }
        public Nullable<System.DateTime> FECHA_ULTIMO_CAMBIO { get; set; }
        public string USUARIO_ULTIMO_CAMBIO { get; set; }
    
        public virtual SERVICIO_HOSPITAL SERVICIO_HOSPITAL { get; set; }
        public virtual TAREAS_HOSPITALARIAS TAREAS_HOSPITALARIAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOS_HOSPITAL_COMPONENTEART> SERVICIOS_HOSPITAL_COMPONENTEART { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOS_HOSPITAL_COMPONENTECTO> SERVICIOS_HOSPITAL_COMPONENTECTO { get; set; }
    }
}
