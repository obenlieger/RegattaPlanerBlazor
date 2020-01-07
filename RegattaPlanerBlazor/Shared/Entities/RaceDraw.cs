using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class RaceDraw
    {
        [Key]
        public int RaceDrawId { get; set; }
        public bool isAbteilungslauf { get; set; }
        [Display(Name = "Von Anzahl Startbooten")]
        public int ReportedSBCountFrom { get; set; }
        [Display(Name = "Bis Anzahl Startbooten")]
        public int ReportedSBCountTo { get; set; }
        [Display(Name = "Anzahl Vorläufe")]
        public int VorlaufCount { get; set; }
        [Display(Name = "Anzahl Hoffnungsläufe")]
        public int HoffnungslaufCount { get; set; }
        [Display(Name = "Anzahl Zwischenläufe")]
        public int ZwischenlaufCount { get; set; }
        [Display(Name = "Anzahl Endläufe")]
        public int EndlaufCount { get; set; }
        [Display(Name = "Streckenlänge")]
        public int RaceLength { get; set; }
        public string Description { get; set; }
        public string Name
        {
            get
            {
                return string.Format("{0} - {1}", ReportedSBCountFrom, ReportedSBCountTo);
            }
        }
        public List<RaceDrawRules> RaceDrawRules { get; set; }
    }
}
