using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class SelectInclusionDistribucion
    {
        public int id { get; set; }
        public int id_distasignacion { get; set; }
        public DateTime fecha { get; set; }
        public string razon { get; set; }
        public byte asociacionactiva { get; set; }
        public byte cuentaverificada { get; set; }
        public byte aldiaproyectos { get; set; }
        public byte aldiaisr { get; set; }
    }
}