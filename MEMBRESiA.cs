//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace servicioProyecto
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEMBRESiA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEMBRESiA()
        {
            this.SUSCRIPCIONES = new HashSet<SUSCRIPCIONE>();
        }
    
        public int IDMEMBRESIA { get; set; }
        public string NOMBREMEMBRESIA { get; set; }
        public string DESCRIPCIÓN { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public Nullable<int> DURACION { get; set; }
        public string BENEFICIOS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUSCRIPCIONE> SUSCRIPCIONES { get; set; }
    }
}
