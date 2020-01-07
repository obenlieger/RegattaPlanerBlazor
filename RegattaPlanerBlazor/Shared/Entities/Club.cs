using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class Club
    {
        [Key]
        public int ClubId { get; set; }
        [Display(Name = "Vereinsname")]
        public string Name { get; set; }
        [Display(Name = "Stadt")]
        public string City { get; set; }
        [Display(Name = "Vereinsnummer")]
        public string VNr { get; set; }
        [EmailAddress]
        public string EMail { get; set; }
        [Display(Name = "Kurzname")]
        public string ShortName { get; set; }
        public List<Member> Members { get; set; }
        public List<Startboat> Startboats { get; set; }
        public List<Regatta> Regatten { get; set; }
        public List<ReportedStartboat> ReportedStartboats { get; set; }
        public List<RegattaClub> RegattaClubs { get; set; }
        public List<ClubCampingFee> ClubCampingFees { get; set; }
    }
}
