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

        public async Task<Regatta> GetRegatta(int id)
        {
            return await _context.Regattas.FirstOrDefaultAsync(x => x.RegattaId == id);
        }

        public async Task<int> CreateRegatta(Regatta regatta)
        {
            _context.Regattas.Add(regatta);
            await _context.SaveChangesAsync();
            return regatta.RegattaId;
        }

        public async Task<bool> DeleteRegatta(int regattaId)
        {
            var regattaDB = await _context.Regattas.FirstOrDefaultAsync(x => x.RegattaId == regattaId);

            if (regattaDB == null)
            {
                return false;
            }

            _context.Regattas.Remove(regattaDB);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
