using AutoMapper;
using PaillApp.Entities;
using PaillApp.Models;
using PaillApp.Repositories.Interfaces;
using PaillApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IMapper _mapper;
        public EmpleadoService(IEmpleadoRepository empleadoRepository, IMapper mapper)
        {
            _empleadoRepository = empleadoRepository;
            _mapper = mapper;
        }

        public async Task DeleteEmpleado(int id)
        {
            var empleado = await _empleadoRepository.GetEmpleadoById(id);
            await _empleadoRepository.DeleteEmpleado(empleado);
        }

        public async Task<EmpleadoViewModel> GetEmpleadoById(int id)
        {
            var empleado = await _empleadoRepository.GetEmpleadoById(id);
            var empleadoModel = _mapper.Map<EmpleadoViewModel>(empleado);
            return empleadoModel;
        }

        public async Task<List<EmpleadoViewModel>> GetEmpleados()
        {
            var empleados = await _empleadoRepository.GetEmpleados();
            var empleadosmodel = _mapper.Map<List<EmpleadoViewModel>>(empleados);
            return empleadosmodel;
        }

        public async Task InsertEmpleado(EmpleadoViewModel empleadoModel)
        {
            var empleado = _mapper.Map<Empleado>(empleadoModel);
            await _empleadoRepository.InsertEmpleado(empleado);
        }

        public async Task UpdateEmpleado(EmpleadoViewModel empleadoModel)
        {
            var empleado = _mapper.Map<Empleado>(empleadoModel);
            await _empleadoRepository.UpdateEmpleado(empleado);
        }
    }
}
