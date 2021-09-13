using PaillApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PaillApp.Repositories.Interfaces
{
    public interface IEmpleadoRepository
    {
        Task<IEnumerable<Empleado>> GetEmpleados();
        Task<Empleado> GetEmpleadoById(int id);
        Task InsertEmpleado(Empleado empleado);
        Task UpdateEmpleado(Empleado empleado);
        Task DeleteEmpleado(Empleado empleado);
    }
}
