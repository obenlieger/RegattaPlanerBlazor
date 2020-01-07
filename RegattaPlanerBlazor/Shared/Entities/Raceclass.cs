using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class Raceclass
    {
        [Key]
        public int RaceclassId { get; set; }
        [Display(Name = "Rennklassenname")]
        public string Name { get; set; }
        [Display(Name = "Streckenlänge")]
        public int Length { get; set; }
        public List<Race> Races { get; set; }
        public List<Competition> Competitions { get; set; }
    }
}
