//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P_Dinadeco.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dnf_proyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dnf_proyecto()
        {
            this.dnf_deposito = new HashSet<dnf_deposito>();
            this.dnf_proy_cambioestado = new HashSet<dnf_proy_cambioestado>();
        }
    
        public int id { get; set; }
        public int id_asociacion { get; set; }
        public string estado { get; set; }
        public int id_tipo { get; set; }
        public int id_subtipo { get; set; }
        public int codigo { get; set; }
        public string codigo_largo { get; set; }
        public string nombre { get; set; }
        public System.DateTime fecha_ingreso { get; set; }
        public int monto_solicitado { get; set; }
        public Nullable<System.DateTime> tramite_fecha { get; set; }
        public string tramite_observaciones { get; set; }
        public string expediente { get; set; }
        public Nullable<System.DateTime> completado_fecha { get; set; }
        public string completado_observaciones { get; set; }
        public Nullable<int> id_aprobacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dnf_deposito> dnf_deposito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dnf_proy_cambioestado> dnf_proy_cambioestado { get; set; }
        public virtual dnf_tipoproyecto dnf_tipoproyecto { get; set; }
    }
}
