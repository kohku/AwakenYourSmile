using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AwakenYourSmile.Test
{
    [TestClass]
    public class AppointmentUnitTest
    {
        [TestMethod]
        public void GetAppointments()
        {
            var appointments = Appointment.GetAppointments();

            Assert.IsNotNull(appointments);
        }
        
        [TestMethod]
        public void SimpleCRUD()
        {
            var appointment = new Appointment
            {
                ID = Guid.NewGuid(),
                FirstName = "FirstName",
                LastName = "LastName",
                AppointmentDate = DateTime.Now.AddDays(1),
                PhoneNumber = "9876543210",
                CellPhone = "0123456789",
                Email = "email@someone.com",
                Notes = "Some notes"
            };

            appointment.Save();

            var loaded = Appointment.Load(appointment.ID);

            Assert.AreEqual<Appointment>(appointment, loaded);

            loaded.Notes += " Adding more notes";

            loaded.AcceptChanges();

            var reloaded = Appointment.Load(loaded.ID);

            Assert.AreEqual(loaded.Notes, reloaded.Notes);

            reloaded.Delete();
            reloaded.AcceptChanges();

            var removed = Appointment.Load(reloaded.ID);

            Assert.IsNull(removed);
        }

        [TestMethod]
        public void PersistAllProperties()
        {
            var appointment = new Appointment
            {
                ID = Guid.NewGuid(),
                FirstName = "FirstName",
                LastName = "LastName",
                AppointmentDate = DateTime.Now.AddDays(1),
                PhoneNumber = "9876543210",
                CellPhone = "0123456789",
                Email = "email@someone.com",
                Notes = "Some notes",
                CreatedBy = "dcruz",
                DateCreated = DateTime.Now
            };

            appointment.Save();

            var loaded = Appointment.Load(appointment.ID);

            Compare(appointment, loaded);

            loaded.FirstName += "1";
            loaded.LastName += "1";
            loaded.AppointmentDate = DateTime.Now.AddDays(1);
            loaded.PhoneNumber += "1";
            loaded.CellPhone += "1";
            loaded.Email += "1";
            loaded.Notes += "1";
            loaded.CreatedBy += "1";
            loaded.DateCreated = DateTime.Now;
            loaded.LastUpdatedBy += "1";
            loaded.LastUpdated = DateTime.Now;

            loaded.AcceptChanges();

            var reloaded = Appointment.Load(loaded.ID);

            Compare(loaded, reloaded);

            reloaded.Delete();
            reloaded.AcceptChanges();
        }

        private static void Compare(Appointment appointment1, Appointment appointment2)
        {
            if (appointment1 == null)
                throw new ArgumentNullException("appointment1");

            if (appointment2 == null)
                throw new ArgumentNullException("appointment2");

            Assert.AreEqual(appointment1.ID, appointment2.ID);
            Assert.AreEqual(appointment1.FirstName, appointment2.FirstName);
            Assert.AreEqual(appointment1.LastName, appointment2.LastName);
            Assert.AreEqual(appointment1.AppointmentDate, appointment2.AppointmentDate);
            Assert.AreEqual(appointment1.PhoneNumber, appointment2.PhoneNumber);
            Assert.AreEqual(appointment1.CellPhone, appointment2.CellPhone);
            Assert.AreEqual(appointment1.Email, appointment2.Email);
            Assert.AreEqual(appointment1.Notes, appointment2.Notes);
            Assert.AreEqual(appointment1.CreatedBy, appointment2.CreatedBy);
            Assert.AreEqual(appointment1.DateCreated, appointment2.DateCreated);
            Assert.AreEqual(appointment1.LastUpdatedBy, appointment2.LastUpdatedBy);
            Assert.AreEqual(appointment1.LastUpdated, appointment2.LastUpdated);
        }
    }
}
