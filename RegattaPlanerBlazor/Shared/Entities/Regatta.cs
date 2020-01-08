using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class Regatta
    {
        [Key]
        public int RegattaId { get; set; }
        [Display(Name = "Regattaname")]
        public string Name { get; set; }
        public bool Choosen { get; set; }
        [Display(Name = "Von")]
        public DateTime FromDate { get; set; }
        [Display(Name = "Bis")]
        public DateTime ToDate { get; set; }
        [Display(Name = "Wassertiefe")]
        public int Waterdepth { get; set; }
        [Display(Name = "Startbahnen")]
        public int Startslots { get; set; }
        [Display(Name = "Meldung")]
        public string ReportText { get; set; }
        [Display(Name = "Meldeeröffnung")]
        public DateTime ReportOpening { get; set; }
        [Display(Name = "Meldetermin")]
        public DateTime ReportSchedule { get; set; }
        [Display(Name = "Meldeanschrift")]
        public string ReportAddress { get; set; }
        [Display(Name = "Telefon")]
        public string ReportTel { get; set; }
        [Display(Name = "Fax")]
        public string ReportFax { get; set; }
        [Display(Name = "E-Mail")]
        public string ReportMail { get; set; }
        [Display(Name = "Kampfrichter")]
        public string Judge { get; set; }
        [Display(Name = "Auszeichnungen")]
        public string Awards { get; set; }
        [Display(Name = "Sicherheit")]
        public string Security { get; set; }
        [Display(Name = "Zeitplan")]
        public string ScheduleText { get; set; }
        [Display(Name = "Teilnehmergebühren")]
        public float SubscriberFee { get; set; }
        [Display(Name = "Unterkunft")]
        public string Accomodation { get; set; }
        [Display(Name = "Bemerkungen")]
        public string Comment { get; set; }
        [Display(Name = "Verpflegung")]
        public string Catering { get; set; }
        public string Organizer { get; set; }
        public int StartersLastYear { get; set; }
        public string State { get; set; }
        public int ClubId { get; set; }
        [Display(Name = "Verein")]
        public Club Club { get; set; }
        public string Category { get; set; }
        public List<Startboat> Startboats { get; set; }
        public List<Race> Races { get; set; }
        public int WaterId { get; set; }
        public Water Waters { get; set; }
        public List<RegattaCampingFee> RegattaCampingFees { get; set; }
        public List<RegattaStartingFee> RegattaStartingFees { get; set; }
        public List<RegattaOldclass> RegattaOldclasses { get; set; }
        public List<RegattaCompetition> RegattaCompetitions { get; set; }
        public List<ReportedStartboat> ReportedStartboats { get; set; }
        public List<RegattaClub> RegattaClubs { get; set; }
    }
}
