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
    
    public partial class CITAS_MEDICAS_CONTROL
    {
        public string CODIGO_BIC { get; set; }
        public System.DateTime LH7m6A { get; set; }
        public Nullable<decimal> LH7mfA { get; set; }
        public Nullable<decimal> LH7mgA { get; set; }
        public Nullable<decimal> TOTAL_REFERIDO { get; set; }
        public Nullable<System.DateTime> HORA_ADICION { get; set; }
        public Nullable<System.DateTime> FECHA_ADICION { get; set; }
        public string USUARIO_ADICION { get; set; }
        public Nullable<System.DateTime> HORA_ULTIMO_CAMBIO { get; set; }
        public Nullable<System.DateTime> FECHA_ULTIMO_CAMBIO { get; set; }
        public string USUARIO_ULTIMO_CAMBIO { get; set; }
    
        public virtual DOCTOR DOCTOR { get; set; }
    }
}
