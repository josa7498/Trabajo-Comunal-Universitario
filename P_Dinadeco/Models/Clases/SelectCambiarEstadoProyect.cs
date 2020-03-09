using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class SelectCambiarEstadoProyect
    {
        public int id { get; set; }
        public int id_proyecto { get; set; }
        public DateTime fecha { get; set; }
        public string observaciones { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
    }
}