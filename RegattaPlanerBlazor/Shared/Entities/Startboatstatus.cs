using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class Startboatstatus
    {
        [Key]
        public int StartboatstatusId { get; set; }
        public string Name { get; set; }
        public List<Startboat> Startboats { get; set; }
    }
}
