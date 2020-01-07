using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class RRFreeStartslots
    {
        [Key]
        public int RRFreeStartslotsId { get; set; }
        public int ReportedRaceId { get; set; }
        public int FreeStartslots { get; set; }
    }
}
