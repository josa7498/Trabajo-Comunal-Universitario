using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class SelectExclusionDistribucion
    {
        public int id { get; set; }
        public int id_distasignacion { get; set; }
        public DateTime fecha { get; set; }
        public string razon { get; set; }
    }
}