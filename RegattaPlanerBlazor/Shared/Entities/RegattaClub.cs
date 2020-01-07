﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Shared.Entities
{
    public class RegattaClub
    {
        public string Guid { get; set; }
        public bool Invited { get; set; }
        public string Comment { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public int RegattaId { get; set; }
        public Regatta Regatta { get; set; }
    }
}
