//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P_Dinadeco.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoAcuerdo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoAcuerdo()
        {
            this.Acuerdo = new HashSet<Acuerdo>();
        }
    
        public int idTipoAcuerdo { get; set; }
        public string nombreAcuerdo { get; set; }
        public string estadoAcuerdo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acuerdo> Acuerdo { get; set; }
    }
}
