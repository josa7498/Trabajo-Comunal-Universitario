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
    
    public partial class dna_asociacion
    {
        public int id { get; set; }
        public string estado { get; set; }
        public Nullable<byte> activo_import { get; set; }
        public int ano { get; set; }
        public int tipo_id { get; set; }
        public string nombre { get; set; }
        public string nombre_antes { get; set; }
        public string representante_id { get; set; }
        public string titulo { get; set; }
        public int region_id { get; set; }
        public Nullable<int> provincia_id { get; set; }
        public int canton_id { get; set; }
        public int distrito_id { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string web { get; set; }
        public byte not_fax { get; set; }
        public byte not_email { get; set; }
        public byte not_func_regional { get; set; }
        public Nullable<System.DateTime> fecha_asamblea { get; set; }
        public string notas { get; set; }
        public byte es_cemento { get; set; }
        public byte[] fecha_registro { get; set; }
        public Nullable<System.DateTime> fecha_constitucion { get; set; }
        public Nullable<int> tomo { get; set; }
        public Nullable<int> folio { get; set; }
        public Nullable<int> asiento { get; set; }
        public Nullable<byte> ultimo { get; set; }
    }
}
