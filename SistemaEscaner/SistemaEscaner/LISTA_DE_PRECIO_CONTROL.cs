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
    
    public partial class LISTA_DE_PRECIO_CONTROL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LISTA_DE_PRECIO_CONTROL()
        {
            this.FACTURA_DIARIA_DETALLE = new HashSet<FACTURA_DIARIA_DETALLE>();
            this.LISTA_DE_PRECIO_DETALLE = new HashSet<LISTA_DE_PRECIO_DETALLE>();
        }
    
        public string CODIGO_LISTA_PRECIOS { get; set; }
        public Nullable<System.DateTime> FECHA_VIGENCIA_PRECIOS { get; set; }
        public Nullable<System.DateTime> FECHA_FIN_PRECIOS { get; set; }
        public string DESCRIPCION_LISTA_PRECIOS { get; set; }
        public string ESTATUS_LISTA_PRECIOS { get; set; }
        public string CODIGO_DE_MONEDA { get; set; }
        public string PRECIO_INCLUYE_IMPUESTO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA_DIARIA_DETALLE> FACTURA_DIARIA_DETALLE { get; set; }
        public virtual MONEDA_TABLA MONEDA_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LISTA_DE_PRECIO_DETALLE> LISTA_DE_PRECIO_DETALLE { get; set; }
    }
}
