using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class SelectLiquidacion
    {
        public int id { get; set; }
        public int id_deposito { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_liquidacion { get; set; }
        public string gasto { get; set; }
        public int utilizado { get; set; }
        public int reembolsado { get; set; }
        public int id_institucion { get; set; }
        public byte anombremh { get; set; }
        public string comprobante { get; set; }
        public string observaciones { get; set; }
        public byte proy_formulariocompleto { get; set; }
        public byte proy_guia { get; set; }
        public byte dist_facturas { get; set; }
        public byte dist_presentoinforme { get; set; }
        public byte dist_plantrabajo { get; set; }
        public byte dist_personeriaaldia { get; set; }
        public byte dist_cedulaaldia { get; set; }
    }
}