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
    public class AreaService : IAreaServices
    {
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public AreaService(IAreaRepository areaRepository, IMapper mapper)
        {
            _areaRepository = areaRepository;
            _mapper = mapper;
        }

        public async Task DeletetArea(int id)
        {
            var area = await _areaRepository.GetAreaById(id);
            await _areaRepository.DeleteArea(area);
        }

        public async Task<AreaViewModel> GetAreaById(int id)
        {
            var area = await _areaRepository.GetAreaById(id);
            var aresmodel = _mapper.Map<AreaViewModel>(area);
            return aresmodel;
        }

        public async Task<List<AreaViewModel>> GetAreas()
        {
            var areas = await _areaRepository.GetAreas();
            var areasmodel = _mapper.Map<List<AreaViewModel>>(areas);
            return areasmodel;
        }

        public async Task InsertArea(AreaViewModel areaModel)
        {
            var area = _mapper.Map<Area>(areaModel);
            await _areaRepository.InsertArea(area);
        }

        public async Task UpdatetArea(AreaViewModel areaModel)
        {
            var area = _mapper.Map<Area>(areaModel);
            await _areaRepository.UpdateArea(area);
        }
    }
}
