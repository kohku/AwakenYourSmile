using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AwakenYourSmile.Web.Controllers
{
    public class AgendaController : Controller
    {
        //
        // GET: /Agenda/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Agenda/Cita
        public ActionResult Cita()
        {
            var model = new Appointment();

            model.CreatedBy = User.Identity.Name;

            return View(model);
        }

        //
        // POST: /Agenda/Cita
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Cita(Appointment model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.IsValid)
                    {
                        model.AcceptChanges();

                        return RedirectToAction("ConfirmarCita", new { id = model.ID });
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
        // GET: /Agenda/ConfirmarCita
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarCita(Guid? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var model = Appointment.Load(id.Value);

            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        //
        // POST: /Agenda/ConfirmarCita
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarCita(Appointment model)
        {
            if (model == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var entity = Appointment.Load(model.ID);

            if (entity == null)
                return HttpNotFound();

            // TODO: Confirmar cita
            model.AcceptChanges();

            return Redirect(Url.Content("~/index.html"));
        }
	}
}