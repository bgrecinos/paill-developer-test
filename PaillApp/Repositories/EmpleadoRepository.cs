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
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly PaillContext _context;

        public EmpleadoRepository(PaillContext context)
        {
            _context = context;
        }

        public async Task<Empleado> GetEmpleadoById(int id) => await _context.Empleados.FirstOrDefaultAsync(w => w.IdEmpleado == id);

        public async Task<IEnumerable<Empleado>> GetEmpleados() => await _context.Empleados.ToListAsync();

        public async  Task InsertEmpleado(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateEmpleado(Empleado empleado)
        {
            _context.Empleados.Update(empleado);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteEmpleado(Empleado empleado)
        {
            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();
        }
    }
}
