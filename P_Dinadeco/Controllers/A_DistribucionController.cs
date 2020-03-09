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
        public ActionResult Aprobar_Distr()
        {
            try
            {
                ViewBag.Msg = TempData["msg"].ToString();
            }
            catch (Exception)
            {

            }
            try
            {
                
                List<SelectRolesViewModel> lst;

                using (SII_Entities db = new SII_Entities())
                {
                    lst = (from d in db.Tbl_Rol
                           where d.estado == 1 || d.estado == 3 || d.estado == 0
                           select new SelectRolesViewModel
                           {
                               id_R = d.id_Rol,
                               rol = d.tipo_Rol,
                               estado = d.estado
                           }).ToList();
                }

                return View(lst.ToPagedList(page ?? 1, 8));
            }
            catch (Exception)
            {
                return Redirect("/Error/InaccessiblePage");
            }
        }




        //Permira editar 



        //Eliminar
    }
}