using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_Dinadeco.Models.Clases
{
    public class SelectAcuerdo
    {
        public long idAcuerdo { get; set; }
        public string idUsuario { get; set; }
        public long idAsociacion { get; set; }
        public long idRegional { get; set; }
        public long idAsiento { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idTipoAcuerdo { get; set; }
        public string numeroGaceta { get; set; }
        public string nota { get; set; }
    }
}