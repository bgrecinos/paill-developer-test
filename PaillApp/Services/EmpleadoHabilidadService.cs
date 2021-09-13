using AutoMapper;
using PaillApp.Entities;
using PaillApp.Models;
using PaillApp.Repositories.Interfaces;
using PaillApp.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Services
{
    public class EmpleadoHabilidadService: IEmpleadoHabilidadService
    {
        private readonly IEmpleadoHabilidadRepository _empleadoHabilidadRepository;
        private readonly IMapper _mapper;

        public EmpleadoHabilidadService(IEmpleadoHabilidadRepository empleadoHabilidadRepository, IMapper mapper)
        {
            _empleadoHabilidadRepository = empleadoHabilidadRepository;
            _mapper = mapper;
        }

        public async Task InsertEmpleadoHabilidad(EmpleadoHabilidadViewModel model)
        {
            var empleadoHabilidad = _mapper.Map<EmpleadoHabilidad>(model);
            await _empleadoHabilidadRepository.InsertEmpleadoHabilidad(empleadoHabilidad);
        }
        public async Task<List<EmpleadoHabilidadViewModel>> GetEmpleadoHabilidades(int id)
        {
            var result = await _empleadoHabilidadRepository.GetEmpleadoHabilidades();
            var habilidaesEmpleado = result.Where(w => w.IdEmpleado == id).ToList();
            var habilidadesModel = _mapper.Map<List<EmpleadoHabilidadViewModel>>(habilidaesEmpleado);
            return habilidadesModel;
        }
    }
}
