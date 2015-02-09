using Rainbow.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Rainbow.Web.Utilities;

namespace AwakenYourSmile
{
    public class Appointment : BusinessBase<Appointment, Guid>, IEquatable<Appointment>
    {
        public Appointment()
            : base(Guid.NewGuid())
        {

        }

        private DateTime _appointmentDate;
        [Required(ErrorMessage = "La fecha de la cita es requerida.")]

        public DateTime AppointmentDate
        {
            get { return _appointmentDate; }
            set
            {
                var changed = !object.Equals(_appointmentDate, value.RoundToSqlDateTime());
                if (changed)
                    this.OnPropertyChanging("AppointmentDate");
                this._appointmentDate = value.RoundToSqlDateTime();
                if (changed)
                    MarkChanged("AppointmentDate");
            }
        }

        private TimeSpan _appointmentTime;
        [Required(ErrorMessage = "La hora de la cita es requerida.")]
        public TimeSpan AppointmentTime
        {
            get { return _appointmentTime; }
            set
            {
                var changed = !object.Equals(_appointmentTime, value);
                if (changed)
                    this.OnPropertyChanging("AppointmentTime");
                this._appointmentTime = value;
                if (changed)
                    MarkChanged("AppointmentTime");
            }
        }

        private string _firstName;
        [Required(ErrorMessage="El nombre es requerido.")]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                var changed = !object.Equals(_firstName, value);
                if (changed)
                    this.OnPropertyChanging("FirstName");
                this._firstName = value;
                if (changed)
                    MarkChanged("FirstName");
            }
        }

        private string _lastName;
        [Required(ErrorMessage = "El apellido es requerido.")]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                var changed = !object.Equals(_lastName, value);
                if (changed)
                    this.OnPropertyChanging("LastName");
                this._lastName = value;
                if (changed)
                    MarkChanged("LastName");
            }
        }

        private string _email;
        [Required(ErrorMessage = "El email es requerido.")]
        public string Email
        {
            get { return _email; }
            set
            {
                var changed = !object.Equals(_email, value);
                if (changed)
                    this.OnPropertyChanging("Email");
                this._email = value;
                if (changed)
                    MarkChanged("Email");
            }
        }

        private string _phoneNumber;
        [Required(ErrorMessage = "El teléfono es requerido.")]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                var changed = !object.Equals(_phoneNumber, value);
                if (changed)
                    this.OnPropertyChanging("PhoneNumber");
                this._phoneNumber = value;
                if (changed)
                    MarkChanged("PhoneNumber");
            }
        }

        private string _cellPhone;
        public string CellPhone
        {
            get { return _cellPhone; }
            set
            {
                var changed = !object.Equals(_cellPhone, value);
                if (changed)
                    this.OnPropertyChanging("CellPhone");
                this._cellPhone = value;
                if (changed)
                    MarkChanged("CellPhone");
            }
        }

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set
            {
                var changed = !object.Equals(_notes, value);
                if (changed)
                    this.OnPropertyChanging("Notes");
                this._notes = value;
                if (changed)
                    MarkChanged("Notes");
            }
        }

        private bool _booked;
        public bool Booked
        {
            get { return _booked; }
            set
            {
                var changed = !object.Equals(_booked, value);
                if (changed)
                    this.OnPropertyChanging("Booked");
                this._booked = value;
                if (changed)
                    MarkChanged("Booked");
            }
        }

        private bool _cancelled;
        public bool Cancelled
        {
            get { return _cancelled; }
            set
            {
                var changed = !object.Equals(_cancelled, value);
                if (changed)
                    this.OnPropertyChanging("Cancelled");
                this._cancelled = value;
                if (changed)
                    MarkChanged("Cancelled");
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Appointment;

            return Equals(other);
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }

        public bool Equals(Appointment other)
        {
            if (other == null)
                return false;

            return this.ID == other.ID;
        }

        protected override void ValidationRules()
        {
        }

        protected override Appointment DataSelect(Guid id)
        {
            return Appointment.GetAppointments(id, null, null, null, null).FirstOrDefault();
        }

        protected override void DataUpdate()
        {
            Appointment.UpdateAppointment(this);
        }

        protected override void DataInsert()
        {
            Appointment.InsertAppointment(this);
        }

        protected override void DataDelete()
        {
            Appointment.DeleteAppointment(this);
        }

        internal static void InsertAppointment(Appointment entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            using (var db = new DentalContext("DentalContextDb"))
            {
                db.Appointments.Add(entity);

                db.SaveChanges();
            }
        }

        internal static void DeleteAppointment(Appointment entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            using (var db = new DentalContext("DentalContextDb"))
            {
                var item = db.Appointments.Find(entity.ID);

                if (item == null)
                    return;

                db.Appointments.Remove(item);

                db.SaveChanges();
            }
        }

        internal static void UpdateAppointment(Appointment entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            using (var db = new DentalContext("DentalContextDb"))
            {
                db.Appointments.Attach(entity);

                var entry = db.Entry(entity);
                entry.State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        public static List<Appointment> GetAppointments()
        {
            return Appointment.GetAppointments(null, null, null, null, null);
        }

        public static List<Appointment> GetAppointments(DateTime? start, DateTime? end)
        {
            return Appointment.GetAppointments(null, start, end, null, null);
        }

        public static List<Appointment> GetAppointments(Guid? id, DateTime? start, DateTime? end, bool? booked, bool? cancelled)
        {
            List<Appointment> entities = new List<Appointment>();

            using (var db = new DentalContext("DentalContextDb"))
            {
                var query = from a in db.Appointments
                            where !id.HasValue || a.ID == id.Value
                            where !start.HasValue || a.AppointmentDate >= start.Value
                            where !end.HasValue || a.AppointmentDate <= end.Value
                            where !booked.HasValue || a.Booked == booked.Value
                            where !cancelled.HasValue || a.Cancelled == cancelled.Value
                            select a;

                entities.AddRange(query);
            }

            return entities;
        }
    }
}