using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Recaptcha.Web;
using Recaptcha.Web.Mvc;

namespace AwakenYourSmile.Web.Controllers
{
    public class AgendaController : Controller
    {
        //
        // GET: /Agenda/
        public ActionResult Index()
        {
            return RedirectToAction("Calendario");
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
                        RecaptchaVerificationHelper recaptchaHelper = this.GetRecaptchaVerificationHelper();

                        if (String.IsNullOrEmpty(recaptchaHelper.Response))
                        {
                            ModelState.AddModelError("", "El código de verificación no puede estar vacío.");
                            return View(model);
                        }

                        RecaptchaVerificationResult recaptchaResult = recaptchaHelper.VerifyRecaptchaResponse();

                        if (recaptchaResult != RecaptchaVerificationResult.Success)
                        {
                            ModelState.AddModelError("", "Código de verificación incorrecto.");
                            return View(model);
                        }

                        model.AcceptChanges();

                        return RedirectToAction("CitaRegistrada", new { id = model.ID });
                    }

                    ModelState.AddModelError("ValidationMessage", model.ValidationMessage);
                }
            }
            catch (DataException /* dex */)
            {
                ModelState.AddModelError("", "Imposible guardar cambios. Intenta de nuevo y si el problema persiste contacte al administrador.");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Agenda/CitaRegistrada
        [AllowAnonymous]
        public ActionResult CitaRegistrada(Guid? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var model = Appointment.Load(id.Value);

            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        //
        // GET: /Agenda/ConfirmarCita
        [Authorize]
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

            entity.ConfirmedByUser = true;
            entity.LastUpdatedBy = User.Identity.Name;

            entity.AcceptChanges();



            return Redirect(Url.Content("~/index.html"));
        }

        //
        // GET: /Agenda/AgendarCita
        [Authorize]
        public ActionResult AgendarCita()
        {
            var model = new Appointment();

            model.CreatedBy = User.Identity.Name;

            return View(model);
        }

        //
        // POST: /Agenda/AgendarCita
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult AgendarCita(Appointment model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.IsValid)
                    {
                        model.AcceptChanges();

                        return RedirectToAction("Index", new { id = model.ID });
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
        // GET: /Agenda/Calendario
        [Authorize]
        public ActionResult Calendario()
        {
            return View();
        }

        //
        // GET: /Agenda/Eventos
        [Authorize]
        public JsonResult Eventos(DateTime? start, DateTime? end)
        {
            var appointments = Appointment.GetAppointments(start, end);

            var events = new List<FullcalendarEvent>();

            foreach (var appointment in appointments)
            {
                events.Add(new FullcalendarEvent
                {
                    id = appointment.ID.ToString(),
                    title = string.Format("{0}, {1}", appointment.LastName, appointment.FirstName),
                    start = appointment.AppointmentDate,
                    end = appointment.AppointmentDate.AddHours(1),
                    url = Url.Action("Evento", new { id = appointment.ID }),
                    className = (appointment.Cancelled ? "appointment_cancelled" : 
                        appointment.Booked ? "appointment_booked" : 
                        appointment.ConfirmedByUser ? "appointment_confirmed" : "appointment_entered")
                });
            }

            return Json(events, JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Agenda/Evento
        [Authorize]
        public ActionResult Evento(Guid? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var model = Appointment.Load(id.Value);

            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        //
        // GET: /Agenda/Confirmar
        [Authorize]
        public ActionResult Confirmar(Guid? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var entity = Appointment.Load(id.Value);

            if (entity == null)
                return HttpNotFound();

            entity.Booked = true;
            entity.Cancelled = false;
            entity.LastUpdatedBy = User.Identity.Name;

            entity.AcceptChanges();

            return RedirectToAction("Index");
        }

        //
        // GET: /Agenda/Cancelar
        [Authorize]
        public ActionResult Cancelar(Guid? id)
        {
            if (!id.HasValue)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var entity = Appointment.Load(id.Value);

            if (entity == null)
                return HttpNotFound();

            entity.Booked = false;
            entity.Cancelled = true;
            entity.LastUpdatedBy = User.Identity.Name;

            entity.AcceptChanges();

            return RedirectToAction("Index");
        }

        public class FullcalendarEvent
        {
            //String/Integer. Optional.
            // Uniquely identifies the given event. Different instances of repeating events should all have the same id.
            public string id { get; set; }

            //String. Required.
            //The text on an event's element
            public string title { get; set; }


            //true or false. Optional.
            //Whether an event occurs at a specific time-of-day. This property affects whether an event's time is shown. Also, in the agenda views, determines if it is displayed in the "all-day" section.
            //If this value is not explicitly specified, allDayDefault will be used if it is defined.
            //If all else fails, FullCalendar will try to guess. If either the start or end value has a "T" as part of the ISO8601 date string, allDay will become false. Otherwise, it will be true.
            //Don't include quotes around your true/false. This value is a boolean, not a string!
            public bool allDay { get; set; }

            //The date/time an event begins. Required.
            //A Moment-ish input, like an ISO8601 string. Throughout the API this will become a real Moment object.
            public DateTime start { get; set; }

            //The exclusive date/time an event ends. Optional.
            //A Moment-ish input, like an ISO8601 string. Throughout the API this will become a real Moment object.
            //It is the moment immediately after the event has ended. For example, if the last full day of an event is Thursday, the exclusive end of the event will be 00:00:00 on Friday!
            public DateTime end { get; set; }

            //String. Optional.
            //A URL that will be visited when this event is clicked by the user. For more information on controlling this behavior, see the eventClick callback.
            public string url { get; set; }

            //String/Array. Optional.
            //A CSS class (or array of classes) that will be attached to this event's element.
            public string className { get; set; }

            //true or false. Optional.
            //Overrides the master editable option for this single event.
            public bool editable { get; set; }

            //true or false. Optional.
            //Overrides the master eventStartEditable option for this single event.
            public bool startEditable { get; set; }

            //true or false. Optional.
            //Overrides the master eventDurationEditable option for this single event.
            public bool durationEditable { get; set; }

            //Allows alternate rendering of the event, like background events.
            //Can be empty, "background", or "inverse-background"
            public string rendering { get; set; }

            //true or false. Optional.
            //Overrides the master eventOverlap option for this single event.
            //If false, prevents this event from being dragged/resized over other events. Also prevents other events from being dragged/resized over this event.
            public bool overlap { get; set; }

            //an event ID, "businessHours", object. Optional.
            //Overrides the master eventConstraint option for this single event.
            public string constraint { get; set; }

            //Event Source Object. Automatically populated.
            //A reference to the event source that this event came from.
            public string source { get; set; }

            //Sets an event's background and border color just like the calendar-wide eventColor option.
            public string color { get; set; }

            //Sets an event's background color just like the calendar-wide eventBackgroundColor option.
            public string backgroundColor { get; set; }

            //Sets an event's border color just like the the calendar-wide eventBorderColor option.
            public string borderColor { get; set; }

            //Sets an event's text color just like the calendar-wide eventTextColor option.
            public string textColor { get; set; }
        }
    }
}