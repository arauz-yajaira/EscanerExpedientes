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
    
    public partial class FACTURAS_SERVICIOS_CONTROL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTURAS_SERVICIOS_CONTROL()
        {
            this.FACTURAS_SERVICIOS_DETALLE = new HashSet<FACTURAS_SERVICIOS_DETALLE>();
        }
    
        public int NUMERO_DE_FACTURA_DE_SERV { get; set; }
        public string DEFINICION_DEL_PROCESO { get; set; }
        public string CLIENTE_CODIGO_BIC { get; set; }
        public Nullable<System.DateTime> FECHA_FACTURA_SERVICIO { get; set; }
        public Nullable<int> ANO_DEL_PERIODO { get; set; }
        public Nullable<int> NUMERO_DEL_PERIODO { get; set; }
        public string MONEDA_ORIGEN_CODIGO_DE_M { get; set; }
        public string VENDEDOR_CODIGO_BIC { get; set; }
        public string CODIGO_DE_IMPUESTO { get; set; }
        public Nullable<decimal> SUB_TOTAL_FACTURA { get; set; }
        public Nullable<decimal> IMPUESTO_FACTURA { get; set; }
        public string STATUS_DE_FACTURA { get; set; }
        public string ORIGEN_FACTURA { get; set; }
        public string OBSERVACIONES { get; set; }
    
        public virtual CLIENTE_TABLA CLIENTE_TABLA { get; set; }
        public virtual INFORMACION_CENTRAL INFORMACION_CENTRAL { get; set; }
        public virtual MONEDA_TABLA MONEDA_TABLA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS_SERVICIOS_DETALLE> FACTURAS_SERVICIOS_DETALLE { get; set; }
        public virtual VENDEDOR_TABLA VENDEDOR_TABLA { get; set; }
        public virtual PERIODO_CONTABLE PERIODO_CONTABLE { get; set; }
    }
}
