using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class SelectDeposito
    {
        public int id { get; set; }
        public int id_distasignacion { get; set; }
        public int id_proyecto { get; set; }
        public string observaciones { get; set; }
        public byte proyecto { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_deposito { get; set; }
        public DateTime fecha_limite { get; set; }
        public string planilla { get; set; }
    }
}