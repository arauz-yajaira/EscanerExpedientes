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
    
    public partial class TRN_INVENTARIO_X_AGENCIT
    {
        public string DEFINICION_DEL_PROCESO { get; set; }
        public int CORRELATIVO_ICP { get; set; }
        public Nullable<int> CODIGO_DE_AGENCIA { get; set; }
    
        public virtual AGENCIA AGENCIA { get; set; }
        public virtual TRANSACCIONES_ICP TRANSACCIONES_ICP { get; set; }
    }
}
