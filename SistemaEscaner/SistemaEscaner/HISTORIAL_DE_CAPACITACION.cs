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
    
    public partial class HISTORIAL_DE_CAPACITACION
    {
        public string CODIGO_BIC { get; set; }
        public string CODIGO_DE_CURSO { get; set; }
        public System.DateTime FECHA_DEL_CURSO_RECIBIDO { get; set; }
        public Nullable<decimal> COSTO_TOTAL_CURSO { get; set; }
        public Nullable<decimal> COSTO_PARA_COMPANIA_CURSO { get; set; }
        public Nullable<decimal> HORAS_DE_ESTUDIO_CURSO { get; set; }
        public Nullable<int> ASISTENCIAS_CURSO { get; set; }
        public Nullable<int> FALTAS_JUSTIFICADAS_CURSO { get; set; }
        public Nullable<int> FALTAS_NO_JUSTIFICADAS_CU { get; set; }
        public Nullable<int> LLEGADAS_TARDE_CURSO { get; set; }
        public Nullable<decimal> CALIFICACION_CURSO { get; set; }
        public string ESTATUS_CURSO_EMPLEADO { get; set; }
        public string INSTRUCTOR_CODIGO_BIC { get; set; }
        public string CODIGO_CENTRO_CAPACITACIO { get; set; }
    
        public virtual CURSO_DE_CAPACITACION_PHT CURSO_DE_CAPACITACION_PHT { get; set; }
        public virtual EMPLEADO_TABLA EMPLEADO_TABLA { get; set; }
    }
}
