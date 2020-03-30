using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class SelectA_Proyecto
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string sesion { get; set; }
        public string acuerdo { get; set; }
        public string boleta { get; set; }
        public int id_partida { get; set; }
        public int monto { get; set; }
        public string observaciones { get; set; }

    }
}