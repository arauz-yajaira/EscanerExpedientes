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
    
    public partial class EMPLEADO_EVALUACION_CONTROL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLEADO_EVALUACION_CONTROL()
        {
            this.EMPLEADO_EVALUACION_FACTORES = new HashSet<EMPLEADO_EVALUACION_FACTORES>();
            this.EMPLEADO_EVALUACION_RESPUESTAS = new HashSet<EMPLEADO_EVALUACION_RESPUESTAS>();
        }
    
        public string CODIGO_BIC { get; set; }
        public string CUESTIONARIO { get; set; }
        public System.DateTime FECHA_DE_EVALUACION { get; set; }
        public Nullable<System.DateTime> LH7f4A { get; set; }
        public Nullable<System.DateTime> LH7f5A { get; set; }
        public Nullable<int> CALIFICACION_DE_LA_EVALUA { get; set; }
        public string OBSERVACIONES { get; set; }
        public string ESTADO_DE_LA_EVALUACION { get; set; }
        public string EVALUADOR_CODIGO_BIC { get; set; }
    
        public virtual CUESTIONARIO_EVALUACION_CONTROL CUESTIONARIO_EVALUACION_CONTROL { get; set; }
        public virtual EMPLEADO_TABLA EMPLEADO_TABLA { get; set; }
        public virtual EMPLEADO_TABLA EMPLEADO_TABLA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_EVALUACION_FACTORES> EMPLEADO_EVALUACION_FACTORES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_EVALUACION_RESPUESTAS> EMPLEADO_EVALUACION_RESPUESTAS { get; set; }
    }
}
