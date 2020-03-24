using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class AddNuevaDistribucion
    {

        public int id { get; set; }
        public byte habilitado { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Estado")]
        public string estado { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_ingreso { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_corte { get; set; }
        public string resolucion { get; set; }
        public string acuerdo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_limite { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_impresion { get; set; }
        public string tipo { get; set; }
        public int monto { get; set; }
        public int monto_subejecutado { get; set; }
        public string observaciones { get; set; }
        public int id_aprobacion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime deposito_fecha { get; set; }
        public string deposito_observaciones { get; set; }
        public int monto_unitario { get; set; }

    }
}