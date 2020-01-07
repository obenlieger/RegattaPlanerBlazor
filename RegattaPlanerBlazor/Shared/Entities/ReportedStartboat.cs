﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class ReportedStartboat
    {
        [Key]
        public int ReportedStartboatId { get; set; }
        public string Gender { get; set; }
        public DateTime modifiedDate { get; set; }
        public bool isLate { get; set; }
        public bool NoStartslot { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public int RegattaId { get; set; }
        public Regatta Regatta { get; set; }
        public int ReportedRaceId { get; set; }
        public ReportedRace ReportedRace { get; set; }
        public List<ReportedStartboatMember> ReportedStartboatMembers { get; set; }
        public List<ReportedStartboatStandby> ReportedStartboatStandbys { get; set; }
        public List<Startboat> Startboats { get; set; }
    }
}
