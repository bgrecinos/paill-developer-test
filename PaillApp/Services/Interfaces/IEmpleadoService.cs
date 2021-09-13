using PaillApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Services.Interfaces
{
    public interface IEmpleadoService
    {
        Task<List<EmpleadoViewModel>> GetEmpleados();
        Task<EmpleadoViewModel> GetEmpleadoById(int id);
        Task UpdateEmpleado(EmpleadoViewModel empleadoModel);
        Task InsertEmpleado(EmpleadoViewModel empleadoModel);
        Task DeleteEmpleado(int id);
    }
}
