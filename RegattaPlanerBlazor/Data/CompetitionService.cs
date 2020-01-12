using Microsoft.EntityFrameworkCore;
using RegattaPlanerBlazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Data
{
    public class CompetitionService
    {
        private readonly ApplicationDbContext _context;

        public CompetitionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Competition>> GetAllCompetitions()
        {
            return await _context.Competitions.Include(x => x.Boatclasses).Include(x => x.Raceclasses).ToListAsync();
        }
        public async Task<bool> DeleteCompetition(int competitionID)
        {
            var competitionDB = await _context.Competitions.FirstOrDefaultAsync(x => x.CompetitionId == competitionID);

            if (competitionDB == null)
            {
                return false;
            }

            _context.Competitions.Remove(competitionDB);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<int> CreateCompetition(Competition competition)
        {
            _context.Competitions.Add(competition);
            await _context.SaveChangesAsync();
            return competition.CompetitionId;
        }
    }
}
