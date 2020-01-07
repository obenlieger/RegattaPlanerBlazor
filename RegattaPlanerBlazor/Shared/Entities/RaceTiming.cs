using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class RaceTiming
    {
        [Key]
        public int RaceTimingId { get; set; }
        public int Order { get; set; }
        public Boatclass Boatclass { get; set; }
        public Raceclass Raceclass { get; set; }
        public Oldclass Oldclass { get; set; }
    }
}
