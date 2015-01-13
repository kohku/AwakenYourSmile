using Rainbow.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwakenYourSmile
{
    public class ClinicalHistory : BusinessBase<ClinicalHistory, Guid>, IEquatable<ClinicalHistory>
    {
        public ClinicalHistory()
            : base(Guid.NewGuid())
        {

        }

        private string _name;
        [Required]
        public string Name
        {
            get { return _name; }
            set
            {
                var changed = !object.Equals(_name, value);
                if (changed)
                    this.OnPropertyChanging("Name");
                this._name = value;
                if (changed)
                    MarkChanged("Name");
            }
        }

        private string _nickName;
        public string NickName
        {
            get { return _nickName; }
            set
            {
                var changed = !object.Equals(_nickName, value);
                if (changed)
                    this.OnPropertyChanging("NickName");
                this._nickName = value;
                if (changed)
                    MarkChanged("NickName");
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                var changed = !object.Equals(_age, value);
                if (changed)
                    this.OnPropertyChanging("Age");
                this._age = value;
                if (changed)
                    MarkChanged("Age");
            }
        }
        
        private Gender? _gender;
        public Gender? Gender
        {
            get { return _gender; }
            set
            {
                var changed = !object.Equals(_gender, value);
                if (changed)
                    this.OnPropertyChanging("Gender");
                this._gender = value;
                if (changed)
                    MarkChanged("Gender");
            }
        }

        private DateTime? _birthDate;
        [DataType(DataType.Date)]
        public DateTime? BirthDate
        {
            get { return _birthDate; }
            set
            {
                var changed = !object.Equals(_birthDate, value);
                if (changed)
                    this.OnPropertyChanging("BirthDate");
                this._birthDate = value;
                if (changed)
                    MarkChanged("BirthDate");
            }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                var changed = !object.Equals(_address, value);
                if (changed)
                    this.OnPropertyChanging("Address");
                this._address = value;
                if (changed)
                    MarkChanged("Address");
            }
        }

        private string _address2;
        public string Address2
        {
            get { return _address2; }
            set
            {
                var changed = !object.Equals(_address2, value);
                if (changed)
                    this.OnPropertyChanging("Address2");
                this._address2 = value;
                if (changed)
                    MarkChanged("Address2");
            }
        }

        private string _cityState;
        public string CityState
        {
            get { return _cityState; }
            set
            {
                var changed = !object.Equals(_cityState, value);
                if (changed)
                    this.OnPropertyChanging("CityState");
                this._cityState = value;
                if (changed)
                    MarkChanged("CityState");
            }
        }

        private string _phoneNumber;
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

        private string _school;
        public string School
        {
            get { return _phoneNumber; }
            set
            {
                var changed = !object.Equals(_school, value);
                if (changed)
                    this.OnPropertyChanging("School");
                this._school = value;
                if (changed)
                    MarkChanged("School");
            }
        }

        private string _fatherName;
        public string FatherName
        {
            get { return _fatherName; }
            set
            {
                var changed = !object.Equals(_fatherName, value);
                if (changed)
                    this.OnPropertyChanging("FatherName");
                this._fatherName = value;
                if (changed)
                    MarkChanged("FatherName");
            }
        }

        private string _fatherPhoneNumber;
        public string FatherPhoneNumber
        {
            get { return _fatherPhoneNumber; }
            set
            {
                var changed = !object.Equals(_fatherPhoneNumber, value);
                if (changed)
                    this.OnPropertyChanging("FatherPhoneNumber");
                this._fatherPhoneNumber = value;
                if (changed)
                    MarkChanged("FatherPhoneNumber");
            }
        }

        private string _fatherOccupation;
        public string FatherOccupation
        {
            get { return _fatherOccupation; }
            set
            {
                var changed = !object.Equals(_fatherOccupation, value);
                if (changed)
                    this.OnPropertyChanging("FatherOccupation");
                this._fatherOccupation = value;
                if (changed)
                    MarkChanged("FatherOccupation");
            }
        }

        private string _fatherEmail;
        public string FatherEmail
        {
            get { return _fatherEmail; }
            set
            {
                var changed = !object.Equals(_fatherEmail, value);
                if (changed)
                    this.OnPropertyChanging("FatherEmail");
                this._fatherEmail = value;
                if (changed)
                    MarkChanged("FatherEmail");
            }
        }

        private string _motherName;
        public string MotherName
        {
            get { return _motherName; }
            set
            {
                var changed = !object.Equals(_motherName, value);
                if (changed)
                    this.OnPropertyChanging("MotherName");
                this._motherName = value;
                if (changed)
                    MarkChanged("MotherName");
            }
        }

        private string _motherPhoneNumber;
        public string MotherPhoneNumber
        {
            get { return _motherPhoneNumber; }
            set
            {
                var changed = !object.Equals(_motherPhoneNumber, value);
                if (changed)
                    this.OnPropertyChanging("MotherPhoneNumber");
                this._motherPhoneNumber = value;
                if (changed)
                    MarkChanged("MotherPhoneNumber");
            }
        }

        private string _motherOccupation;
        public string MotherOccupation
        {
            get { return _motherOccupation; }
            set
            {
                var changed = !object.Equals(_motherOccupation, value);
                if (changed)
                    this.OnPropertyChanging("MotherOccupation");
                this._motherOccupation = value;
                if (changed)
                    MarkChanged("MotherOccupation");
            }
        }

        private string _motherEmail;
        public string MotherEmail
        {
            get { return _motherEmail; }
            set
            {
                var changed = !object.Equals(_motherEmail, value);
                if (changed)
                    this.OnPropertyChanging("MotherEmail");
                this._motherEmail = value;
                if (changed)
                    MarkChanged("MotherEmail");
            }
        }

        private string _reasonForVisit;
        public string ReasonForVisit
        {
            get { return _reasonForVisit; }
            set
            {
                var changed = !object.Equals(_reasonForVisit, value);
                if (changed)
                    this.OnPropertyChanging("ReasonForVisit");
                this._reasonForVisit = value;
                if (changed)
                    MarkChanged("ReasonForVisit");
            }
        }

        private string _reasonOther;
        public string ReasonOther 
        {
            get { return _reasonOther; }
            set
            {
                var changed = !object.Equals(_reasonOther, value);
                if (changed)
                    this.OnPropertyChanging("ReasonOther");
                this._reasonOther = value;
                if (changed)
                    MarkChanged("ReasonOther");
            }
        }

        private string _recommendedBy;
        public string RecommendedBy
        {
            get { return _recommendedBy; }
            set
            {
                var changed = !object.Equals(_recommendedBy, value);
                if (changed)
                    this.OnPropertyChanging("RecommendedBy");
                this._recommendedBy = value;
                if (changed)
                    MarkChanged("RecommendedBy");
            }
        }

        // Region clinical history

        private bool _firstVisit;
        public bool FirstVisit
        {
            get { return _firstVisit; }
            set
            {
                var changed = !object.Equals(_firstVisit, value);
                if (changed)
                    this.OnPropertyChanging("FirstVisit");
                this._firstVisit = value;
                if (changed)
                    MarkChanged("FirstVisit");
            }
        }

        private string _firstVisitReason;
        public string FirstVisitReason
        {
            get { return _firstVisitReason; }
            set
            {
                var changed = !object.Equals(_firstVisitReason, value);
                if (changed)
                    this.OnPropertyChanging("FirstVisitReason");
                this._firstVisitReason = value;
                if (changed)
                    MarkChanged("FirstVisitReason");
            }
        }

        private Grade _previousVisitExperience;
        public Grade PreviousVisitExperience
        {
            get { return _previousVisitExperience; }
            set
            {
                var changed = !object.Equals(_previousVisitExperience, value);
                if (changed)
                    this.OnPropertyChanging("PreviousVisitExperience");
                this._previousVisitExperience = value;
                if (changed)
                    MarkChanged("PreviousVisitExperience");
            }
        }

        private Grade _reactionToPreviousVisits;
        public Grade ReactionToPreviousVisits
        {
            get { return _reactionToPreviousVisits; }
            set
            {
                var changed = !object.Equals(_reactionToPreviousVisits, value);
                if (changed)
                    this.OnPropertyChanging("ReactionToPreviousVisits");
                this._reactionToPreviousVisits = value;
                if (changed)
                    MarkChanged("ReactionToPreviousVisits");
            }
        }

        private Grade _anxietyGrade;
        public Grade AnxietyGrade
        {
            get { return _anxietyGrade; }
            set
            {
                var changed = !object.Equals(_anxietyGrade, value);
                if (changed)
                    this.OnPropertyChanging("AnxietyGrade");
                this._anxietyGrade = value;
                if (changed)
                    MarkChanged("AnxietyGrade");
            }
        }

        private Grade _expectedReactionGrade;
        public Grade ExpectedReactionGrade
        {
            get { return _expectedReactionGrade; }
            set
            {
                var changed = !object.Equals(_expectedReactionGrade, value);
                if (changed)
                    this.OnPropertyChanging("ExpectedReactionGrade");
                this._expectedReactionGrade = value;
                if (changed)
                    MarkChanged("ExpectedReactionGrade");
            }
        }

        private Grade _performanceAtSchool;
        public Grade PerformanceAtSchool
        {
            get { return _performanceAtSchool; }
            set
            {
                var changed = !object.Equals(_performanceAtSchool, value);
                if (changed)
                    this.OnPropertyChanging("PerformanceAtSchool");
                this._performanceAtSchool = value;
                if (changed)
                    MarkChanged("PerformanceAtSchool");
            }
        }

        private string _motivation;
        public string Motivation
        {
            get { return _motivation; }
            set
            {
                var changed = !object.Equals(_motivation, value);
                if (changed)
                    this.OnPropertyChanging("Motivation");
                this._motivation = value;
                if (changed)
                    MarkChanged("Motivation");
            }
        }

        private bool _hasBeenAnesthetized;
        public bool HasBeenAnesthetized
        {
            get { return _hasBeenAnesthetized; }
            set
            {
                var changed = !object.Equals(_hasBeenAnesthetized, value);
                if (changed)
                    this.OnPropertyChanging("HasBeenAnesthetized");
                this._hasBeenAnesthetized = value;
                if (changed)
                    MarkChanged("HasBeenAnesthetized");
            }
        }

        private bool _adverseReactionToAnesthesia;
        public bool AdverseReactionToAnesthesia
        {
            get { return _adverseReactionToAnesthesia; }
            set
            {
                var changed = !object.Equals(_adverseReactionToAnesthesia, value);
                if (changed)
                    this.OnPropertyChanging("AdverseReactionToAnesthesia");
                this._adverseReactionToAnesthesia = value;
                if (changed)
                    MarkChanged("AdverseReactionToAnesthesia");
            }
        }

        private string _reactionToAnesthesia;
        public string ReactionToAnesthesia
        {
            get { return _reactionToAnesthesia; }
            set
            {
                var changed = !object.Equals(_reactionToAnesthesia, value);
                if (changed)
                    this.OnPropertyChanging("ReactionToAnesthesia");
                this._reactionToAnesthesia = value;
                if (changed)
                    MarkChanged("ReactionToAnesthesia");
            }
        }

        private bool _selfCleaningTooth;
        public bool SelfCleaningTooth
        {
            get { return _selfCleaningTooth; }
            set
            {
                var changed = !object.Equals(_selfCleaningTooth, value);
                if (changed)
                    this.OnPropertyChanging("SelfCleaningTooth");
                this._selfCleaningTooth = value;
                if (changed)
                    MarkChanged("SelfCleaningTooth");
            }
        }

        private int _cleaningTimes;
        public int CleaningTimes
        {
            get { return _cleaningTimes; }
            set
            {
                var changed = !object.Equals(_cleaningTimes, value);
                if (changed)
                    this.OnPropertyChanging("CleaningTimes");
                this._cleaningTimes = value;
                if (changed)
                    MarkChanged("CleaningTimes");
            }
        }

        private bool _usedPacifier;
        public bool UsedPacifier
        {
            get { return _usedPacifier; }
            set
            {
                var changed = !object.Equals(_usedPacifier, value);
                if (changed)
                    this.OnPropertyChanging("UsedPacifier");
                this._usedPacifier = value;
                if (changed)
                    MarkChanged("UsedPacifier");
            }
        }

        private bool _usedBabyBottle;
        public bool UsedBabyBottle
        {
            get { return _usedBabyBottle; }
            set
            {
                var changed = !object.Equals(_usedBabyBottle, value);
                if (changed)
                    this.OnPropertyChanging("UsedBabyBottle");
                this._usedBabyBottle = value;
                if (changed)
                    MarkChanged("UsedBabyBottle");
            }
        }

        private bool _thumbsucking;
        public bool Thumbsucking
        {
            get { return _thumbsucking; }
            set
            {
                var changed = !object.Equals(_thumbsucking, value);
                if (changed)
                    this.OnPropertyChanging("Thumbsucking");
                this._thumbsucking = value;
                if (changed)
                    MarkChanged("Thumbsucking");
            }
        }

        private bool _bitingNails;
        public bool BitingNails
        {
            get { return _bitingNails; }
            set
            {
                var changed = !object.Equals(_bitingNails, value);
                if (changed)
                    this.OnPropertyChanging("BitingNails");
                this._bitingNails = value;
                if (changed)
                    MarkChanged("BitingNails");
            }
        }

        private string _habitsDetails;
        public string HabitsDetails
        {
            get { return _habitsDetails; }
            set
            {
                var changed = !object.Equals(_habitsDetails, value);
                if (changed)
                    this.OnPropertyChanging("HabitsDetails");
                this._habitsDetails = value;
                if (changed)
                    MarkChanged("HabitsDetails");
            }
        }

        private bool _breastFed;
        public bool BreastFed
        {
            get { return _breastFed; }
            set
            {
                var changed = !object.Equals(_breastFed, value);
                if (changed)
                    this.OnPropertyChanging("BreastFed");
                this._breastFed = value;
                if (changed)
                    MarkChanged("BreastFed");
            }
        }

        private string _breastFedDetails;
        public string BreastFedDetails
        {
            get { return _breastFedDetails; }
            set
            {
                var changed = !object.Equals(_breastFedDetails, value);
                if (changed)
                    this.OnPropertyChanging("BreastFedDetails");
                this._breastFedDetails = value;
                if (changed)
                    MarkChanged("BreastFedDetails");
            }
        }

        private FeedingType _feedingType;
        public FeedingType FeedingType
        {
            get { return _feedingType; }
            set
            {
                var changed = !object.Equals(_feedingType, value);
                if (changed)
                    this.OnPropertyChanging("FeedingType");
                this._feedingType = value;
                if (changed)
                    MarkChanged("FeedingType");
            }
        }

        private string _immunizationsBox;
        public string ImmunizationsBox
        {
            get { return _immunizationsBox; }
            set
            {
                var changed = !object.Equals(_immunizationsBox, value);
                if (changed)
                    this.OnPropertyChanging("ImmunizationsBox");
                this._immunizationsBox = value;
                if (changed)
                    MarkChanged("ImmunizationsBox");
            }
        }

        private string _room;
        public string Room
        {
            get { return _room; }
            set
            {
                var changed = !object.Equals(_room, value);
                if (changed)
                    this.OnPropertyChanging("Room");
                this._room = value;
                if (changed)
                    MarkChanged("Room");
            }
        }

        // Region Medical history

        private bool _pregnacyBirthProblems;
        public bool PregnacyBirthProblems
        {
            get { return _pregnacyBirthProblems; }
            set
            {
                var changed = !object.Equals(_pregnacyBirthProblems, value);
                if (changed)
                    this.OnPropertyChanging("PregnacyBirthProblems");
                this._pregnacyBirthProblems = value;
                if (changed)
                    MarkChanged("PregnacyBirthProblems");
            }
        }

        private Grade _overallHealth;
        public Grade OverallHealth
        {
            get { return _overallHealth; }
            set
            {
                var changed = !object.Equals(_overallHealth, value);
                if (changed)
                    this.OnPropertyChanging("OverallHealth");
                this._overallHealth = value;
                if (changed)
                    MarkChanged("OverallHealth");
            }
        }

        private bool _allergic;
        public bool Allergic
        {
            get { return _allergic; }
            set
            {
                var changed = !object.Equals(_allergic, value);
                if (changed)
                    this.OnPropertyChanging("Allergic");
                this._allergic = value;
                if (changed)
                    MarkChanged("Allergic");
            }
        }

        private bool _spontaneousBleedingNose;
        public bool SpontaneousBleedingNose
        {
            get { return _spontaneousBleedingNose; }
            set
            {
                var changed = !object.Equals(_spontaneousBleedingNose, value);
                if (changed)
                    this.OnPropertyChanging("SpontaneousBleedingNose");
                this._spontaneousBleedingNose = value;
                if (changed)
                    MarkChanged("SpontaneousBleedingNose");
            }
        }

        private DateTime? _spontaneousBleedingNoseDate;
        public DateTime? SpontaneousBleedingNoseDate
        {
            get { return _spontaneousBleedingNoseDate; }
            set
            {
                var changed = !object.Equals(_spontaneousBleedingNoseDate, value);
                if (changed)
                    this.OnPropertyChanging("SpontaneousBleedingNoseDate");
                this._spontaneousBleedingNoseDate = value;
                if (changed)
                    MarkChanged("SpontaneousBleedingNoseDate");
            }
        }

        private string _spontaneousBleedingNoseReason;
        public string SpontaneousBleedingNoseReason
        {
            get { return _spontaneousBleedingNoseReason; }
            set
            {
                var changed = !object.Equals(_spontaneousBleedingNoseReason, value);
                if (changed)
                    this.OnPropertyChanging("SpontaneousBleedingNoseReason");
                this._spontaneousBleedingNoseReason = value;
                if (changed)
                    MarkChanged("SpontaneousBleedingNoseReason");
            }
        }

        private bool _receivedBloodTransfusions;
        public bool ReceivedBloodTransfusions
        {
            get { return _receivedBloodTransfusions; }
            set
            {
                var changed = !object.Equals(_receivedBloodTransfusions, value);
                if (changed)
                    this.OnPropertyChanging("ReceivedBloodTransfusions");
                this._receivedBloodTransfusions = value;
                if (changed)
                    MarkChanged("ReceivedBloodTransfusions");
            }
        }

        private DateTime? _bloodTransfusionsDate;
        public DateTime? BloodTransfusionsDate
        {
            get { return _bloodTransfusionsDate; }
            set
            {
                var changed = !object.Equals(_bloodTransfusionsDate, value);
                if (changed)
                    this.OnPropertyChanging("BloodTransfusionsDate");
                this._bloodTransfusionsDate = value;
                if (changed)
                    MarkChanged("BloodTransfusionsDate");
            }
        }

        private string _bloodTransfusionsReason;
        public string BloodTransfusionsReason
        {
            get { return _bloodTransfusionsReason; }
            set
            {
                var changed = !object.Equals(_bloodTransfusionsReason, value);
                if (changed)
                    this.OnPropertyChanging("BloodTransfusionsReason");
                this._bloodTransfusionsReason = value;
                if (changed)
                    MarkChanged("BloodTransfusionsReason");
            }
        }

        private bool _hospitalized;
        public bool Hospitalized
        {
            get { return _hospitalized; }
            set
            {
                var changed = !object.Equals(_hospitalized, value);
                if (changed)
                    this.OnPropertyChanging("Hospitalized");
                this._hospitalized = value;
                if (changed)
                    MarkChanged("Hospitalized");
            }
        }

        private bool _hospitalizedDate;
        public bool HospitalizedDate
        {
            get { return _hospitalizedDate; }
            set
            {
                var changed = !object.Equals(_hospitalizedDate, value);
                if (changed)
                    this.OnPropertyChanging("HospitalizedDate");
                this._hospitalizedDate = value;
                if (changed)
                    MarkChanged("HospitalizedDate");
            }
        }

        private bool _hospitalizedReason;
        public bool HospitalizedReason
        {
            get { return _hospitalizedReason; }
            set
            {
                var changed = !object.Equals(_hospitalizedReason, value);
                if (changed)
                    this.OnPropertyChanging("HospitalizedReason");
                this._hospitalizedReason = value;
                if (changed)
                    MarkChanged("HospitalizedReason");
            }
        }

        private bool _medicated;
        public bool Medicated
        {
            get { return _medicated; }
            set
            {
                var changed = !object.Equals(_medicated, value);
                if (changed)
                    this.OnPropertyChanging("Medicated");
                this._medicated = value;
                if (changed)
                    MarkChanged("Medicated");
            }
        }

        private bool _medicatedDate;
        public bool MedicatedDate
        {
            get { return _medicatedDate; }
            set
            {
                var changed = !object.Equals(_medicatedDate, value);
                if (changed)
                    this.OnPropertyChanging("MedicatedDate");
                this._medicatedDate = value;
                if (changed)
                    MarkChanged("MedicatedDate");
            }
        }

        private bool _medicatedReason;
        public bool MedicatedReason
        {
            get { return _medicatedReason; }
            set
            {
                var changed = !object.Equals(_medicatedReason, value);
                if (changed)
                    this.OnPropertyChanging("MedicatedReason");
                this._medicatedReason = value;
                if (changed)
                    MarkChanged("MedicatedReason");
            }
        }

        private bool _prescribed;
        public bool Prescribed
        {
            get { return _prescribed; }
            set
            {
                var changed = !object.Equals(_prescribed, value);
                if (changed)
                    this.OnPropertyChanging("Prescribed");
                this._prescribed = value;
                if (changed)
                    MarkChanged("Prescribed");
            }
        }

        private bool _prescribedDate;
        public bool PrescribedDate
        {
            get { return _prescribedDate; }
            set
            {
                var changed = !object.Equals(_prescribedDate, value);
                if (changed)
                    this.OnPropertyChanging("PrescribedDate");
                this._prescribedDate = value;
                if (changed)
                    MarkChanged("PrescribedDate");
            }
        }

        private bool _prescribedReason;
        public bool PrescribedReason
        {
            get { return _prescribedReason; }
            set
            {
                var changed = !object.Equals(_prescribedReason, value);
                if (changed)
                    this.OnPropertyChanging("PrescribedReason");
                this._prescribedReason = value;
                if (changed)
                    MarkChanged("PrescribedReason");
            }
        }

        private bool _measles;
        public bool Measles
        {
            get { return _measles; }
            set
            {
                var changed = !object.Equals(_measles, value);
                if (changed)
                    this.OnPropertyChanging("Measles");
                this._measles = value;
                if (changed)
                    MarkChanged("Measles");
            }
        }

        private bool _asthma;
        public bool Asthma
        {
            get { return _asthma; }
            set
            {
                var changed = !object.Equals(_asthma, value);
                if (changed)
                    this.OnPropertyChanging("Asthma");
                this._asthma = value;
                if (changed)
                    MarkChanged("Asthma");
            }
        }

        private bool _renalDisease;
        public bool RenalDisease
        {
            get { return _renalDisease; }
            set
            {
                var changed = !object.Equals(_renalDisease, value);
                if (changed)
                    this.OnPropertyChanging("RenalDisease");
                this._renalDisease = value;
                if (changed)
                    MarkChanged("RenalDisease");
            }
        }

        private bool _heartDisease;
        public bool HeartDisease
        {
            get { return _heartDisease; }
            set
            {
                var changed = !object.Equals(_heartDisease, value);
                if (changed)
                    this.OnPropertyChanging("HeartDisease");
                this._heartDisease = value;
                if (changed)
                    MarkChanged("HeartDisease");
            }
        }

        private bool _chickenPox;
        public bool ChickenPox
        {
            get { return _chickenPox; }
            set
            {
                var changed = !object.Equals(_chickenPox, value);
                if (changed)
                    this.OnPropertyChanging("ChickenPox");
                this._chickenPox = value;
                if (changed)
                    MarkChanged("ChickenPox");
            }
        }

        private bool _leukemia;
        public bool Leukemia
        {
            get { return _leukemia; }
            set
            {
                var changed = !object.Equals(_leukemia, value);
                if (changed)
                    this.OnPropertyChanging("Leukemia");
                this._leukemia = value;
                if (changed)
                    MarkChanged("Leukemia");
            }
        }

        private bool _anemia;
        public bool Anemia
        {
            get { return _anemia; }
            set
            {
                var changed = !object.Equals(_anemia, value);
                if (changed)
                    this.OnPropertyChanging("Anemia");
                this._anemia = value;
                if (changed)
                    MarkChanged("Anemia");
            }
        }

        private bool _diabetes;
        public bool Diabetes
        {
            get { return _diabetes; }
            set
            {
                var changed = !object.Equals(_diabetes, value);
                if (changed)
                    this.OnPropertyChanging("Diabetes");
                this._diabetes = value;
                if (changed)
                    MarkChanged("Diabetes");
            }
        }
        private bool _hepatitis;
        public bool Hepatitis
        {
            get { return _hepatitis; }
            set
            {
                var changed = !object.Equals(_hepatitis, value);
                if (changed)
                    this.OnPropertyChanging("Hepatitis");
                this._hepatitis = value;
                if (changed)
                    MarkChanged("Hepatitis");
            }
        }

        private bool _hemophilia;
        public bool Hemophilia
        {
            get { return _hemophilia; }
            set
            {
                var changed = !object.Equals(_hemophilia, value);
                if (changed)
                    this.OnPropertyChanging("Hemophilia");
                this._hemophilia = value;
                if (changed)
                    MarkChanged("Hemophilia");
            }
        }

        private bool _hiv;
        public bool Hiv
        {
            get { return _hiv; }
            set
            {
                var changed = !object.Equals(_hiv, value);
                if (changed)
                    this.OnPropertyChanging("Hiv");
                this._hiv = value;
                if (changed)
                    MarkChanged("Hiv");
            }
        }

        private bool _epilepsy;
        public bool Epilepsy
        {
            get { return _epilepsy; }
            set
            {
                var changed = !object.Equals(_epilepsy, value);
                if (changed)
                    this.OnPropertyChanging("Epilepsy");
                this._epilepsy = value;
                if (changed)
                    MarkChanged("Epilepsy");
            }
        }

        private string _hereditaries;
        public string Hereditaries
        {
            get { return _hereditaries; }
            set
            {
                var changed = !object.Equals(_hereditaries, value);
                if (changed)
                    this.OnPropertyChanging("Hereditaries");
                this._hereditaries = value;
                if (changed)
                    MarkChanged("Hereditaries");
            }
        }

        private string _intraoralExaminationBraces;
        public string IntraoralExaminationBraces
        {
            get { return _intraoralExaminationBraces; }
            set
            {
                var changed = !object.Equals(_intraoralExaminationBraces, value);
                if (changed)
                    this.OnPropertyChanging("IntraoralExaminationBraces");
                this._intraoralExaminationBraces = value;
                if (changed)
                    MarkChanged("IntraoralExaminationBraces");
            }
        }

        private string _intraoralExaminationTonsils;
        public string IntraoralExaminationTonsils
        {
            get { return _intraoralExaminationTonsils; }
            set
            {
                var changed = !object.Equals(_intraoralExaminationTonsils, value);
                if (changed)
                    this.OnPropertyChanging("IntraoralExaminationTonsils");
                this._intraoralExaminationTonsils = value;
                if (changed)
                    MarkChanged("IntraoralExaminationTonsils");
            }
        }

        private string _intraoralExaminationHardPalate;
        public string IntraoralExaminationHardPalate
        {
            get { return _intraoralExaminationHardPalate; }
            set
            {
                var changed = !object.Equals(_intraoralExaminationHardPalate, value);
                if (changed)
                    this.OnPropertyChanging("IntraoralExaminationHardPalate");
                this._intraoralExaminationHardPalate = value;
                if (changed)
                    MarkChanged("IntraoralExaminationHardPalate");
            }
        }

        private string _intraoralExaminationSoftPalate;
        public string IntraoralExaminationSoftPalate
        {
            get { return _intraoralExaminationSoftPalate; }
            set
            {
                var changed = !object.Equals(_intraoralExaminationSoftPalate, value);
                if (changed)
                    this.OnPropertyChanging("IntraoralExaminationSoftPalate");
                this._intraoralExaminationSoftPalate = value;
                if (changed)
                    MarkChanged("IntraoralExaminationSoftPalate");
            }
        }

        private string _rightTerminalPlane;
        public string RightTerminalPlane
        {
            get { return _rightTerminalPlane; }
            set
            {
                var changed = !object.Equals(_rightTerminalPlane, value);
                if (changed)
                    this.OnPropertyChanging("RightTerminalPlane");
                this._rightTerminalPlane = value;
                if (changed)
                    MarkChanged("RightTerminalPlane");
            }
        }

        private string _leftTerminalPlane;
        public string LeftTerminalPlane
        {
            get { return _leftTerminalPlane; }
            set
            {
                var changed = !object.Equals(_leftTerminalPlane, value);
                if (changed)
                    this.OnPropertyChanging("LeftTerminalPlane");
                this._leftTerminalPlane = value;
                if (changed)
                    MarkChanged("LeftTerminalPlane");
            }
        }

        private string _rightMolarClass;
        public string RightMolarClass
        {
            get { return _rightMolarClass; }
            set
            {
                var changed = !object.Equals(_rightMolarClass, value);
                if (changed)
                    this.OnPropertyChanging("RightMolarClass");
                this._rightMolarClass = value;
                if (changed)
                    MarkChanged("RightMolarClass");
            }
        }

        private string _leftMolarClass;
        public string LeftMolarClass
        {
            get { return _leftMolarClass; }
            set
            {
                var changed = !object.Equals(_leftMolarClass, value);
                if (changed)
                    this.OnPropertyChanging("LeftMolarClass");
                this._leftMolarClass = value;
                if (changed)
                    MarkChanged("LeftMolarClass");
            }
        }

        private string _rightCanineClass;
        public string RightCanineClass
        {
            get { return _rightCanineClass; }
            set
            {
                var changed = !object.Equals(_rightCanineClass, value);
                if (changed)
                    this.OnPropertyChanging("RightCanineClass");
                this._rightCanineClass = value;
                if (changed)
                    MarkChanged("RightCanineClass");
            }
        }

        private string _leftCanineClass;
        public string LeftCanineClass
        {
            get { return _leftCanineClass; }
            set
            {
                var changed = !object.Equals(_leftCanineClass, value);
                if (changed)
                    this.OnPropertyChanging("LeftCanineClass");
                this._leftCanineClass = value;
                if (changed)
                    MarkChanged("LeftCanineClass");
            }
        }

        private string _overbite;
        public string Overbite
        {
            get { return _overbite; }
            set
            {
                var changed = !object.Equals(_overbite, value);
                if (changed)
                    this.OnPropertyChanging("_overbite");
                this._overbite = value;
                if (changed)
                    MarkChanged("_overbite");
            }
        }

        private string _overjet;
        public string Overjet
        {
            get { return _overjet; }
            set
            {
                var changed = !object.Equals(_overjet, value);
                if (changed)
                    this.OnPropertyChanging("Overjet");
                this._overjet = value;
                if (changed)
                    MarkChanged("Overjet");
            }
        }

        private string _upperArchShape;
        public string UpperArchShape
        {
            get { return _upperArchShape; }
            set
            {
                var changed = !object.Equals(_upperArchShape, value);
                if (changed)
                    this.OnPropertyChanging("UpperArchShape");
                this._upperArchShape = value;
                if (changed)
                    MarkChanged("UpperArchShape");
            }
        }

        private string _innerArchShape;
        public string InnerArchShape
        {
            get { return _innerArchShape; }
            set
            {
                var changed = !object.Equals(_innerArchShape, value);
                if (changed)
                    this.OnPropertyChanging("InnerArchShape");
                this._innerArchShape = value;
                if (changed)
                    MarkChanged("InnerArchShape");
            }
        }

        private string _habits;
        public string Habits
        {
            get { return _habits; }
            set
            {
                var changed = !object.Equals(_habits, value);
                if (changed)
                    this.OnPropertyChanging("Habits");
                this._habits = value;
                if (changed)
                    MarkChanged("Habits");
            }
        }

        private bool _fingerSucking;
        public bool FingerSucking
        {
            get { return _fingerSucking; }
            set
            {
                var changed = !object.Equals(_fingerSucking, value);
                if (changed)
                    this.OnPropertyChanging("FingerSucking");
                this._fingerSucking = value;
                if (changed)
                    MarkChanged("FingerSucking");
            }
        }

        private string _fingerSuckingFrequency;
        public string FingerSuckingFrequency
        {
            get { return _fingerSuckingFrequency; }
            set
            {
                var changed = !object.Equals(_fingerSuckingFrequency, value);
                if (changed)
                    this.OnPropertyChanging("FingerSuckingFrequency");
                this._fingerSuckingFrequency = value;
                if (changed)
                    MarkChanged("FingerSuckingFrequency");
            }
        }

        private string _fingerSuckingIntensity;
        public string FingerSuckingIntensity
        {
            get { return _fingerSuckingIntensity; }
            set
            {
                var changed = !object.Equals(_fingerSuckingIntensity, value);
                if (changed)
                    this.OnPropertyChanging("FingerSuckingIntensity");
                this._fingerSuckingIntensity = value;
                if (changed)
                    MarkChanged("FingerSuckingIntensity");
            }
        }

        private string _fingerSuckingTime;
        public string FingerSuckingTime
        {
            get { return _fingerSuckingTime; }
            set
            {
                var changed = !object.Equals(_fingerSuckingTime, value);
                if (changed)
                    this.OnPropertyChanging("FingerSuckingTime");
                this._fingerSuckingTime = value;
                if (changed)
                    MarkChanged("FingerSuckingTime");
            }
        }

        private bool _atypicalSwallowing;
        public bool AtypicalSwallowing
        {
            get { return _atypicalSwallowing; }
            set
            {
                var changed = !object.Equals(_atypicalSwallowing, value);
                if (changed)
                    this.OnPropertyChanging("AtypicalSwallowing");
                this._atypicalSwallowing = value;
                if (changed)
                    MarkChanged("AtypicalSwallowing");
            }
        }

        private string _atypicalSwallowingFrequency;
        public string AtypicalSwallowingFrequency
        {
            get { return _atypicalSwallowingFrequency; }
            set
            {
                var changed = !object.Equals(_atypicalSwallowingFrequency, value);
                if (changed)
                    this.OnPropertyChanging("AtypicalSwallowingFrequency");
                this._atypicalSwallowingFrequency = value;
                if (changed)
                    MarkChanged("AtypicalSwallowingFrequency");
            }
        }

        private string _atypicalSwallowingIntensity;
        public string AtypicalSwallowingIntensity
        {
            get { return _atypicalSwallowingIntensity; }
            set
            {
                var changed = !object.Equals(_atypicalSwallowingIntensity, value);
                if (changed)
                    this.OnPropertyChanging("AtypicalSwallowingIntensity");
                this._atypicalSwallowingIntensity = value;
                if (changed)
                    MarkChanged("AtypicalSwallowingIntensity");
            }
        }

        private string _atypicalSwallowingTime;
        public string AtypicalSwallowingTime
        {
            get { return _atypicalSwallowingTime; }
            set
            {
                var changed = !object.Equals(_atypicalSwallowingTime, value);
                if (changed)
                    this.OnPropertyChanging("AtypicalSwallowingTime");
                this._atypicalSwallowingTime = value;
                if (changed)
                    MarkChanged("AtypicalSwallowingTime");
            }
        }

        private bool _bruxism;
        public bool Bruxism
        {
            get { return _bruxism; }
            set
            {
                var changed = !object.Equals(_bruxism, value);
                if (changed)
                    this.OnPropertyChanging("Bruxism");
                this._bruxism = value;
                if (changed)
                    MarkChanged("Bruxism");
            }
        }

        private string _bruxismFrequency;
        public string BruxismFrequency
        {
            get { return _bruxismFrequency; }
            set
            {
                var changed = !object.Equals(_bruxismFrequency, value);
                if (changed)
                    this.OnPropertyChanging("BruxismFrequency");
                this._bruxismFrequency = value;
                if (changed)
                    MarkChanged("BruxismFrequency");
            }
        }

        private string _bruxismIntensity;
        public string BruxismIntensity
        {
            get { return _bruxismIntensity; }
            set
            {
                var changed = !object.Equals(_bruxismIntensity, value);
                if (changed)
                    this.OnPropertyChanging("BruxismIntensity");
                this._bruxismIntensity = value;
                if (changed)
                    MarkChanged("BruxismIntensity");
            }
        }

        private string _bruxismTime;
        public string BruxismTime
        {
            get { return _bruxismTime; }
            set
            {
                var changed = !object.Equals(_bruxismTime, value);
                if (changed)
                    this.OnPropertyChanging("BruxismTime");
                this._bruxismTime = value;
                if (changed)
                    MarkChanged("BruxismTime");
            }
        }

        private bool _oralBreathing;
        public bool OralBreathing
        {
            get { return _oralBreathing; }
            set
            {
                var changed = !object.Equals(_oralBreathing, value);
                if (changed)
                    this.OnPropertyChanging("OralBreathing");
                this._oralBreathing = value;
                if (changed)
                    MarkChanged("OralBreathing");
            }
        }

        private string _oralBreathingFrequency;
        public string OralBreathingFrequency
        {
            get { return _oralBreathingFrequency; }
            set
            {
                var changed = !object.Equals(_oralBreathingFrequency, value);
                if (changed)
                    this.OnPropertyChanging("OralBreathingFrequency");
                this._oralBreathingFrequency = value;
                if (changed)
                    MarkChanged("OralBreathingFrequency");
            }
        }

        private string _oralBreathingIntensity;
        public string OralBreathingIntensity
        {
            get { return _oralBreathingIntensity; }
            set
            {
                var changed = !object.Equals(_oralBreathingIntensity, value);
                if (changed)
                    this.OnPropertyChanging("OralBreathingIntensity");
                this._oralBreathingIntensity = value;
                if (changed)
                    MarkChanged("OralBreathingIntensity");
            }
        }

        private string _oralBreathingTime;
        public string OralBreathingTime
        {
            get { return _oralBreathingTime; }
            set
            {
                var changed = !object.Equals(_oralBreathingTime, value);
                if (changed)
                    this.OnPropertyChanging("OralBreathingTime");
                this._oralBreathingTime = value;
                if (changed)
                    MarkChanged("OralBreathingTime");
            }
        }

        private bool _onychophagia;
        public bool Onychophagia
        {
            get { return _onychophagia; }
            set
            {
                var changed = !object.Equals(_onychophagia, value);
                if (changed)
                    this.OnPropertyChanging("Onychophagia");
                this._onychophagia = value;
                if (changed)
                    MarkChanged("Onychophagia");
            }
        }

        private string _onychophagiaFrequency;
        public string OnychophagiaFrequency
        {
            get { return _onychophagiaFrequency; }
            set
            {
                var changed = !object.Equals(_onychophagiaFrequency, value);
                if (changed)
                    this.OnPropertyChanging("OnychophagiaFrequency");
                this._onychophagiaFrequency = value;
                if (changed)
                    MarkChanged("OnychophagiaFrequency");
            }
        }

        private string _onychophagiaIntensity;
        public string OnychophagiaIntensity
        {
            get { return _onychophagiaIntensity; }
            set
            {
                var changed = !object.Equals(_onychophagiaIntensity, value);
                if (changed)
                    this.OnPropertyChanging("OnychophagiaIntensity");
                this._onychophagiaIntensity = value;
                if (changed)
                    MarkChanged("OnychophagiaIntensity");
            }
        }

        private string _onychophagiaTime;
        public string OnychophagiaTime
        {
            get { return _onychophagiaTime; }
            set
            {
                var changed = !object.Equals(_onychophagiaTime, value);
                if (changed)
                    this.OnPropertyChanging("OnychophagiaTime");
                this._onychophagiaTime = value;
                if (changed)
                    MarkChanged("OnychophagiaTime");
            }
        }

        private string _dentalAnomalies;
        public string DentalAnomalies
        {
            get { return _dentalAnomalies; }
            set
            {
                var changed = !object.Equals(_dentalAnomalies, value);
                if (changed)
                    this.OnPropertyChanging("DentalAnomalies");
                this._dentalAnomalies = value;
                if (changed)
                    MarkChanged("DentalAnomalies");
            }
        }

        private string _radiographicFindings;
        public string RadiographicFindings
        {
            get { return _radiographicFindings; }
            set
            {
                var changed = !object.Equals(_radiographicFindings, value);
                if (changed)
                    this.OnPropertyChanging("RadiographicFindings");
                this._radiographicFindings = value;
                if (changed)
                    MarkChanged("RadiographicFindings");
            }
        }

        private string _diagnosticImpressionCurrentCondition;
        public string DiagnosticImpressionCurrentCondition
        {
            get { return _diagnosticImpressionCurrentCondition; }
            set
            {
                var changed = !object.Equals(_diagnosticImpressionCurrentCondition, value);
                if (changed)
                    this.OnPropertyChanging("DiagnosticImpressionCurrentCondition");
                this._diagnosticImpressionCurrentCondition = value;
                if (changed)
                    MarkChanged("DiagnosticImpressionCurrentCondition");
            }
        }

        private CooperationGrade _patientCooperationDuringScan;
        public CooperationGrade PatientCooperationDuringScan
        {
            get { return _patientCooperationDuringScan; }
            set
            {
                var changed = !object.Equals(_patientCooperationDuringScan, value);
                if (changed)
                    this.OnPropertyChanging("PatientCooperationDuringScan");
                this._patientCooperationDuringScan = value;
                if (changed)
                    MarkChanged("PatientCooperationDuringScan");
            }
        }

        protected override void ValidationRules()
        {
            AddRule("EmptyCreatedBy","CreatedBy must be set.", 
                string.IsNullOrEmpty(this.CreatedBy));
            AddRule("MaxCreatedByLength", "CreatedBy cannot exceed 256 chars.", 
                !string.IsNullOrEmpty(this.CreatedBy) && this.CreatedBy.Length > 256);
            AddRule("EmptyLastUpdatedBy", "LastUpdatedBy must be set.", 
                !IsNew && IsChanged && string.IsNullOrEmpty(this.LastUpdatedBy));
            AddRule("MaxLastUpdatedByLength", "LastUpdatedBy cannot exceed 256 chars.", 
                !IsNew && IsChanged && !string.IsNullOrEmpty(this.LastUpdatedBy) && this.LastUpdatedBy.Length > 256);
        }

        protected override ClinicalHistory DataSelect(Guid id)
        {
            return ClinicalHistory.GetClinicalHistories(id, null, null, null).FirstOrDefault();
        }

        protected override void DataUpdate()
        {
            ClinicalHistory.UpdateClinicalHistory(this);
        }

        protected override void DataInsert()
        {
            ClinicalHistory.InsertClinicalHistory(this);
        }

        protected override void DataDelete()
        {
            ClinicalHistory.DeleteClinicalHistory(this);
        }

        public bool Equals(ClinicalHistory other)
        {
            if (other == null)
                return false;

            return this.ID == other.ID;
        }

        internal static void UpdateClinicalHistory(ClinicalHistory entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            using (var db = new DentalContext("DentalContextDb"))
            {
                db.ClinicalHistories.Attach(entity);

                var entry = db.Entry(entity);
                entry.State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        internal static void InsertClinicalHistory(ClinicalHistory entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            using (var db = new DentalContext("DentalContextDb"))
            {
                db.ClinicalHistories.Add(entity);

                db.SaveChanges();
            }
        }

        internal static void DeleteClinicalHistory(ClinicalHistory entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            using (var db = new DentalContext("DentalContextDb"))
            {
                var item = db.ClinicalHistories.Find(entity.ID);

                if (item == null)
                    return;

                db.ClinicalHistories.Remove(item);

                db.SaveChanges();
            }
        }

        public static List<ClinicalHistory> GetClinicalHistories(Guid? id, string name, string nickname, DateTime? birthDate)
        {
            List<ClinicalHistory> entities = new List<ClinicalHistory>();

            using (var db = new DentalContext("DentalContextDb"))
            {
                var query = from c in db.ClinicalHistories
                            where !id.HasValue || c.ID == id.Value
                            where string.IsNullOrEmpty(name) || c.Name.ToLower().Contains(name.ToLower())
                            where string.IsNullOrEmpty(nickname) || c.NickName == nickname
                            where !birthDate.HasValue || c.BirthDate.Value == birthDate.Value
                            select c;

                entities.AddRange(query);
            }

            return entities;
        }
    }
}
