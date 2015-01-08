using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AwakenYourSmile
{
    public class Patient
    {
        [Key]
        public Guid ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}