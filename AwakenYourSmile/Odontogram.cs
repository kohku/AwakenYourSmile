using Rainbow.Web;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwakenYourSmile
{
    public class Odontogram : BusinessBase<Odontogram, Guid>, IEquatable<Odontogram>
    {
        public Odontogram()
            : base(Guid.NewGuid())
        {

        }

        public Odontogram(Guid id)
            : base(id)
        {

        }

        private string _reference;
        public string Reference
        {
            get { return _reference; }
            set
            {
                var changed = !object.Equals(_reference, value);
                if (changed)
                    this.OnPropertyChanging("Reference");
                this._reference = value;
                if (changed)
                    MarkChanged("Reference");
            }
        }

        protected override void ValidationRules()
        {
            AddRule("EmptyCreatedBy", "CreatedBy must be set.",
                string.IsNullOrEmpty(this.CreatedBy));
            AddRule("MaxCreatedByLength", "CreatedBy cannot exceed 256 chars.",
                !string.IsNullOrEmpty(this.CreatedBy) && this.CreatedBy.Length > 256);
            AddRule("EmptyLastUpdatedBy", "LastUpdatedBy must be set.",
                !IsNew && IsChanged && string.IsNullOrEmpty(this.LastUpdatedBy));
            AddRule("MaxLastUpdatedByLength", "LastUpdatedBy cannot exceed 256 chars.",
                !IsNew && IsChanged && !string.IsNullOrEmpty(this.LastUpdatedBy) && this.LastUpdatedBy.Length > 256);
        }

        protected override Odontogram DataSelect(Guid id)
        {
            return Odontogram.GetOdontograms(id).FirstOrDefault();
        }

        protected override void DataUpdate()
        {
            Odontogram.UpdateOdontogram(this);
        }

        protected override void DataInsert()
        {
            Odontogram.InsertOdontogram(this);
        }

        protected override void DataDelete()
        {
            Odontogram.DeleteOdontogram(this);
        }

        internal static List<Odontogram> GetOdontograms(Guid? id)
        {
            List<Odontogram> entities = new List<Odontogram>();

            using (var db = new DentalContext("DentalContextDb"))
            {
                var query = from o in db.Odontograms
                            where !id.HasValue || o.ID == id.Value
                            select o;

                entities.AddRange(query);
            }

            return entities;
        }

        internal static void UpdateOdontogram(Odontogram entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            using (var db = new DentalContext("DentalContextDb"))
            {
                db.Odontograms.Attach(entity);

                var entry = db.Entry(entity);
                entry.State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        internal static void InsertOdontogram(Odontogram entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            using (var db = new DentalContext("DentalContextDb"))
            {
                db.Odontograms.Add(entity);

                db.SaveChanges();
            }
        }

        internal static void DeleteOdontogram(Odontogram entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            using (var db = new DentalContext("DentalContextDb"))
            {
                var item = db.Odontograms.Find(entity.ID);

                if (item == null)
                    return;

                db.Odontograms.Remove(item);

                db.SaveChanges();
            }
        }

        public bool Equals(Odontogram other)
        {
            if (other == null)
                return false;

            return this.ID == other.ID;
        }
    }
}
