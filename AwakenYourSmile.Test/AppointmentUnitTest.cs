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
            
            Appointment.InsertAppointment(appointment);

            var loaded = Appointment.GetAppointments(appointment.ID).FirstOrDefault();

            Assert.AreEqual<Appointment>(appointment, loaded);

            loaded.Notes += " Adding more notes";

            Appointment.UpdateAppointment(loaded);

            var reloaded = Appointment.GetAppointments(loaded.ID).FirstOrDefault();

            Assert.AreEqual(loaded.Notes, reloaded.Notes);

            Appointment.DeleteAppointment(reloaded);

            var removed = Appointment.GetAppointments(reloaded.ID).FirstOrDefault();

            Assert.IsNull(removed);
        }
    }
}
