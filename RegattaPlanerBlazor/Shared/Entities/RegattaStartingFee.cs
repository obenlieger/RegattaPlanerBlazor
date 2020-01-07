using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class RegattaStartingFee
    {
        public int StartingFeeId { get; set; }
        public StartingFee StartingFees { get; set; }
        public int RegattaId { get; set; }
        public Regatta Regattas { get; set; }
    }
}
