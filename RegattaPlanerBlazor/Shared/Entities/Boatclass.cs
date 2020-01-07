using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class Boatclass
    {
        [Key]
        public int BoatclassId { get; set; }
        [Display(Name = "Bootsklasse")]
        public string Name { get; set; }
        [Display(Name = "Anzahl Sitze")]
        public int Seats { get; set; }
        public List<Race> Races { get; set; }
        public List<Competition> Competitions { get; set; }
    }
}
