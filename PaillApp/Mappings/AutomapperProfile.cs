using AutoMapper;
using PaillApp.Entities;
using PaillApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<AreaViewModel, Area>();
            CreateMap<Area, AreaViewModel>();
            CreateMap<EmpleadoViewModel, Empleado>();
            CreateMap<Empleado, EmpleadoViewModel>();
            CreateMap<EmpleadoHabilidadViewModel, EmpleadoHabilidad>();
            CreateMap<EmpleadoHabilidad, EmpleadoHabilidadViewModel>();
        }
    }
}
