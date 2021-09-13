using Microsoft.EntityFrameworkCore;
using PaillApp.Data;
using PaillApp.Entities;
using PaillApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Repositories
{
    public class AreaRepository : IAreaRepository
    {
        private readonly PaillContext _context;

        public AreaRepository(PaillContext context)
        {
            _context = context;
        }

        public async Task<Area> GetAreaById(int id) => await _context.Areas.FirstOrDefaultAsync(w => w.IdArea == id);

        public async Task<IEnumerable<Area>> GetAreas() => await _context.Areas.ToListAsync();

        public async Task InsertArea(Area area)
        {
            _context.Areas.Add(area);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateArea(Area area)
        {
            _context.Areas.Update(area);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteArea(Area area)
        {
            _context.Areas.Remove(area);
            await _context.SaveChangesAsync();
        }
    }
}
