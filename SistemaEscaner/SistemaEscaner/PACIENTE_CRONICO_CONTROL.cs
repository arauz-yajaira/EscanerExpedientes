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
    
    public partial class PACIENTE_CRONICO_CONTROL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PACIENTE_CRONICO_CONTROL()
        {
            this.PACIENTE_CRONICO_DETALLT = new HashSet<PACIENTE_CRONICO_DETALLT>();
        }
    
        public int EXPEDIENTE { get; set; }
        public string CODIGO_DE_ARTICULO { get; set; }
        public string DIAGNOSTICO { get; set; }
        public Nullable<int> TOTAL_DE_CITAS { get; set; }
        public Nullable<System.DateTime> FECHA_PROXIMA_CITA { get; set; }
        public string ESTATUS_DEL_PACIENTE_CRON { get; set; }
    
        public virtual ARTICULO_TABLA ARTICULO_TABLA { get; set; }
        public virtual PACIENTE PACIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PACIENTE_CRONICO_DETALLT> PACIENTE_CRONICO_DETALLT { get; set; }
    }
}
