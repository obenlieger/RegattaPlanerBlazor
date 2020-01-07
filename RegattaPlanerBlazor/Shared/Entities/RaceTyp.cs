using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class RaceTyp
    {
        [Key]
        public int RaceTypId { get; set; }
        [Display(Name = "Renntyp")]
        public string Name { get; set; }
        public bool isFinal { get; set; }
        public List<RaceDrawRules> RaceDrawRules { get; set; }
    }
}
