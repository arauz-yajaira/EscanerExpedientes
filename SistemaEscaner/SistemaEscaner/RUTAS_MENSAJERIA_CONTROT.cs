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
    
    public partial class RUTAS_MENSAJERIA_CONTROT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RUTAS_MENSAJERIA_CONTROT()
        {
            this.RUTAS_MENSAJERIA_DETALLT = new HashSet<RUTAS_MENSAJERIA_DETALLT>();
            this.TRANSACCIONES_MENSAJERIT = new HashSet<TRANSACCIONES_MENSAJERIT>();
        }
    
        public string CODIGO_RUTA_MENSAJERIA { get; set; }
        public string DESCRIPCION_RUTA_MENSAJER { get; set; }
        public string ABREVIATURA_RUTA_MENSAJER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RUTAS_MENSAJERIA_DETALLT> RUTAS_MENSAJERIA_DETALLT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACCIONES_MENSAJERIT> TRANSACCIONES_MENSAJERIT { get; set; }
    }
}
