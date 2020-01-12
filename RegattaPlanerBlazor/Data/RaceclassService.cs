using Microsoft.EntityFrameworkCore;
using RegattaPlanerBlazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Data
{
    public class RaceclassService
    {
        private readonly ApplicationDbContext _context;

        public RaceclassService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Raceclass>> GetAllRaceclasses()
        {
            return await _context.Raceclasses.ToListAsync();
        }
    }
}
