using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwakenYourSmile
{
    public class DentalContext : DbContext
    {
        public DentalContext()
            : base()
        {

        }

        public DentalContext(string connectionStringName)
            : base(connectionStringName)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<ClinicalHistory> ClinicalHistories { get; set; }
    }
}
