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
    
    public partial class PACIENTE_CRONICOS_OTROHSP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PACIENTE_CRONICOS_OTROHSP()
        {
            this.PACIENTE_CRONICOS_OTROHSD = new HashSet<PACIENTE_CRONICOS_OTROHSD>();
        }
    
        public string CODIGO_DEL_HOSPITAL { get; set; }
        public int EXPEDIENTE { get; set; }
        public string APELLIDO_1_DEL_PACIENTE { get; set; }
        public string APELLIDO_2_DEL_PACIENTE { get; set; }
        public string NOMBRES_DEL_PACIENTE { get; set; }
        public string CODIGO_DE_ARTICULO { get; set; }
        public string NOMBRE_DEL_ARTICULO { get; set; }
        public string DIAGNOSTICO { get; set; }
        public Nullable<int> TOTAL_DE_CITAS { get; set; }
        public Nullable<System.DateTime> FECHA_PROXIMA_CITA { get; set; }
        public string ESTATUS_DEL_PACIENTE_CRON { get; set; }
        public string IDENTIDAD_DEL_PACIENTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PACIENTE_CRONICOS_OTROHSD> PACIENTE_CRONICOS_OTROHSD { get; set; }
    }
}
