﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class ReportedRace
    {
        [Key]
        public int ReportedRaceId { get; set; }
        public DateTime modifiedDate { get; set; }
        public bool isCreated { get; set; }
        public int StartboatCount { get; set; }
        public bool isAbteilungslauf { get; set; }
        [Display(Name = "Altersklasse")]
        public int OldclassId { get; set; }
        [Display(Name = "Altersklasse")]
        public Oldclass Oldclass { get; set; }
        [Display(Name = "Wettkampf")]
        public int CompetitionId { get; set; }
        [Display(Name = "Geschlecht")]
        public string Gender { get; set; }
        [Display(Name = "Renncode")]
        public string RaceCode { get; set; }
        [Display(Name = "Wettkampf")]
        public Competition Competition { get; set; }
        [Display(Name = "Kommentar")]
        public string Comment { get; set; }
        public int FreeStartslots { get; set; }
        public int RegattaId { get; set; }
        public Regatta Regatta { get; set; }
        public List<ReportedStartboat> ReportedStartboats { get; set; }
    }
}
