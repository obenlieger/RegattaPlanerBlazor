using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class CampingFee
    {
        [Key]
        public int CampingFeeId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Gebühr")]
        public float Amount { get; set; }
        public string LongName
        {
            get
            {
                return string.Format("{0} = {1} EUR", Name, Amount);
            }
        }
        public List<RegattaCampingFee> RegattaCampingFees { get; set; }
        public List<ClubCampingFee> ClubCampingFees { get; set; }
    }
}
