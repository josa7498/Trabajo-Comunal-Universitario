using P_Dinadeco.Models;
using P_Dinadeco.Models.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P_Dinadeco.Controllers
{
    public class DistribucionController : Controller
    {
        // GET: Distribucion

        public ActionResult Distribucion()
        {
            try
            {
                List<SelectDistribucion> lst;
                using (DINADECO_BDEntities db = new DINADECO_BDEntities())
                {
                    lst = (from d in db.dnf_distribucion
                           //where d.estado == 1 || d.estado == 3
                           select new SelectDistribucion
                           {
                               nombre = d.nombre,
                               estado = d.estado,
                               fecha_ingreso = d.fecha_ingreso,
                               fecha_corte = d.fecha_corte,
                               resolucion = d.resolucion,
                               acuerdo = d.acuerdo,
                               fecha_limite = d.fecha_limite,
                               fecha_impresion = d.fecha_impresion
                           }).ToList();
                }
                return View(lst);
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult Nueva_Distribucion()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Nueva_Distribucion(AddNuevaDistribucion model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    using (DINADECO_BDEntities db = new DINADECO_BDEntities())
                    {
                        var obj_Distribucion = new dnf_distribucion();
                        obj_Distribucion.nombre = model.nombre;
                        obj_Distribucion.estado = model.estado;
                        obj_Distribucion.fecha_ingreso = model.fecha_ingreso;
                        obj_Distribucion.fecha_corte = model.fecha_corte;
                        obj_Distribucion.resolucion = model.resolucion;
                        obj_Distribucion.acuerdo = model.acuerdo;
                        obj_Distribucion.fecha_limite = model.fecha_limite;
                        obj_Distribucion.fecha_impresion = model.fecha_impresion;
                        //obj_NuevaDistr.estado = 1;
                        db.dnf_distribucion.Add(obj_Distribucion);
                        db.SaveChanges();

                        TempData["msg"] = "Agregado";
                        ViewBag.Msg = TempData["msg"];
                    }
                    return Redirect("/Distribucion/Distribucion");

                }
                return View(model);
            }
            catch (Exception)
            {
                return View();
                //return Redirect("/Error/InaccessiblePage");
            }
        }


        public ActionResult Aprobar_Distribucion()
        {
            return View();
        }


        public ActionResult Excluir_Distribucion()
        {
            return View();
        }


        public ActionResult Incluir_Distribucion()
        {
            return View();
        }
    }
}