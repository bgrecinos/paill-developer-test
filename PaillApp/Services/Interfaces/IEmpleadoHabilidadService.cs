using PaillApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Services.Interfaces
{
    public interface IEmpleadoHabilidadService
    {
        Task InsertEmpleadoHabilidad(EmpleadoHabilidadViewModel model);
        Task<List<EmpleadoHabilidadViewModel>> GetEmpleadoHabilidades(int id);
    }
}
