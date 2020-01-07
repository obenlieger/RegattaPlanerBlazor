using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class StartingFee
    {
        [Key]
        public int StartingFeeId { get; set; }
        [Display(Name = "Gebühr")]
        public float Amount { get; set; }
        [Display(Name = "Bootsklasse")]
        public int BoatclassId { get; set; }
        [Display(Name = "Bootsklasse")]
        public Boatclass Boatclasses { get; set; }
        [Display(Name = "Von Altersklasse")]
        public int FromOldclassId { get; set; }
        [Display(Name = "Bis Altersklasse")]
        public int ToOldclassId { get; set; }
        [Display(Name = "Altersklasse")]
        public int OldclassId { get; set; }
        public Oldclass Oldclasses { get; set; }
        public string Name
        {
            get
            {
                return string.Format("{0} {1} = {2} EUR", Boatclasses.Name, Oldclasses.Name, Amount);
            }
        }
        public List<RegattaStartingFee> RegattaStartingFees { get; set; }
    }
}
