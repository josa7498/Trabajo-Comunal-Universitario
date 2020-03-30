using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class SelectA_Distribucion
    {
        public int id { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_aprobacion { get; set; }
        public DateTime fecha_exclusion { get; set; }
        public string resolucion { get; set; }
        public string acuerdo { get; set; }
        public string observaciones { get; set; }
    }
}