using PaillApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Repositories.Interfaces
{
    public interface IAreaRepository
    {
        Task<IEnumerable<Area>> GetAreas();
        Task<Area> GetAreaById(int id);
        Task InsertArea(Area area);
        Task UpdateArea(Area area);
        Task DeleteArea(Area area);
    }
}
