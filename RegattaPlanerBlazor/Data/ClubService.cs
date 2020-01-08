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

        public async Task<Club> GetClub(int id)
        {
            return await _context.Clubs.FirstOrDefaultAsync(x => x.ClubId == id);
        }

        public async Task<bool> UpdateClub(Club club)
        {
            var clubDB = await _context.Clubs.FirstOrDefaultAsync(x => x.ClubId == club.ClubId);

            if(clubDB == null)
            {
                return false;
            }

            _context.Clubs.Update(club);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<int> CreateClub(Club club)
        {
            _context.Clubs.Add(club);
            await _context.SaveChangesAsync();
            return club.ClubId;
        }

        public async Task<bool> DeleteClub(int clubID)
        {
            var clubDB = await _context.Clubs.FirstOrDefaultAsync(x => x.ClubId == clubID);

            if (clubDB == null)
            {
                return false;
            }

            _context.Clubs.Remove(clubDB);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
