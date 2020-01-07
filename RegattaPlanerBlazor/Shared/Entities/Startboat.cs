using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class Startboat
    {
        [Key]
        public int StartboatId { get; set; }
        public int Startslot { get; set; }
        public string Gender { get; set; }
        public int Placement { get; set; }
        public DateTime FinishTime { get; set; }
        public int ClubId { get; set; }
        public int RaceId { get; set; }
        public int StartboatstatusId { get; set; }
        public Club Club { get; set; }
        public Race Race { get; set; }
        public int ReportedStartboatId { get; set; }
        public ReportedStartboat ReportedStartboat { get; set; }
        public Startboatstatus Startboatstatus { get; set; }
        public List<StartboatMember> StartboatMembers { get; set; }
        public List<StartboatStandby> StartboatStandbys { get; set; }
        public int RegattaId { get; set; }
        public Regatta Regatta { get; set; }
    }
}
