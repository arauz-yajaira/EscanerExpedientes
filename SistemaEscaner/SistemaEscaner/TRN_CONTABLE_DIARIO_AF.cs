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
    
    public partial class TRN_CONTABLE_DIARIO_AF
    {
        public int ANO_DEL_PERIODO { get; set; }
        public int NUMERO_DEL_PERIODO { get; set; }
        public string PREFIJO_PARTIDA_CONTABLE { get; set; }
        public int NUMERO_TRN_DIARIO_DETALLE { get; set; }
        public string DESCRIPCION_PARTIDA_DETAL { get; set; }
        public string CODIGO_DE_CUENTA { get; set; }
        public string CODIGO_DE_MONEDA { get; set; }
        public Nullable<int> CODIGO_DE_AGENCIA { get; set; }
        public string ZONA { get; set; }
        public string CODIGO_DE_DEPARTAMENTO { get; set; }
        public Nullable<decimal> VALOR_TRANSACCION_ORIGEN { get; set; }
        public Nullable<decimal> VALOR_TRANSACCION_ORIG2JT { get; set; }
    
        public virtual CATALOGO_DE_CUENTAS CATALOGO_DE_CUENTAS { get; set; }
        public virtual MONEDA_TABLA MONEDA_TABLA { get; set; }
        public virtual NUMERACION_PARTIDAS NUMERACION_PARTIDAS { get; set; }
        public virtual PERIODO_CONTABLE PERIODO_CONTABLE { get; set; }
    }
}
