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
    
    public partial class RECETA_MASIVA_MEDICAMENTT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RECETA_MASIVA_MEDICAMENTT()
        {
            this.RECETA_MASIVA_MEDICAM6HXT = new HashSet<RECETA_MASIVA_MEDICAM6HXT>();
        }
    
        public System.DateTime LH6hoA { get; set; }
        public string CODIGO_CENTRO_DE_COSTO { get; set; }
        public string CODIGO_DE_DEPARTAMENTO { get; set; }
        public string CODIGO_DE_BODEGA { get; set; }
        public Nullable<decimal> CANTIDAD_DE_RECETAS { get; set; }
        public string OBSERVACIONES { get; set; }
        public string ESTADO_DE_RECETA_MASIVA { get; set; }
    
        public virtual BODEGA_TABLA BODEGA_TABLA { get; set; }
        public virtual CENTRO_DE_COSTO CENTRO_DE_COSTO { get; set; }
        public virtual DEPARTAMENTO_TABLA DEPARTAMENTO_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETA_MASIVA_MEDICAM6HXT> RECETA_MASIVA_MEDICAM6HXT { get; set; }
    }
}
