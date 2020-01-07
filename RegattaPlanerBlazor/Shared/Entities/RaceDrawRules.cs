using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class RaceDrawRules
    {
        [Key]
        [Display(Name = "Auslosungsregel")]
        public int RaceDrawRuleId { get; set; }
        [Display(Name = "Auslosung")]
        public int RaceDrawId { get; set; }
        [Display(Name = "Auslosung")]
        public RaceDraw RaceDraw { get; set; }
        [Display(Name = "Renntyp")]
        public int RaceTypId { get; set; }
        [Display(Name = "Renntyp")]
        public RaceTyp RaceTyp { get; set; }
        [Display(Name = "Lauf")]
        public int RaceSequence { get; set; }
        [Display(Name = "Von Platz")]
        public int PlacementFrom { get; set; }
        [Display(Name = "Bis Platz")]
        public int PlacementTo { get; set; }
        [Display(Name = "In Renntyp")]
        public int ToRaceTypId { get; set; }
        [Display(Name = "In Lauf")]
        public int ToRaceSequence { get; set; }
    }
}
