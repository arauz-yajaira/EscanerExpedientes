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
    
    public partial class OS12T
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OS12T()
        {
            this.PUNTO_DE_VENTA_USUARIO = new HashSet<PUNTO_DE_VENTA_USUARIO>();
            this.COMPANIA = new HashSet<COMPANIA>();
            this.OSgT = new HashSet<OSgT>();
            this.OS4T = new HashSet<OS4T>();
            this.OS20T = new HashSet<OS20T>();
            this.PG_CUENTA_PRESUPUESTO = new HashSet<PG_CUENTA_PRESUPUESTO>();
        }
    
        public Nullable<System.DateTime> OBF002 { get; set; }
        public Nullable<System.DateTime> OBF003 { get; set; }
        public Nullable<System.DateTime> OBF005 { get; set; }
        public Nullable<System.DateTime> OBF006 { get; set; }
        public string OS4sA { get; set; }
        public string OS3cA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PUNTO_DE_VENTA_USUARIO> PUNTO_DE_VENTA_USUARIO { get; set; }
        public virtual USUARIO_DE_FACTURACION USUARIO_DE_FACTURACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPANIA> COMPANIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OSgT> OSgT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OS4T> OS4T { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OS20T> OS20T { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PG_CUENTA_PRESUPUESTO> PG_CUENTA_PRESUPUESTO { get; set; }
    }
}
