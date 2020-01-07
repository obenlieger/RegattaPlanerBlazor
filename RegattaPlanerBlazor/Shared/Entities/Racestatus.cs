using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class Racestatus
    {
        [Key]
        public int RacestatusId { get; set; }
        public string Name { get; set; }
        public List<Race> Races { get; set; }
    }
}
