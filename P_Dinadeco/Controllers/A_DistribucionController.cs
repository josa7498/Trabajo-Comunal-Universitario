using P_Dinadeco.Models;
using P_Dinadeco.Models.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P_Dinadeco.Controllers
{
    public class A_DistribucionController : Controller
    {
        // GET: A_Distribucion

        //Mostara la tabla con la informacion 
        /*public ActionResult Aprobar_Distr()
        {

            try
            {
                
                List<SelectA_Distribucion> lst;

                using (DINADECO_BDEntities db = new DINADECO_BDEntities())
                {
                    lst = (from d in db.dnf_dist_aprobacion
                               //where d.estado == 1 || d.estado == 3 || d.estado == 0
                           select new SelectA_Distribucion
                           {
                               id = d.id,
                               fecha_ingreso = d.fecha_ingreso,
                               fecha_aprobacion = d.fecha_aprobacion,
                               fecha_exclusion = d.fecha_exclusion,
                               resolucion = d.resolucion,
                               acuerdo = d.acuerdo,
                               observaciones = d.observaciones
                           }).ToList();
                }

                return View(lst);
            }
            catch (Exception)
            {
                
            }
        }*/




        //Permira editar 



        //Eliminar
    }
}