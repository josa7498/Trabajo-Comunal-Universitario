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
    
    public partial class dna_juntadirectiva
    {
        public int id { get; set; }
        public int asociacion_id { get; set; }
        public System.DateTime fecha { get; set; }
        public byte cambio_total { get; set; }
        public int responsable_id { get; set; }
        public Nullable<int> acuerdo_id { get; set; }
        public string notas { get; set; }
        public Nullable<byte> calculada { get; set; }
        public Nullable<byte> generada { get; set; }
    
        public virtual dna_acuerdo dna_acuerdo { get; set; }
        public virtual dna_responsable dna_responsable { get; set; }
    }
}
