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
    
    public partial class FORMAS_DE_PAGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORMAS_DE_PAGO()
        {
            this.CXP_MULTIPLE_DOCUMENT6KUT = new HashSet<CXP_MULTIPLE_DOCUMENT6KUT>();
            this.FACTURA_DIARIA_CONTROL = new HashSet<FACTURA_DIARIA_CONTROL>();
            this.FACTURA_DIARIA_DETALLE_PAGOS = new HashSet<FACTURA_DIARIA_DETALLE_PAGOS>();
            this.PUNTO_DE_VENTA = new HashSet<PUNTO_DE_VENTA>();
        }
    
        public string CODIGO_FORMAS_PAGO { get; set; }
        public string DESCRIPCION_FORMAS_PAGO { get; set; }
        public string ABREVIATURA_FORMAS_PAGO { get; set; }
        public string FORMAS_PAGO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CXP_MULTIPLE_DOCUMENT6KUT> CXP_MULTIPLE_DOCUMENT6KUT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA_DIARIA_CONTROL> FACTURA_DIARIA_CONTROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA_DIARIA_DETALLE_PAGOS> FACTURA_DIARIA_DETALLE_PAGOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PUNTO_DE_VENTA> PUNTO_DE_VENTA { get; set; }
    }
}
