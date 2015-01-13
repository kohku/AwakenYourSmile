using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwakenYourSmile.Web.Models
{
    public class ClinicalHistoryModelHelper
    {
        public static IEnumerable<System.Web.Mvc.SelectListItem> Genders
        {
            get
            {
                var genders = new List<System.Web.Mvc.SelectListItem>();

                genders.Add(new System.Web.Mvc.SelectListItem { Text = "Masculino", Value = Gender.Male.ToString() });
                genders.Add(new System.Web.Mvc.SelectListItem { Text = "Femenino", Value = Gender.Female.ToString() });

                return genders;
            }
        }
        public virtual ICollection<ClinicalHistory> ClinicalHistories { get; set; }

    }
}