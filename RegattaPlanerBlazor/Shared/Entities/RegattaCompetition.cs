using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class RegattaCompetition
    {
        public int CompetitionId { get; set; }
        public Competition Competitions { get; set; }
        public int RegattaId { get; set; }
        public Regatta Regattas { get; set; }
    }
}
