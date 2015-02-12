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

        private string _treatment;
        public string Treatment
        {
            get { return _treatment; }
            set
            {
                var changed = !object.Equals(_treatment, value);
                if (changed)
                    this.OnPropertyChanging("Treatment");
                this._treatment = value;
                if (changed)
                    MarkChanged("Treatment");
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

        private string _item18A;
        public string Item18A
        {
            get { return _item18A; }
            set
            {
                var changed = !object.Equals(_item18A, value);
                if (changed)
                    this.OnPropertyChanging("Item18A");
                this._item18A = value;
                if (changed)
                    MarkChanged("Item18A");
            }
        }

        private string _item18B;
        public string Item18B
        {
            get { return _item18B; }
            set
            {
                var changed = !object.Equals(_item18B, value);
                if (changed)
                    this.OnPropertyChanging("Item18A");
                this._item18B = value;
                if (changed)
                    MarkChanged("Item18A");
            }
        }

        private string _item18C;
        public string Item18C
        {
            get { return _item18C; }
            set
            {
                var changed = !object.Equals(_item18C, value);
                if (changed)
                    this.OnPropertyChanging("Item18A");
                this._item18C = value;
                if (changed)
                    MarkChanged("Item18A");
            }
        }

        private string _item18D;
        public string Item18D
        {
            get { return _item18D; }
            set
            {
                var changed = !object.Equals(_item18D, value);
                if (changed)
                    this.OnPropertyChanging("Item18D");
                this._item18D = value;
                if (changed)
                    MarkChanged("Item18D");
            }
        }

        private string _item17A;
        public string Item17A
        {
            get { return _item17A; }
            set
            {
                var changed = !object.Equals(_item17A, value);
                if (changed)
                    this.OnPropertyChanging("Item17A");
                this._item17A = value;
                if (changed)
                    MarkChanged("Item17A");
            }
        }

        private string _item17B;
        public string Item17B
        {
            get { return _item17B; }
            set
            {
                var changed = !object.Equals(_item17B, value);
                if (changed)
                    this.OnPropertyChanging("Item17A");
                this._item17B = value;
                if (changed)
                    MarkChanged("Item17A");
            }
        }

        private string _item17C;
        public string Item17C
        {
            get { return _item17C; }
            set
            {
                var changed = !object.Equals(_item17C, value);
                if (changed)
                    this.OnPropertyChanging("Item17A");
                this._item17C = value;
                if (changed)
                    MarkChanged("Item17A");
            }
        }

        private string _item17D;
        public string Item17D
        {
            get { return _item17D; }
            set
            {
                var changed = !object.Equals(_item17D, value);
                if (changed)
                    this.OnPropertyChanging("Item17D");
                this._item17D = value;
                if (changed)
                    MarkChanged("Item17D");
            }
        }

        private string _item16A;
        public string Item16A
        {
            get { return _item16A; }
            set
            {
                var changed = !object.Equals(_item16A, value);
                if (changed)
                    this.OnPropertyChanging("Item16A");
                this._item16A = value;
                if (changed)
                    MarkChanged("Item16A");
            }
        }

        private string _item16B;
        public string Item16B
        {
            get { return _item16B; }
            set
            {
                var changed = !object.Equals(_item16B, value);
                if (changed)
                    this.OnPropertyChanging("Item16A");
                this._item16B = value;
                if (changed)
                    MarkChanged("Item16A");
            }
        }

        private string _item16C;
        public string Item16C
        {
            get { return _item16C; }
            set
            {
                var changed = !object.Equals(_item16C, value);
                if (changed)
                    this.OnPropertyChanging("Item16A");
                this._item16C = value;
                if (changed)
                    MarkChanged("Item16A");
            }
        }

        private string _item16D;
        public string Item16D
        {
            get { return _item16D; }
            set
            {
                var changed = !object.Equals(_item16D, value);
                if (changed)
                    this.OnPropertyChanging("Item16D");
                this._item16D = value;
                if (changed)
                    MarkChanged("Item16D");
            }
        }

        private string _item15A;
        public string Item15A
        {
            get { return _item15A; }
            set
            {
                var changed = !object.Equals(_item15A, value);
                if (changed)
                    this.OnPropertyChanging("Item15A");
                this._item15A = value;
                if (changed)
                    MarkChanged("Item15A");
            }
        }

        private string _item15B;
        public string Item15B
        {
            get { return _item15B; }
            set
            {
                var changed = !object.Equals(_item15B, value);
                if (changed)
                    this.OnPropertyChanging("Item15A");
                this._item15B = value;
                if (changed)
                    MarkChanged("Item15A");
            }
        }

        private string _item15C;
        public string Item15C
        {
            get { return _item15C; }
            set
            {
                var changed = !object.Equals(_item15C, value);
                if (changed)
                    this.OnPropertyChanging("Item15A");
                this._item15C = value;
                if (changed)
                    MarkChanged("Item15A");
            }
        }

        private string _item15D;
        public string Item15D
        {
            get { return _item15D; }
            set
            {
                var changed = !object.Equals(_item15D, value);
                if (changed)
                    this.OnPropertyChanging("Item15D");
                this._item15D = value;
                if (changed)
                    MarkChanged("Item15D");
            }
        }

        private string _item14A;
        public string Item14A
        {
            get { return _item14A; }
            set
            {
                var changed = !object.Equals(_item14A, value);
                if (changed)
                    this.OnPropertyChanging("Item14A");
                this._item14A = value;
                if (changed)
                    MarkChanged("Item14A");
            }
        }

        private string _item14B;
        public string Item14B
        {
            get { return _item14B; }
            set
            {
                var changed = !object.Equals(_item14B, value);
                if (changed)
                    this.OnPropertyChanging("Item14A");
                this._item14B = value;
                if (changed)
                    MarkChanged("Item14A");
            }
        }

        private string _item14C;
        public string Item14C
        {
            get { return _item14C; }
            set
            {
                var changed = !object.Equals(_item14C, value);
                if (changed)
                    this.OnPropertyChanging("Item14A");
                this._item14C = value;
                if (changed)
                    MarkChanged("Item14A");
            }
        }

        private string _item14D;
        public string Item14D
        {
            get { return _item14D; }
            set
            {
                var changed = !object.Equals(_item14D, value);
                if (changed)
                    this.OnPropertyChanging("Item14D");
                this._item14D = value;
                if (changed)
                    MarkChanged("Item14D");
            }
        }

        private string _item13A;
        public string Item13A
        {
            get { return _item13A; }
            set
            {
                var changed = !object.Equals(_item13A, value);
                if (changed)
                    this.OnPropertyChanging("Item13A");
                this._item13A = value;
                if (changed)
                    MarkChanged("Item13A");
            }
        }

        private string _item13B;
        public string Item13B
        {
            get { return _item13B; }
            set
            {
                var changed = !object.Equals(_item13B, value);
                if (changed)
                    this.OnPropertyChanging("Item13A");
                this._item13B = value;
                if (changed)
                    MarkChanged("Item13A");
            }
        }

        private string _item13C;
        public string Item13C
        {
            get { return _item13C; }
            set
            {
                var changed = !object.Equals(_item13C, value);
                if (changed)
                    this.OnPropertyChanging("Item13A");
                this._item13C = value;
                if (changed)
                    MarkChanged("Item13A");
            }
        }

        private string _item13D;
        public string Item13D
        {
            get { return _item13D; }
            set
            {
                var changed = !object.Equals(_item13D, value);
                if (changed)
                    this.OnPropertyChanging("Item13D");
                this._item13D = value;
                if (changed)
                    MarkChanged("Item13D");
            }
        }

        private string _item12A;
        public string Item12A
        {
            get { return _item12A; }
            set
            {
                var changed = !object.Equals(_item12A, value);
                if (changed)
                    this.OnPropertyChanging("Item12A");
                this._item12A = value;
                if (changed)
                    MarkChanged("Item12A");
            }
        }

        private string _item12B;
        public string Item12B
        {
            get { return _item12B; }
            set
            {
                var changed = !object.Equals(_item12B, value);
                if (changed)
                    this.OnPropertyChanging("Item12A");
                this._item12B = value;
                if (changed)
                    MarkChanged("Item12A");
            }
        }

        private string _item12C;
        public string Item12C
        {
            get { return _item12C; }
            set
            {
                var changed = !object.Equals(_item12C, value);
                if (changed)
                    this.OnPropertyChanging("Item12A");
                this._item12C = value;
                if (changed)
                    MarkChanged("Item12A");
            }
        }

        private string _item12D;
        public string Item12D
        {
            get { return _item12D; }
            set
            {
                var changed = !object.Equals(_item12D, value);
                if (changed)
                    this.OnPropertyChanging("Item12D");
                this._item12D = value;
                if (changed)
                    MarkChanged("Item12D");
            }
        }

        private string _item11A;
        public string Item11A
        {
            get { return _item11A; }
            set
            {
                var changed = !object.Equals(_item11A, value);
                if (changed)
                    this.OnPropertyChanging("Item11A");
                this._item11A = value;
                if (changed)
                    MarkChanged("Item11A");
            }
        }

        private string _item11B;
        public string Item11B
        {
            get { return _item11B; }
            set
            {
                var changed = !object.Equals(_item11B, value);
                if (changed)
                    this.OnPropertyChanging("Item11A");
                this._item11B = value;
                if (changed)
                    MarkChanged("Item11A");
            }
        }

        private string _item11C;
        public string Item11C
        {
            get { return _item11C; }
            set
            {
                var changed = !object.Equals(_item11C, value);
                if (changed)
                    this.OnPropertyChanging("Item11A");
                this._item11C = value;
                if (changed)
                    MarkChanged("Item11A");
            }
        }

        private string _item11D;
        public string Item11D
        {
            get { return _item11D; }
            set
            {
                var changed = !object.Equals(_item11D, value);
                if (changed)
                    this.OnPropertyChanging("Item11D");
                this._item11D = value;
                if (changed)
                    MarkChanged("Item11D");
            }
        }

        private string _item21A;
        public string Item21A
        {
            get { return _item21A; }
            set
            {
                var changed = !object.Equals(_item21A, value);
                if (changed)
                    this.OnPropertyChanging("Item21A");
                this._item21A = value;
                if (changed)
                    MarkChanged("Item21A");
            }
        }

        private string _item21B;
        public string Item21B
        {
            get { return _item21B; }
            set
            {
                var changed = !object.Equals(_item21B, value);
                if (changed)
                    this.OnPropertyChanging("Item21A");
                this._item21B = value;
                if (changed)
                    MarkChanged("Item21A");
            }
        }

        private string _item21C;
        public string Item21C
        {
            get { return _item21C; }
            set
            {
                var changed = !object.Equals(_item21C, value);
                if (changed)
                    this.OnPropertyChanging("Item21A");
                this._item21C = value;
                if (changed)
                    MarkChanged("Item21A");
            }
        }

        private string _item21D;
        public string Item21D
        {
            get { return _item21D; }
            set
            {
                var changed = !object.Equals(_item21D, value);
                if (changed)
                    this.OnPropertyChanging("Item21D");
                this._item21D = value;
                if (changed)
                    MarkChanged("Item21D");
            }
        }

        private string _item22A;
        public string Item22A
        {
            get { return _item22A; }
            set
            {
                var changed = !object.Equals(_item22A, value);
                if (changed)
                    this.OnPropertyChanging("Item22A");
                this._item22A = value;
                if (changed)
                    MarkChanged("Item22A");
            }
        }

        private string _item22B;
        public string Item22B
        {
            get { return _item22B; }
            set
            {
                var changed = !object.Equals(_item22B, value);
                if (changed)
                    this.OnPropertyChanging("Item22A");
                this._item22B = value;
                if (changed)
                    MarkChanged("Item22A");
            }
        }

        private string _item22C;
        public string Item22C
        {
            get { return _item22C; }
            set
            {
                var changed = !object.Equals(_item22C, value);
                if (changed)
                    this.OnPropertyChanging("Item22A");
                this._item22C = value;
                if (changed)
                    MarkChanged("Item22A");
            }
        }

        private string _item22D;
        public string Item22D
        {
            get { return _item22D; }
            set
            {
                var changed = !object.Equals(_item22D, value);
                if (changed)
                    this.OnPropertyChanging("Item22D");
                this._item22D = value;
                if (changed)
                    MarkChanged("Item22D");
            }
        }

        private string _item23A;
        public string Item23A
        {
            get { return _item23A; }
            set
            {
                var changed = !object.Equals(_item23A, value);
                if (changed)
                    this.OnPropertyChanging("Item23A");
                this._item23A = value;
                if (changed)
                    MarkChanged("Item23A");
            }
        }

        private string _item23B;
        public string Item23B
        {
            get { return _item23B; }
            set
            {
                var changed = !object.Equals(_item23B, value);
                if (changed)
                    this.OnPropertyChanging("Item23A");
                this._item23B = value;
                if (changed)
                    MarkChanged("Item23A");
            }
        }

        private string _item23C;
        public string Item23C
        {
            get { return _item23C; }
            set
            {
                var changed = !object.Equals(_item23C, value);
                if (changed)
                    this.OnPropertyChanging("Item23A");
                this._item23C = value;
                if (changed)
                    MarkChanged("Item23A");
            }
        }

        private string _item23D;
        public string Item23D
        {
            get { return _item23D; }
            set
            {
                var changed = !object.Equals(_item23D, value);
                if (changed)
                    this.OnPropertyChanging("Item23D");
                this._item23D = value;
                if (changed)
                    MarkChanged("Item23D");
            }
        }

        private string _item24A;
        public string Item24A
        {
            get { return _item24A; }
            set
            {
                var changed = !object.Equals(_item24A, value);
                if (changed)
                    this.OnPropertyChanging("Item24A");
                this._item24A = value;
                if (changed)
                    MarkChanged("Item24A");
            }
        }

        private string _item24B;
        public string Item24B
        {
            get { return _item24B; }
            set
            {
                var changed = !object.Equals(_item24B, value);
                if (changed)
                    this.OnPropertyChanging("Item24A");
                this._item24B = value;
                if (changed)
                    MarkChanged("Item24A");
            }
        }

        private string _item24C;
        public string Item24C
        {
            get { return _item24C; }
            set
            {
                var changed = !object.Equals(_item24C, value);
                if (changed)
                    this.OnPropertyChanging("Item24A");
                this._item24C = value;
                if (changed)
                    MarkChanged("Item24A");
            }
        }

        private string _item24D;
        public string Item24D
        {
            get { return _item24D; }
            set
            {
                var changed = !object.Equals(_item24D, value);
                if (changed)
                    this.OnPropertyChanging("Item24D");
                this._item24D = value;
                if (changed)
                    MarkChanged("Item24D");
            }
        }

        private string _item25A;
        public string Item25A
        {
            get { return _item25A; }
            set
            {
                var changed = !object.Equals(_item25A, value);
                if (changed)
                    this.OnPropertyChanging("Item25A");
                this._item25A = value;
                if (changed)
                    MarkChanged("Item25A");
            }
        }

        private string _item25B;
        public string Item25B
        {
            get { return _item25B; }
            set
            {
                var changed = !object.Equals(_item25B, value);
                if (changed)
                    this.OnPropertyChanging("Item25A");
                this._item25B = value;
                if (changed)
                    MarkChanged("Item25A");
            }
        }

        private string _item25C;
        public string Item25C
        {
            get { return _item25C; }
            set
            {
                var changed = !object.Equals(_item25C, value);
                if (changed)
                    this.OnPropertyChanging("Item25A");
                this._item25C = value;
                if (changed)
                    MarkChanged("Item25A");
            }
        }

        private string _item25D;
        public string Item25D
        {
            get { return _item25D; }
            set
            {
                var changed = !object.Equals(_item25D, value);
                if (changed)
                    this.OnPropertyChanging("Item25D");
                this._item25D = value;
                if (changed)
                    MarkChanged("Item25D");
            }
        }

        private string _item26A;
        public string Item26A
        {
            get { return _item26A; }
            set
            {
                var changed = !object.Equals(_item26A, value);
                if (changed)
                    this.OnPropertyChanging("Item26A");
                this._item26A = value;
                if (changed)
                    MarkChanged("Item26A");
            }
        }

        private string _item26B;
        public string Item26B
        {
            get { return _item26B; }
            set
            {
                var changed = !object.Equals(_item26B, value);
                if (changed)
                    this.OnPropertyChanging("Item26A");
                this._item26B = value;
                if (changed)
                    MarkChanged("Item26A");
            }
        }

        private string _item26C;
        public string Item26C
        {
            get { return _item26C; }
            set
            {
                var changed = !object.Equals(_item26C, value);
                if (changed)
                    this.OnPropertyChanging("Item26A");
                this._item26C = value;
                if (changed)
                    MarkChanged("Item26A");
            }
        }

        private string _item26D;
        public string Item26D
        {
            get { return _item26D; }
            set
            {
                var changed = !object.Equals(_item26D, value);
                if (changed)
                    this.OnPropertyChanging("Item26D");
                this._item26D = value;
                if (changed)
                    MarkChanged("Item26D");
            }
        }

        private string _item27A;
        public string Item27A
        {
            get { return _item27A; }
            set
            {
                var changed = !object.Equals(_item27A, value);
                if (changed)
                    this.OnPropertyChanging("Item27A");
                this._item27A = value;
                if (changed)
                    MarkChanged("Item27A");
            }
        }

        private string _item27B;
        public string Item27B
        {
            get { return _item27B; }
            set
            {
                var changed = !object.Equals(_item27B, value);
                if (changed)
                    this.OnPropertyChanging("Item27A");
                this._item27B = value;
                if (changed)
                    MarkChanged("Item27A");
            }
        }

        private string _item27C;
        public string Item27C
        {
            get { return _item27C; }
            set
            {
                var changed = !object.Equals(_item27C, value);
                if (changed)
                    this.OnPropertyChanging("Item27A");
                this._item27C = value;
                if (changed)
                    MarkChanged("Item27A");
            }
        }

        private string _item27D;
        public string Item27D
        {
            get { return _item27D; }
            set
            {
                var changed = !object.Equals(_item27D, value);
                if (changed)
                    this.OnPropertyChanging("Item27D");
                this._item27D = value;
                if (changed)
                    MarkChanged("Item27D");
            }
        }

        private string _item28A;
        public string Item28A
        {
            get { return _item28A; }
            set
            {
                var changed = !object.Equals(_item28A, value);
                if (changed)
                    this.OnPropertyChanging("Item28A");
                this._item28A = value;
                if (changed)
                    MarkChanged("Item28A");
            }
        }

        private string _item28B;
        public string Item28B
        {
            get { return _item28B; }
            set
            {
                var changed = !object.Equals(_item28B, value);
                if (changed)
                    this.OnPropertyChanging("Item28A");
                this._item28B = value;
                if (changed)
                    MarkChanged("Item28A");
            }
        }

        private string _item28C;
        public string Item28C
        {
            get { return _item28C; }
            set
            {
                var changed = !object.Equals(_item28C, value);
                if (changed)
                    this.OnPropertyChanging("Item28A");
                this._item28C = value;
                if (changed)
                    MarkChanged("Item28A");
            }
        }

        private string _item28D;
        public string Item28D
        {
            get { return _item28D; }
            set
            {
                var changed = !object.Equals(_item28D, value);
                if (changed)
                    this.OnPropertyChanging("Item28D");
                this._item28D = value;
                if (changed)
                    MarkChanged("Item28D");
            }
        }

        private string _item48A;
        public string Item48A
        {
            get { return _item48A; }
            set
            {
                var changed = !object.Equals(_item48A, value);
                if (changed)
                    this.OnPropertyChanging("Item48A");
                this._item48A = value;
                if (changed)
                    MarkChanged("Item48A");
            }
        }

        private string _item48B;
        public string Item48B
        {
            get { return _item48B; }
            set
            {
                var changed = !object.Equals(_item48B, value);
                if (changed)
                    this.OnPropertyChanging("Item48A");
                this._item48B = value;
                if (changed)
                    MarkChanged("Item48A");
            }
        }

        private string _item48C;
        public string Item48C
        {
            get { return _item48C; }
            set
            {
                var changed = !object.Equals(_item48C, value);
                if (changed)
                    this.OnPropertyChanging("Item48A");
                this._item48C = value;
                if (changed)
                    MarkChanged("Item48A");
            }
        }

        private string _item48D;
        public string Item48D
        {
            get { return _item48D; }
            set
            {
                var changed = !object.Equals(_item48D, value);
                if (changed)
                    this.OnPropertyChanging("Item48D");
                this._item48D = value;
                if (changed)
                    MarkChanged("Item48D");
            }
        }

        private string _item47A;
        public string Item47A
        {
            get { return _item47A; }
            set
            {
                var changed = !object.Equals(_item47A, value);
                if (changed)
                    this.OnPropertyChanging("Item47A");
                this._item47A = value;
                if (changed)
                    MarkChanged("Item47A");
            }
        }

        private string _item47B;
        public string Item47B
        {
            get { return _item47B; }
            set
            {
                var changed = !object.Equals(_item47B, value);
                if (changed)
                    this.OnPropertyChanging("Item47A");
                this._item47B = value;
                if (changed)
                    MarkChanged("Item47A");
            }
        }

        private string _item47C;
        public string Item47C
        {
            get { return _item47C; }
            set
            {
                var changed = !object.Equals(_item47C, value);
                if (changed)
                    this.OnPropertyChanging("Item47A");
                this._item47C = value;
                if (changed)
                    MarkChanged("Item47A");
            }
        }

        private string _item47D;
        public string Item47D
        {
            get { return _item47D; }
            set
            {
                var changed = !object.Equals(_item47D, value);
                if (changed)
                    this.OnPropertyChanging("Item47D");
                this._item47D = value;
                if (changed)
                    MarkChanged("Item47D");
            }
        }
        private string _item46A;
        public string Item46A
        {
            get { return _item46A; }
            set
            {
                var changed = !object.Equals(_item46A, value);
                if (changed)
                    this.OnPropertyChanging("Item46A");
                this._item46A = value;
                if (changed)
                    MarkChanged("Item46A");
            }
        }

        private string _item46B;
        public string Item46B
        {
            get { return _item46B; }
            set
            {
                var changed = !object.Equals(_item46B, value);
                if (changed)
                    this.OnPropertyChanging("Item46A");
                this._item46B = value;
                if (changed)
                    MarkChanged("Item46A");
            }
        }

        private string _item46C;
        public string Item46C
        {
            get { return _item46C; }
            set
            {
                var changed = !object.Equals(_item46C, value);
                if (changed)
                    this.OnPropertyChanging("Item46A");
                this._item46C = value;
                if (changed)
                    MarkChanged("Item46A");
            }
        }

        private string _item46D;
        public string Item46D
        {
            get { return _item46D; }
            set
            {
                var changed = !object.Equals(_item46D, value);
                if (changed)
                    this.OnPropertyChanging("Item46D");
                this._item46D = value;
                if (changed)
                    MarkChanged("Item46D");
            }
        }

        private string _item45A;
        public string Item45A
        {
            get { return _item45A; }
            set
            {
                var changed = !object.Equals(_item45A, value);
                if (changed)
                    this.OnPropertyChanging("Item45A");
                this._item45A = value;
                if (changed)
                    MarkChanged("Item45A");
            }
        }

        private string _item45B;
        public string Item45B
        {
            get { return _item45B; }
            set
            {
                var changed = !object.Equals(_item45B, value);
                if (changed)
                    this.OnPropertyChanging("Item45A");
                this._item45B = value;
                if (changed)
                    MarkChanged("Item45A");
            }
        }

        private string _item45C;
        public string Item45C
        {
            get { return _item45C; }
            set
            {
                var changed = !object.Equals(_item45C, value);
                if (changed)
                    this.OnPropertyChanging("Item45A");
                this._item45C = value;
                if (changed)
                    MarkChanged("Item45A");
            }
        }

        private string _item45D;
        public string Item45D
        {
            get { return _item45D; }
            set
            {
                var changed = !object.Equals(_item45D, value);
                if (changed)
                    this.OnPropertyChanging("Item45D");
                this._item45D = value;
                if (changed)
                    MarkChanged("Item45D");
            }
        }

        private string _item44A;
        public string Item44A
        {
            get { return _item44A; }
            set
            {
                var changed = !object.Equals(_item44A, value);
                if (changed)
                    this.OnPropertyChanging("Item44A");
                this._item44A = value;
                if (changed)
                    MarkChanged("Item44A");
            }
        }

        private string _item44B;
        public string Item44B
        {
            get { return _item44B; }
            set
            {
                var changed = !object.Equals(_item44B, value);
                if (changed)
                    this.OnPropertyChanging("Item44A");
                this._item44B = value;
                if (changed)
                    MarkChanged("Item44A");
            }
        }

        private string _item44C;
        public string Item44C
        {
            get { return _item44C; }
            set
            {
                var changed = !object.Equals(_item44C, value);
                if (changed)
                    this.OnPropertyChanging("Item44A");
                this._item44C = value;
                if (changed)
                    MarkChanged("Item44A");
            }
        }

        private string _item44D;
        public string Item44D
        {
            get { return _item44D; }
            set
            {
                var changed = !object.Equals(_item44D, value);
                if (changed)
                    this.OnPropertyChanging("Item44D");
                this._item44D = value;
                if (changed)
                    MarkChanged("Item44D");
            }
        }

        private string _item43A;
        public string Item43A
        {
            get { return _item43A; }
            set
            {
                var changed = !object.Equals(_item43A, value);
                if (changed)
                    this.OnPropertyChanging("Item43A");
                this._item43A = value;
                if (changed)
                    MarkChanged("Item43A");
            }
        }

        private string _item43B;
        public string Item43B
        {
            get { return _item43B; }
            set
            {
                var changed = !object.Equals(_item43B, value);
                if (changed)
                    this.OnPropertyChanging("Item43A");
                this._item43B = value;
                if (changed)
                    MarkChanged("Item43A");
            }
        }

        private string _item43C;
        public string Item43C
        {
            get { return _item43C; }
            set
            {
                var changed = !object.Equals(_item43C, value);
                if (changed)
                    this.OnPropertyChanging("Item43A");
                this._item43C = value;
                if (changed)
                    MarkChanged("Item43A");
            }
        }

        private string _item43D;
        public string Item43D
        {
            get { return _item43D; }
            set
            {
                var changed = !object.Equals(_item43D, value);
                if (changed)
                    this.OnPropertyChanging("Item43D");
                this._item43D = value;
                if (changed)
                    MarkChanged("Item43D");
            }
        }

        private string _item42A;
        public string Item42A
        {
            get { return _item42A; }
            set
            {
                var changed = !object.Equals(_item42A, value);
                if (changed)
                    this.OnPropertyChanging("Item42A");
                this._item42A = value;
                if (changed)
                    MarkChanged("Item42A");
            }
        }

        private string _item42B;
        public string Item42B
        {
            get { return _item42B; }
            set
            {
                var changed = !object.Equals(_item42B, value);
                if (changed)
                    this.OnPropertyChanging("Item42A");
                this._item42B = value;
                if (changed)
                    MarkChanged("Item42A");
            }
        }

        private string _item42C;
        public string Item42C
        {
            get { return _item42C; }
            set
            {
                var changed = !object.Equals(_item42C, value);
                if (changed)
                    this.OnPropertyChanging("Item42A");
                this._item42C = value;
                if (changed)
                    MarkChanged("Item42A");
            }
        }

        private string _item42D;
        public string Item42D
        {
            get { return _item42D; }
            set
            {
                var changed = !object.Equals(_item42D, value);
                if (changed)
                    this.OnPropertyChanging("Item42D");
                this._item42D = value;
                if (changed)
                    MarkChanged("Item42D");
            }
        }

        private string _item41A;
        public string Item41A
        {
            get { return _item41A; }
            set
            {
                var changed = !object.Equals(_item41A, value);
                if (changed)
                    this.OnPropertyChanging("Item41A");
                this._item41A = value;
                if (changed)
                    MarkChanged("Item41A");
            }
        }

        private string _item41B;
        public string Item41B
        {
            get { return _item41B; }
            set
            {
                var changed = !object.Equals(_item41B, value);
                if (changed)
                    this.OnPropertyChanging("Item41A");
                this._item41B = value;
                if (changed)
                    MarkChanged("Item41A");
            }
        }

        private string _item41C;
        public string Item41C
        {
            get { return _item41C; }
            set
            {
                var changed = !object.Equals(_item41C, value);
                if (changed)
                    this.OnPropertyChanging("Item41A");
                this._item41C = value;
                if (changed)
                    MarkChanged("Item41A");
            }
        }

        private string _item41D;
        public string Item41D
        {
            get { return _item41D; }
            set
            {
                var changed = !object.Equals(_item41D, value);
                if (changed)
                    this.OnPropertyChanging("Item41D");
                this._item41D = value;
                if (changed)
                    MarkChanged("Item41D");
            }
        }

        private string _item31A;
        public string Item31A
        {
            get { return _item31A; }
            set
            {
                var changed = !object.Equals(_item31A, value);
                if (changed)
                    this.OnPropertyChanging("Item31A");
                this._item31A = value;
                if (changed)
                    MarkChanged("Item31A");
            }
        }

        private string _item31B;
        public string Item31B
        {
            get { return _item31B; }
            set
            {
                var changed = !object.Equals(_item31B, value);
                if (changed)
                    this.OnPropertyChanging("Item31A");
                this._item31B = value;
                if (changed)
                    MarkChanged("Item31A");
            }
        }

        private string _item31C;
        public string Item31C
        {
            get { return _item31C; }
            set
            {
                var changed = !object.Equals(_item31C, value);
                if (changed)
                    this.OnPropertyChanging("Item31A");
                this._item31C = value;
                if (changed)
                    MarkChanged("Item31A");
            }
        }

        private string _item31D;
        public string Item31D
        {
            get { return _item31D; }
            set
            {
                var changed = !object.Equals(_item31D, value);
                if (changed)
                    this.OnPropertyChanging("Item31D");
                this._item31D = value;
                if (changed)
                    MarkChanged("Item31D");
            }
        }

        private string _item32A;
        public string Item32A
        {
            get { return _item32A; }
            set
            {
                var changed = !object.Equals(_item32A, value);
                if (changed)
                    this.OnPropertyChanging("Item32A");
                this._item32A = value;
                if (changed)
                    MarkChanged("Item32A");
            }
        }

        private string _item32B;
        public string Item32B
        {
            get { return _item32B; }
            set
            {
                var changed = !object.Equals(_item32B, value);
                if (changed)
                    this.OnPropertyChanging("Item32A");
                this._item32B = value;
                if (changed)
                    MarkChanged("Item32A");
            }
        }

        private string _item32C;
        public string Item32C
        {
            get { return _item32C; }
            set
            {
                var changed = !object.Equals(_item32C, value);
                if (changed)
                    this.OnPropertyChanging("Item32A");
                this._item32C = value;
                if (changed)
                    MarkChanged("Item32A");
            }
        }

        private string _item32D;
        public string Item32D
        {
            get { return _item32D; }
            set
            {
                var changed = !object.Equals(_item32D, value);
                if (changed)
                    this.OnPropertyChanging("Item32D");
                this._item32D = value;
                if (changed)
                    MarkChanged("Item32D");
            }
        }

        private string _item33A;
        public string Item33A
        {
            get { return _item33A; }
            set
            {
                var changed = !object.Equals(_item33A, value);
                if (changed)
                    this.OnPropertyChanging("Item33A");
                this._item33A = value;
                if (changed)
                    MarkChanged("Item33A");
            }
        }

        private string _item33B;
        public string Item33B
        {
            get { return _item33B; }
            set
            {
                var changed = !object.Equals(_item33B, value);
                if (changed)
                    this.OnPropertyChanging("Item33A");
                this._item33B = value;
                if (changed)
                    MarkChanged("Item33A");
            }
        }

        private string _item33C;
        public string Item33C
        {
            get { return _item33C; }
            set
            {
                var changed = !object.Equals(_item33C, value);
                if (changed)
                    this.OnPropertyChanging("Item33A");
                this._item33C = value;
                if (changed)
                    MarkChanged("Item33A");
            }
        }

        private string _item33D;
        public string Item33D
        {
            get { return _item33D; }
            set
            {
                var changed = !object.Equals(_item33D, value);
                if (changed)
                    this.OnPropertyChanging("Item33D");
                this._item33D = value;
                if (changed)
                    MarkChanged("Item33D");
            }
        }

        private string _item34A;
        public string Item34A
        {
            get { return _item34A; }
            set
            {
                var changed = !object.Equals(_item34A, value);
                if (changed)
                    this.OnPropertyChanging("Item34A");
                this._item34A = value;
                if (changed)
                    MarkChanged("Item34A");
            }
        }

        private string _item34B;
        public string Item34B
        {
            get { return _item34B; }
            set
            {
                var changed = !object.Equals(_item34B, value);
                if (changed)
                    this.OnPropertyChanging("Item34A");
                this._item34B = value;
                if (changed)
                    MarkChanged("Item34A");
            }
        }

        private string _item34C;
        public string Item34C
        {
            get { return _item34C; }
            set
            {
                var changed = !object.Equals(_item34C, value);
                if (changed)
                    this.OnPropertyChanging("Item34A");
                this._item34C = value;
                if (changed)
                    MarkChanged("Item34A");
            }
        }

        private string _item34D;
        public string Item34D
        {
            get { return _item34D; }
            set
            {
                var changed = !object.Equals(_item34D, value);
                if (changed)
                    this.OnPropertyChanging("Item34D");
                this._item34D = value;
                if (changed)
                    MarkChanged("Item34D");
            }
        }

        private string _item35A;
        public string Item35A
        {
            get { return _item35A; }
            set
            {
                var changed = !object.Equals(_item35A, value);
                if (changed)
                    this.OnPropertyChanging("Item35A");
                this._item35A = value;
                if (changed)
                    MarkChanged("Item35A");
            }
        }

        private string _item35B;
        public string Item35B
        {
            get { return _item35B; }
            set
            {
                var changed = !object.Equals(_item35B, value);
                if (changed)
                    this.OnPropertyChanging("Item35A");
                this._item35B = value;
                if (changed)
                    MarkChanged("Item35A");
            }
        }

        private string _item35C;
        public string Item35C
        {
            get { return _item35C; }
            set
            {
                var changed = !object.Equals(_item35C, value);
                if (changed)
                    this.OnPropertyChanging("Item35A");
                this._item35C = value;
                if (changed)
                    MarkChanged("Item35A");
            }
        }

        private string _item35D;
        public string Item35D
        {
            get { return _item35D; }
            set
            {
                var changed = !object.Equals(_item35D, value);
                if (changed)
                    this.OnPropertyChanging("Item35D");
                this._item35D = value;
                if (changed)
                    MarkChanged("Item35D");
            }
        }

        private string _item36A;
        public string Item36A
        {
            get { return _item36A; }
            set
            {
                var changed = !object.Equals(_item36A, value);
                if (changed)
                    this.OnPropertyChanging("Item36A");
                this._item36A = value;
                if (changed)
                    MarkChanged("Item36A");
            }
        }

        private string _item36B;
        public string Item36B
        {
            get { return _item36B; }
            set
            {
                var changed = !object.Equals(_item36B, value);
                if (changed)
                    this.OnPropertyChanging("Item36A");
                this._item36B = value;
                if (changed)
                    MarkChanged("Item36A");
            }
        }

        private string _item36C;
        public string Item36C
        {
            get { return _item36C; }
            set
            {
                var changed = !object.Equals(_item36C, value);
                if (changed)
                    this.OnPropertyChanging("Item36A");
                this._item36C = value;
                if (changed)
                    MarkChanged("Item36A");
            }
        }

        private string _item36D;
        public string Item36D
        {
            get { return _item36D; }
            set
            {
                var changed = !object.Equals(_item36D, value);
                if (changed)
                    this.OnPropertyChanging("Item36D");
                this._item36D = value;
                if (changed)
                    MarkChanged("Item36D");
            }
        }

        private string _item37A;
        public string Item37A
        {
            get { return _item37A; }
            set
            {
                var changed = !object.Equals(_item37A, value);
                if (changed)
                    this.OnPropertyChanging("Item37A");
                this._item37A = value;
                if (changed)
                    MarkChanged("Item37A");
            }
        }

        private string _item37B;
        public string Item37B
        {
            get { return _item37B; }
            set
            {
                var changed = !object.Equals(_item37B, value);
                if (changed)
                    this.OnPropertyChanging("Item37A");
                this._item37B = value;
                if (changed)
                    MarkChanged("Item37A");
            }
        }

        private string _item37C;
        public string Item37C
        {
            get { return _item37C; }
            set
            {
                var changed = !object.Equals(_item37C, value);
                if (changed)
                    this.OnPropertyChanging("Item37A");
                this._item37C = value;
                if (changed)
                    MarkChanged("Item37A");
            }
        }

        private string _item37D;
        public string Item37D
        {
            get { return _item37D; }
            set
            {
                var changed = !object.Equals(_item37D, value);
                if (changed)
                    this.OnPropertyChanging("Item37D");
                this._item37D = value;
                if (changed)
                    MarkChanged("Item37D");
            }
        }

        private string _item38A;
        public string Item38A
        {
            get { return _item38A; }
            set
            {
                var changed = !object.Equals(_item38A, value);
                if (changed)
                    this.OnPropertyChanging("Item38A");
                this._item38A = value;
                if (changed)
                    MarkChanged("Item38A");
            }
        }

        private string _item38B;
        public string Item38B
        {
            get { return _item38B; }
            set
            {
                var changed = !object.Equals(_item38B, value);
                if (changed)
                    this.OnPropertyChanging("Item38A");
                this._item38B = value;
                if (changed)
                    MarkChanged("Item38A");
            }
        }

        private string _item38C;
        public string Item38C
        {
            get { return _item38C; }
            set
            {
                var changed = !object.Equals(_item38C, value);
                if (changed)
                    this.OnPropertyChanging("Item38A");
                this._item38C = value;
                if (changed)
                    MarkChanged("Item38A");
            }
        }

        private string _item38D;
        public string Item38D
        {
            get { return _item38D; }
            set
            {
                var changed = !object.Equals(_item38D, value);
                if (changed)
                    this.OnPropertyChanging("Item38D");
                this._item38D = value;
                if (changed)
                    MarkChanged("Item38D");
            }
        }

        private string _item55A;
        public string Item55A
        {
            get { return _item55A; }
            set
            {
                var changed = !object.Equals(_item55A, value);
                if (changed)
                    this.OnPropertyChanging("Item55A");
                this._item55A = value;
                if (changed)
                    MarkChanged("Item55A");
            }
        }

        private string _item54A;
        public string Item54A
        {
            get { return _item54A; }
            set
            {
                var changed = !object.Equals(_item54A, value);
                if (changed)
                    this.OnPropertyChanging("Item54A");
                this._item54A = value;
                if (changed)
                    MarkChanged("Item54A");
            }
        }

        private string _item53A;
        public string Item53A
        {
            get { return _item53A; }
            set
            {
                var changed = !object.Equals(_item53A, value);
                if (changed)
                    this.OnPropertyChanging("Item53A");
                this._item53A = value;
                if (changed)
                    MarkChanged("Item53A");
            }
        }

        private string _item52A;
        public string Item52A
        {
            get { return _item52A; }
            set
            {
                var changed = !object.Equals(_item52A, value);
                if (changed)
                    this.OnPropertyChanging("Item52A");
                this._item52A = value;
                if (changed)
                    MarkChanged("Item52A");
            }
        }

        private string _item51A;
        public string Item51A
        {
            get { return _item51A; }
            set
            {
                var changed = !object.Equals(_item51A, value);
                if (changed)
                    this.OnPropertyChanging("Item51A");
                this._item51A = value;
                if (changed)
                    MarkChanged("Item51A");
            }
        }

        private string _item61A;
        public string Item61A
        {
            get { return _item61A; }
            set
            {
                var changed = !object.Equals(_item61A, value);
                if (changed)
                    this.OnPropertyChanging("Item61A");
                this._item61A = value;
                if (changed)
                    MarkChanged("Item61A");
            }
        }

        private string _item62A;
        public string Item62A
        {
            get { return _item62A; }
            set
            {
                var changed = !object.Equals(_item62A, value);
                if (changed)
                    this.OnPropertyChanging("Item62A");
                this._item62A = value;
                if (changed)
                    MarkChanged("Item62A");
            }
        }

        private string _item63A;
        public string Item63A
        {
            get { return _item63A; }
            set
            {
                var changed = !object.Equals(_item63A, value);
                if (changed)
                    this.OnPropertyChanging("Item63A");
                this._item63A = value;
                if (changed)
                    MarkChanged("Item63A");
            }
        }

        private string _item64A;
        public string Item64A
        {
            get { return _item64A; }
            set
            {
                var changed = !object.Equals(_item64A, value);
                if (changed)
                    this.OnPropertyChanging("Item64A");
                this._item64A = value;
                if (changed)
                    MarkChanged("Item64A");
            }
        }

        private string _item65A;
        public string Item65A
        {
            get { return _item65A; }
            set
            {
                var changed = !object.Equals(_item65A, value);
                if (changed)
                    this.OnPropertyChanging("Item65A");
                this._item65A = value;
                if (changed)
                    MarkChanged("Item65A");
            }
        }

        private string _item85A;
        public string Item85A
        {
            get { return _item85A; }
            set
            {
                var changed = !object.Equals(_item85A, value);
                if (changed)
                    this.OnPropertyChanging("Item85A");
                this._item85A = value;
                if (changed)
                    MarkChanged("Item85A");
            }
        }

        private string _item84A;
        public string Item84A
        {
            get { return _item84A; }
            set
            {
                var changed = !object.Equals(_item84A, value);
                if (changed)
                    this.OnPropertyChanging("Item84A");
                this._item84A = value;
                if (changed)
                    MarkChanged("Item84A");
            }
        }

        private string _item83A;
        public string Item83A
        {
            get { return _item83A; }
            set
            {
                var changed = !object.Equals(_item83A, value);
                if (changed)
                    this.OnPropertyChanging("Item83A");
                this._item83A = value;
                if (changed)
                    MarkChanged("Item83A");
            }
        }

        private string _item82A;
        public string Item82A
        {
            get { return _item82A; }
            set
            {
                var changed = !object.Equals(_item82A, value);
                if (changed)
                    this.OnPropertyChanging("Item82A");
                this._item82A = value;
                if (changed)
                    MarkChanged("Item82A");
            }
        }

        private string _item81A;
        public string Item81A
        {
            get { return _item81A; }
            set
            {
                var changed = !object.Equals(_item81A, value);
                if (changed)
                    this.OnPropertyChanging("Item81A");
                this._item81A = value;
                if (changed)
                    MarkChanged("Item81A");
            }
        }

        private string _item71A;
        public string Item71A
        {
            get { return _item71A; }
            set
            {
                var changed = !object.Equals(_item71A, value);
                if (changed)
                    this.OnPropertyChanging("Item71A");
                this._item71A = value;
                if (changed)
                    MarkChanged("Item71A");
            }
        }

        private string _item72A;
        public string Item72A
        {
            get { return _item72A; }
            set
            {
                var changed = !object.Equals(_item72A, value);
                if (changed)
                    this.OnPropertyChanging("Item72A");
                this._item72A = value;
                if (changed)
                    MarkChanged("Item72A");
            }
        }

        private string _item73A;
        public string Item73A
        {
            get { return _item73A; }
            set
            {
                var changed = !object.Equals(_item73A, value);
                if (changed)
                    this.OnPropertyChanging("Item73A");
                this._item73A = value;
                if (changed)
                    MarkChanged("Item73A");
            }
        }

        private string _item74A;
        public string Item74A
        {
            get { return _item74A; }
            set
            {
                var changed = !object.Equals(_item74A, value);
                if (changed)
                    this.OnPropertyChanging("Item74A");
                this._item74A = value;
                if (changed)
                    MarkChanged("Item74A");
            }
        }

        private string _item75A;
        public string Item75A
        {
            get { return _item75A; }
            set
            {
                var changed = !object.Equals(_item75A, value);
                if (changed)
                    this.OnPropertyChanging("Item75A");
                this._item75A = value;
                if (changed)
                    MarkChanged("Item75A");
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
