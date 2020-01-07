using Microsoft.EntityFrameworkCore;
using RegattaPlanerBlazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Data
{
    public class RegattaService
    {
        private readonly ApplicationDbContext _context;

        public RegattaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> GetAnyRegatta()
        {
            return await _context.Regattas.AnyAsync();
        }

        public async Task<List<Regatta>> GetAllRegattas()
        {
            return await _context.Regattas.ToListAsync();
        }
    }
}
