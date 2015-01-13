using AwakenYourSmile.Web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AwakenYourSmile.Web.Controllers
{
    public class HistorialController : Controller
    {
        //
        // GET: /Historial/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Historial/Nuevo
        [Authorize]
        public ActionResult Nuevo()
        {
            var model = new ClinicalHistory();

            model.CreatedBy = User.Identity.Name;

            return View(model);
        }

        //
        // POST: /Historial/Nuevo
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Nuevo(ClinicalHistory model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.IsValid)
                    {
                        model.AcceptChanges();

                        return RedirectToAction("Busqueda");
                    }

                    ModelState.AddModelError("ValidationMessage", model.ValidationMessage);
                }
            }
            catch (DataException /* dex */)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Historial/Busqueda
        [Authorize]
        public ActionResult Busqueda()
        {
            var model = new ClinicalHistoryModelHelper();

            model.ClinicalHistories = ClinicalHistory.GetClinicalHistories(null, null, null);

            return View(model);
        }

        //
        // GET: /Historial/Modificar
        [Authorize]
        public ActionResult Modificar(Guid id)
        {
            var model = ClinicalHistory.Load(id);

            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        //
        // POST: /Historial/Modificar
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Modificar(ClinicalHistory model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.IsValid)
                    {
                        model.AcceptChanges();

                        return RedirectToAction("Busqueda");
                    }

                    ModelState.AddModelError("ValidationMessage", model.ValidationMessage);
                }
            }
            catch (DataException /* dex */)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}