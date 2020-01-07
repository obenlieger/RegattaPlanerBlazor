using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class Oldclass
    {
        [Key]
        public int OldclassId { get; set; }
        [Display(Name = "Altersklassenname")]
        public string Name { get; set; }
        [Display(Name = "Von Alter")]
        public int FromAge { get; set; }
        [Display(Name = "Bis Alter")]
        public int ToAge { get; set; }
        public List<Race> Races { get; set; }
        public List<RegattaOldclass> RegattaOldclasses { get; set; }
        public List<ReportedRace> ReportedRaces { get; set; }
    }
}
