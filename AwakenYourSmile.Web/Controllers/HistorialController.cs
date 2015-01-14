﻿using AwakenYourSmile.Web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace AwakenYourSmile.Web.Controllers
{
    public class HistorialController : Controller
    {
        //
        // GET: /Historial/
        [Authorize]
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

                        return RedirectToAction("Index");
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
        // GET: /Historial/Modificar
        [Authorize]
        public ActionResult Modificar(Guid? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var model = ClinicalHistory.Load(id.Value);

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
                    var current = ClinicalHistory.Load(model.ID);

                    if (model == null)
                        return HttpNotFound();

                    typeof(ClinicalHistory).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                        .Where(p => p.CanWrite && p.CanRead).ToList()
                        .ForEach(p => p.SetValue(current, p.GetValue(model, null)));

                    if (current.IsChanged)
                        current.LastUpdatedBy = User.Identity.Name;

                    if (current.IsValid)
                    {
                        current.AcceptChanges();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError("ValidationMessage", current.ValidationMessage);
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
        // GET: /Historial/Borrar
        [Authorize]
        public ActionResult ConfirmarBorrar(Guid? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var model = ClinicalHistory.Load(id.Value);

            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        //
        // GET: /Historial/ConfirmarBorrar
        [Authorize]
        public ActionResult Borrar(Guid? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var model = ClinicalHistory.Load(id.Value);

            if (model == null)
                return HttpNotFound();

            model.Delete();
            model.AcceptChanges();

            return RedirectToAction("Index");
        }

        //
        // GET: /Historial/Busqueda
        [Authorize]
        public ActionResult Busqueda()
        {
            var model = new ClinicalHistoryModelHelper();

            return View(model);
        }

        //
        // GET: /Historial/Resultados
        [Authorize]
        public ActionResult Resultados(string name, DateTime? birthDate)
        {
            var model = new ClinicalHistoryModelHelper();

            model.ClinicalHistories = ClinicalHistory.GetClinicalHistories(null, name, null, birthDate);

            return View(model);
        }


    }
}