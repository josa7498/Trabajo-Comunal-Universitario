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
    
    public partial class dna_bitacora
    {
        public int id { get; set; }
        public Nullable<int> asociacion_id { get; set; }
        public int usuario_id { get; set; }
        public string accion { get; set; }
        public byte[] date { get; set; }
        public string valor { get; set; }
    }
}
