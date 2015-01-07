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
        public void AppointmentCRUD()
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
    }
}
