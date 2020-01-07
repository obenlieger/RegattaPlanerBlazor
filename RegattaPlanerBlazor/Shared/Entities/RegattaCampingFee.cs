using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class RegattaCampingFee
    {
        public int CampingFeeId { get; set; }
        public CampingFee CampingFees { get; set; }
        public int RegattaId { get; set; }
        public Regatta Regattas { get; set; }
    }
}
