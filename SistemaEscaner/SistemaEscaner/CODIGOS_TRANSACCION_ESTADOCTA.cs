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
    
    public partial class CODIGOS_TRANSACCION_ESTADOCTA
    {
        public string CODIGO_TRANSACCION_ESTADO { get; set; }
        public string PREFIJO_PARTIDA_CONTABLE { get; set; }
        public string TIPO_DOCUMENTO_BANCARIO { get; set; }
        public string FORMA_QUE_AFECTA { get; set; }
    
        public virtual NUMERACION_PARTIDAS NUMERACION_PARTIDAS { get; set; }
    }
}
