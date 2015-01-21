using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwakenYourSmile.Web.Models
{
    public class ClinicalHistoryModelHelper
    {
        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual ICollection<ClinicalHistory> ClinicalHistories { get; set; }

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

        public static IEnumerable<System.Web.Mvc.SelectListItem> ReasonForVisit
        {
            get
            {
                var reasons = new List<System.Web.Mvc.SelectListItem>();

                reasons.Add(new System.Web.Mvc.SelectListItem { Text = "Revisión", Value = "Revisión" });
                reasons.Add(new System.Web.Mvc.SelectListItem { Text = "Dolor", Value = "Dolor" });
                reasons.Add(new System.Web.Mvc.SelectListItem { Text = "Dientes Chuecos", Value = "Dientes Chuecos" });
                reasons.Add(new System.Web.Mvc.SelectListItem { Text = "Traumatismo", Value = "Traumatismo" });
                reasons.Add(new System.Web.Mvc.SelectListItem { Text = "Lesión bucal", Value = "Lesión bucal" });

                return reasons;
            }
        }
    }
}