using Microsoft.EntityFrameworkCore;
using RegattaPlanerBlazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Data
{
    public class BoatclassService
    {
        private readonly ApplicationDbContext _context;

        public BoatclassService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Boatclass>> GetAllBoatclasses()
        {
            return await _context.Boatclasses.ToListAsync();
        }
    }
}
