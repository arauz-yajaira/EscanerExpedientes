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
    
    public partial class EMPLEADO_TABLA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLEADO_TABLA()
        {
            this.ACUMULADOS_PLANILLA = new HashSet<ACUMULADOS_PLANILLA>();
            this.CICLO_INVENTARIO_FISICO_T = new HashSet<CICLO_INVENTARIO_FISICO_T>();
            this.COMPRA_TABLA = new HashSet<COMPRA_TABLA>();
            this.DEPENDIENTES_EMPLEADO = new HashSet<DEPENDIENTES_EMPLEADO>();
            this.EMPLEADO_AGRUP = new HashSet<EMPLEADO_AGRUP>();
            this.EMPLEADO_CARNET_ACTIVO = new HashSet<EMPLEADO_CARNET_ACTIVO>();
            this.EMPLEADO_DISTRIBUCION_CONTABLE = new HashSet<EMPLEADO_DISTRIBUCION_CONTABLE>();
            this.EMPLEADO_DOCUMENTOS = new HashSet<EMPLEADO_DOCUMENTOS>();
            this.EMPLEADO_EDUCACION = new HashSet<EMPLEADO_EDUCACION>();
            this.EMPLEADO_EVALUACION_CONTROL = new HashSet<EMPLEADO_EVALUACION_CONTROL>();
            this.EMPLEADO_EVALUACION_CONTROL1 = new HashSet<EMPLEADO_EVALUACION_CONTROL>();
            this.EMPLEADO_EXPERIENCIA_LABORAL = new HashSet<EMPLEADO_EXPERIENCIA_LABORAL>();
            this.EMPLEADO_HABILIDADES = new HashSet<EMPLEADO_HABILIDADES>();
            this.EMPLEADO_OFICIO = new HashSet<EMPLEADO_OFICIO>();
            this.EMPLEADO_PROFESION = new HashSet<EMPLEADO_PROFESION>();
            this.EMPLEADO_RESUMEN_HORARIO = new HashSet<EMPLEADO_RESUMEN_HORARIO>();
            this.EMPLEADO_TIEMPOS_TABLA = new HashSet<EMPLEADO_TIEMPOS_TABLA>();
            this.EMPLEADO_TRN_FIJAS_PHYSIT = new HashSet<EMPLEADO_TRN_FIJAS_PHYSIT>();
            this.EMPLEADO_TURNOS = new HashSet<EMPLEADO_TURNOS>();
            this.HISTORIAL_DE_CAPACITACION = new HashSet<HISTORIAL_DE_CAPACITACION>();
            this.HISTORIAL_SALARIAL = new HashSet<HISTORIAL_SALARIAL>();
            this.INCIDENCIAS_EMPLEADO = new HashSet<INCIDENCIAS_EMPLEADO>();
            this.PLANILLA_HISTORICA = new HashSet<PLANILLA_HISTORICA>();
            this.REFERENCIAS_EMPLEADO = new HashSet<REFERENCIAS_EMPLEADO>();
            this.REQUISICION_DETALLE = new HashSet<REQUISICION_DETALLE>();
            this.REQUISICION_CONTROL = new HashSet<REQUISICION_CONTROL>();
            this.SALDOS_DE_PLANILLA = new HashSet<SALDOS_DE_PLANILLA>();
            this.SALDOS_DE_VACACIONES = new HashSet<SALDOS_DE_VACACIONES>();
            this.TRABAJO_NOMINA = new HashSet<TRABAJO_NOMINA>();
            this.TRANSAC_PLA_DET = new HashSet<TRANSAC_PLA_DET>();
            this.TRANSFERENCIA_INVENTARIT = new HashSet<TRANSFERENCIA_INVENTARIT>();
            this.GRUPO_DE_CURSO = new HashSet<GRUPO_DE_CURSO>();
        }
    
        public string CODIGO_BIC { get; set; }
        public Nullable<System.DateTime> FECHA_DE_INGRESO_EMPLEADO { get; set; }
        public Nullable<System.DateTime> FECHA_ANTIGUEDAD_EMPLEADO { get; set; }
        public Nullable<System.DateTime> FECHA_VENCE_CONTRATO_EMPL { get; set; }
        public Nullable<System.DateTime> FECHA_BAJA_EMPLEADO { get; set; }
        public string SEXO_DEL_EMPLEADO { get; set; }
        public string LUGAR_NACIMIENTO_EMPLEADO { get; set; }
        public string PAIS_NACIMIENTO_EMPLEADO { get; set; }
        public string NACIONALIDAD_EMPLEADO { get; set; }
        public string ESTADO_CIVIL_EMPLEADO { get; set; }
        public string ESTATUS_DEL_EMPLEADO { get; set; }
        public Nullable<decimal> PESO_DEL_EMPLEADO_LIBRAS { get; set; }
        public Nullable<decimal> PESO_DEL_EMPLEADO_KILOS { get; set; }
        public Nullable<decimal> ALTURA_DEL_EMPLEADO_METRO { get; set; }
        public Nullable<decimal> ALTURA_DEL_EMPLEADO_PIES { get; set; }
        public string SENAS_PARTICULARES_EMPLEA { get; set; }
        public string TIPO_DE_SANGRE_EMPLEADO { get; set; }
        public string NUMERO_DE_EMERGENCIA_EMPL { get; set; }
        public string FORMA_DE_PAGO_EMPLEADO { get; set; }
        public string TIPO_CUENTA_PAGO_EMPLEADO { get; set; }
        public string NUMERO_CUENTA_EMPLEADO { get; set; }
        public Nullable<decimal> SUELDO_MENSUAL { get; set; }
        public Nullable<decimal> SUELDO_QUINCENAL { get; set; }
        public Nullable<decimal> SUELDO_SEMANAL { get; set; }
        public Nullable<decimal> SUELDO_DIARIO { get; set; }
        public Nullable<System.DateTime> FECHA_VIGENCIA_AUMENTO { get; set; }
        public string CODIGO_CAUSA_AUMENTO { get; set; }
        public string BANCO_DEL_EMPLEADO_CODIGO { get; set; }
        public string CODIGO_CLASE_DE_PLANILLA { get; set; }
        public string CODIGO_DE_DEPARTAMENTO { get; set; }
        public string CODIGO_DE_PUESTO { get; set; }
        public string CODIGO_DE_PLAZA { get; set; }
        public string CODIGO_CAUSA_BAJA { get; set; }
        public string CODIGO_RELACION_LABORAL { get; set; }
        public string CODIGO_DE_HORARIO { get; set; }
        public Nullable<int> CODIGO_TURNO { get; set; }
        public string CODIGO_CENTRO_DE_COSTO { get; set; }
        public Nullable<int> CODIGO_DE_AGENCIA { get; set; }
        public string SUBCATALOGO_1 { get; set; }
        public string SUBCATALOGO_2 { get; set; }
        public string SUBCATALOGO_3 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACUMULADOS_PLANILLA> ACUMULADOS_PLANILLA { get; set; }
        public virtual BASE_INFO_CENTRAL BASE_INFO_CENTRAL { get; set; }
        public virtual CAUSAS_DE_AUMENTO CAUSAS_DE_AUMENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CICLO_INVENTARIO_FISICO_T> CICLO_INVENTARIO_FISICO_T { get; set; }
        public virtual CLASE_DE_PLANILLA CLASE_DE_PLANILLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_TABLA> COMPRA_TABLA { get; set; }
        public virtual DEPARTAMENTO_TABLA DEPARTAMENTO_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPENDIENTES_EMPLEADO> DEPENDIENTES_EMPLEADO { get; set; }
        public virtual DOCTOR DOCTOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_AGRUP> EMPLEADO_AGRUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_CARNET_ACTIVO> EMPLEADO_CARNET_ACTIVO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_DISTRIBUCION_CONTABLE> EMPLEADO_DISTRIBUCION_CONTABLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_DOCUMENTOS> EMPLEADO_DOCUMENTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_EDUCACION> EMPLEADO_EDUCACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_EVALUACION_CONTROL> EMPLEADO_EVALUACION_CONTROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_EVALUACION_CONTROL> EMPLEADO_EVALUACION_CONTROL1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_EXPERIENCIA_LABORAL> EMPLEADO_EXPERIENCIA_LABORAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_HABILIDADES> EMPLEADO_HABILIDADES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_OFICIO> EMPLEADO_OFICIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_PROFESION> EMPLEADO_PROFESION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_RESUMEN_HORARIO> EMPLEADO_RESUMEN_HORARIO { get; set; }
        public virtual RELACION_LABORAL RELACION_LABORAL { get; set; }
        public virtual HORARIOS HORARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_TIEMPOS_TABLA> EMPLEADO_TIEMPOS_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_TRN_FIJAS_PHYSIT> EMPLEADO_TRN_FIJAS_PHYSIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO_TURNOS> EMPLEADO_TURNOS { get; set; }
        public virtual PAIS_PHYSICAL_TABLE PAIS_PHYSICAL_TABLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORIAL_DE_CAPACITACION> HISTORIAL_DE_CAPACITACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORIAL_SALARIAL> HISTORIAL_SALARIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INCIDENCIAS_EMPLEADO> INCIDENCIAS_EMPLEADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLANILLA_HISTORICA> PLANILLA_HISTORICA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFERENCIAS_EMPLEADO> REFERENCIAS_EMPLEADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISICION_DETALLE> REQUISICION_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISICION_CONTROL> REQUISICION_CONTROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALDOS_DE_PLANILLA> SALDOS_DE_PLANILLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALDOS_DE_VACACIONES> SALDOS_DE_VACACIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRABAJO_NOMINA> TRABAJO_NOMINA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSAC_PLA_DET> TRANSAC_PLA_DET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFERENCIA_INVENTARIT> TRANSFERENCIA_INVENTARIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO_DE_CURSO> GRUPO_DE_CURSO { get; set; }
    }
}
