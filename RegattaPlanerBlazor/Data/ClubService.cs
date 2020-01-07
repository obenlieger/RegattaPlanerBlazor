using Microsoft.EntityFrameworkCore;
using RegattaPlanerBlazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Data
{
    public class ClubService
    {
        private readonly ApplicationDbContext _context;

        public ClubService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Club>> GetAllClubs()
        {
            return await _context.Clubs.ToListAsync();
        }
    }
}
