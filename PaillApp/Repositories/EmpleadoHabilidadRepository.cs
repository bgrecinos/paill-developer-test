using Microsoft.EntityFrameworkCore;
using PaillApp.Data;
using PaillApp.Entities;
using PaillApp.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Repositories
{
    public class EmpleadoHabilidadRepository : IEmpleadoHabilidadRepository
    {
        private readonly PaillContext _context;

        public EmpleadoHabilidadRepository(PaillContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmpleadoHabilidad>> GetEmpleadoHabilidades() => await _context.EmpleadoHabilidads.ToListAsync();

        public async Task InsertEmpleadoHabilidad(EmpleadoHabilidad empleadoHabilidad)
        {
            _context.EmpleadoHabilidads.Add(empleadoHabilidad);
            await _context.SaveChangesAsync();
        }
    }
}
