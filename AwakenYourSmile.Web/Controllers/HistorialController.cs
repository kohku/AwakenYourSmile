using AwakenYourSmile.Web.Models;
using Rainbow.Web.Storage;
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
            if (model == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            try
            {
                if (ModelState.IsValid)
                {
                    if (model.IsValid)
                    {
                        model.AcceptChanges();

                        return RedirectToAction("Modificar", new { id = model.ID });
                    }

                    ModelState.AddModelError("ValidationMessage", model.ValidationMessage);
                }
            }
            catch (DataException /* dex */)
            {
                ModelState.AddModelError("", "No es posible guardar los cambios. Intente de nuevo y si no es posible favor de contactar al administrador del sistema.");
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
                    var entity = ClinicalHistory.Load(model.ID);

                    if (model == null)
                        return HttpNotFound();

                    typeof(ClinicalHistory).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                        .Where(p => p.CanWrite && p.CanRead).ToList()
                        .ForEach(p => p.SetValue(entity, p.GetValue(model, null)));

                    if (entity.IsChanged)
                        entity.LastUpdatedBy = User.Identity.Name;

                    if (entity.IsValid)
                    {
                        entity.AcceptChanges();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError("ValidationMessage", entity.ValidationMessage);
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

        //
        // GET: /Historial/Adjuntos
        [Authorize]
        public ActionResult Adjuntos(Guid? reference)
        {
            if (!reference.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var model = new UploadFileModel() { Reference = reference.Value };

            model.Files = UploadedFile.GetFiles(reference.Value);

            return View(model);
        }

        //
        // POST: /Historial/Adjuntos
        [Authorize]
        [HttpPost]
        public ActionResult Adjuntos(Guid? reference, HttpPostedFileBase file)
        {
            if (!reference.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var uploadedFile = new UploadedFile();

            uploadedFile.CreatedBy = User.Identity.Name;
            uploadedFile.FileName = file.FileName;
            uploadedFile.InputStream = file.InputStream;
            uploadedFile.ContentLength = file.ContentLength;
            uploadedFile.ContentType = file.ContentType;
            uploadedFile.ParentID = reference;

            uploadedFile.AcceptChanges();

            return RedirectToAction("Adjuntos", new { reference = reference });
        }

        //
        // GET: /Historial/Adjunto
        [Authorize]
        public ActionResult Adjunto(Guid? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var file = UploadedFile.Load(id.Value);

            if (file == null)
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            return File(file.Data, file.ContentType);
        }

        //
        // GET: /Historial/BorrarAdjunto
        [Authorize]
        public ActionResult BorrarAdjunto(Guid? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var file = UploadedFile.Load(id.Value);

            file.Delete();

            file.AcceptChanges();

            return RedirectToAction("Adjuntos", new { reference = file.ParentID });
        }

        //
        // GET: /Historial/Upload
        [AllowAnonymous]
        public ActionResult Upload()
        {
            return View(new UploadFileModel() { Reference = Guid.NewGuid() });
        }

        //
        // POST: /Historial/Upload
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Upload(Guid? reference, HttpPostedFileBase file)
        {
            if (!reference.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var uploadedFile = new UploadedFile();

            uploadedFile.CreatedBy = User.Identity.Name;
            uploadedFile.FileName = file.FileName;
            uploadedFile.InputStream = file.InputStream;
            uploadedFile.ContentLength = file.ContentLength;
            uploadedFile.ContentType = file.ContentType;
            uploadedFile.ParentID = reference;

            uploadedFile.AcceptChanges();

            return RedirectToAction("Index");
        }
    }
}