using PaillApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Repositories.Interfaces
{
    public interface IEmpleadoHabilidadRepository
    {
        Task InsertEmpleadoHabilidad(EmpleadoHabilidad empleadoHabilidad);
        Task<IEnumerable<EmpleadoHabilidad>> GetEmpleadoHabilidades();
    }
}
