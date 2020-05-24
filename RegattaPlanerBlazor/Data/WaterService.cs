using Microsoft.EntityFrameworkCore;
using RegattaPlanerBlazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Data
{
    public class WaterService
    {
        private readonly ApplicationDbContext _context;

        public WaterService(ApplicationDbContext context)
        {
            _context = context;
        }        

        public async Task<List<Water>> GetAllWaters()
        {
            return await _context.Waters.OrderBy(x => x.Name).ToListAsync();
        }
    }
}