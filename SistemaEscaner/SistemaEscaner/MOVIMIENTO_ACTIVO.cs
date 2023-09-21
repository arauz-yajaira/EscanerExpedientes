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
    
    public partial class MOVIMIENTO_ACTIVO
    {
        public string CODIGO_ACTIVO_FIJO { get; set; }
        public int ENSAMBLE_ACTIVO_FIJO { get; set; }
        public System.DateTime FECHA_DE_MOVIMIENTO { get; set; }
        public string TIPO_DE_MOVIMIENTO_ACTIVO { get; set; }
        public string DESCRIPCION_DEL_MOVIMIENT { get; set; }
        public string METODO_DE_DEPRECIACION_AN { get; set; }
        public string METODO_DE_DEPRECIACION_AC { get; set; }
        public Nullable<int> VIDA_UTIL_ANTERIOR_VIDA_U { get; set; }
        public Nullable<int> VIDA_UTIL_ACTUAL_VIDA_UTI { get; set; }
        public string ESTATUS_ANTERIOR_ESTATUS { get; set; }
        public string ESTATUS_ACTUAL_ESTATUS_AC { get; set; }
        public string DEPARTAMENTO_ANTERIOR_COD { get; set; }
        public string DEPARTAMENTO_ACTUAL_CODIG { get; set; }
        public string LY8eA { get; set; }
        public string LY8fA { get; set; }
        public string RESPONSABLE_ANTERIOR_CODI { get; set; }
        public string RESPONSABLE_ACTUAL_CODIGO { get; set; }
        public Nullable<int> SUCURSAL_ANTERIOR_SUCURSA { get; set; }
        public Nullable<int> SUCURSAL_ACTUAL_SUCURSAL { get; set; }
        public Nullable<System.DateTime> HORA_ADICION { get; set; }
        public Nullable<System.DateTime> FECHA_ADICION { get; set; }
        public string USUARIO_ADICION { get; set; }
        public Nullable<System.DateTime> HORA_ULTIMO_CAMBIO { get; set; }
        public Nullable<System.DateTime> FECHA_ULTIMO_CAMBIO { get; set; }
        public string USUARIO_ULTIMO_CAMBIO { get; set; }
        public string Status_Movto_AF { get; set; }
        public string PREFIJO_PARTIDA_CONTABLE { get; set; }
        public Nullable<int> NUMERO_DE_PARTIDA { get; set; }
    
        public virtual ACTIVO_FIJO_TABLA ACTIVO_FIJO_TABLA { get; set; }
        public virtual TIPO_MOVIMIENTO_ACTIVO_FIJO TIPO_MOVIMIENTO_ACTIVO_FIJO { get; set; }
    }
}
