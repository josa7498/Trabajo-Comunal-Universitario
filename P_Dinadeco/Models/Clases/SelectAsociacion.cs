using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class SelectAsociacion
    {
        public long idAsociacion { get; set; }
        public long idRegion { get; set; }
        public int idProvincia { get; set; }
        public int idCanton { get; set; }
        public int idDistrito { get; set; }
        public int idTamanio { get; set; }
        public int idTipo { get; set; }
        public int idEstadoAsoc { get; set; }
        public int cedula_juridica { get; set; }
        public string nombreAsociacion { get; set; }
        public string nombreAsocAnterior { get; set; }
        public string objetivoAsociacion { get; set; }
        public DateTime fechaPreConsAsociacon { get; set; }
        public DateTime fechaConsAsociacion { get; set; }
        public DateTime fechaVencAsociacion { get; set; }
        public int cantidadRenovaciones { get; set; }
        public int cantidadIntegrantes { get; set; }
        public string emailAsociacion { get; set; }
        public string web { get; set; }
        public string numeroTelefono { get; set; }
        public string fax { get; set; }
        
    }
}