using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class Race
    {
        [Key]
        public int RaceId { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}")]
        public DateTime Starttime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Realstarttime { get; set; }
        public string Gender { get; set; }
        public bool Spoken { get; set; }
        public bool ResultSpoken { get; set; }
        public int Sequence { get; set; }
        public string RaceCode { get; set; }
        public int FinishType { get; set; }
        public string Comment { get; set; }
        public int RegattaId { get; set; }
        public int RaceclassId { get; set; }
        public int OldclassId { get; set; }
        public int BoatclassId { get; set; }
        public int RacestatusId { get; set; }
        public bool isAbteilungslauf { get; set; }
        public int RaceTypId { get; set; }
        public RaceTyp RaceTyp { get; set; }
        public Regatta Regatta { get; set; }
        public Raceclass Raceclass { get; set; }
        public Oldclass Oldclass { get; set; }
        public Boatclass Boatclass { get; set; }
        public Racestatus Racestatus { get; set; }
        public int ReportedRaceId { get; set; }
        public int RaceDrawId { get; set; }
        public List<Startboat> Startboats { get; set; }
    }
}
