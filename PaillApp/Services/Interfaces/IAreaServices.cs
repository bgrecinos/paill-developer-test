using PaillApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Services.Interfaces
{
    public interface IAreaServices
    {
        Task<List<AreaViewModel>> GetAreas();
        Task InsertArea(AreaViewModel areaModel);
        Task<AreaViewModel> GetAreaById(int id);
        Task UpdatetArea(AreaViewModel areaModel);
        Task DeletetArea(int id);
    }
}
