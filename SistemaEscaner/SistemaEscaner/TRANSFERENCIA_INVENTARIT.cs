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
    
    public partial class TRANSFERENCIA_INVENTARIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANSFERENCIA_INVENTARIT()
        {
            this.TRANSFERENCIA_INVENTA3E4T = new HashSet<TRANSFERENCIA_INVENTA3E4T>();
        }
    
        public int NUMERO_DE_TRANSFERENCIA { get; set; }
        public Nullable<System.DateTime> FECHA_TRANSFERENCIA_RECIB { get; set; }
        public Nullable<System.DateTime> FECHA_TRANSFERENCIA_ENTRE { get; set; }
        public string BODEGA_ORIGEN_CODIGO_DE_B { get; set; }
        public string BODEGA_DESTINO_CODIGO_DE { get; set; }
        public string SOLICITADA_POR_CODIGO_BIC { get; set; }
        public string RECIBIDA_POR_CODIGO_BIC { get; set; }
        public string DESPACHADA_POR_CODIGO_BIC { get; set; }
        public string APROBADA_POR_CODIGO_BIC { get; set; }
        public string TRANSPORTISTA_CODIGO_BIC { get; set; }
        public string STATUS_DE_LA_TRANSFERENCI { get; set; }
    
        public virtual BODEGA_TABLA BODEGA_TABLA { get; set; }
        public virtual BODEGA_TABLA BODEGA_TABLA1 { get; set; }
        public virtual EMPLEADO_TABLA EMPLEADO_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFERENCIA_INVENTA3E4T> TRANSFERENCIA_INVENTA3E4T { get; set; }
    }
}
