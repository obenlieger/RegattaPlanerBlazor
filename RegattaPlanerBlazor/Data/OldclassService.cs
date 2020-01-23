using Microsoft.EntityFrameworkCore;
using RegattaPlanerBlazor.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlanerBlazor.Data
{
    public class OldclassService
    {
        private readonly ApplicationDbContext _context;

        public OldclassService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Oldclass>> GetAllOldclasses()
        {
            return await _context.Oldclasses.ToListAsync();
        }

        public async Task<bool> DeleteOldclasses(int oldclassID)
        {
            var oldclassDB = await _context.Oldclasses.FirstOrDefaultAsync(x => x.OldclassId == oldclassID);

            if (oldclassDB == null)
            {
                return false;
            }

            _context.Oldclasses.Remove(oldclassDB);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
