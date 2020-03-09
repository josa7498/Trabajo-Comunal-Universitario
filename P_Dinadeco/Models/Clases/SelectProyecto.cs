using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class SelectProyecto
    {
        public int id { get; set; }
        public int id_asociacion { get; set; }
        public string estado { get; set; }
        public int id_tipo { get; set; }
        public int id_subtipo { get; set; }
        public int codigo { get; set; }
        public string codigo_largo { get; set; }
        public string nombre { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public int monto_solicitado { get; set; }
        public DateTime tramite_fecha { get; set; }
        public string tramite_observaciones { get; set; }
        public string expediente { get; set; }
        public DateTime completado_fecha { get; set; }
        public string completado_observaciones { get; set; }
        public int id_aprobacion { get; set; }
    }
}