using Microsoft.AspNetCore.Mvc;
using PaillApp.Models;
using PaillApp.Services.Interfaces;
using System.Threading.Tasks;

namespace PaillApp.Controllers
{
    public class AreaController : Controller
    {
        private readonly IAreaServices _areaServices;

        public AreaController(IAreaServices areaServices)
        {
            _areaServices = areaServices;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _areaServices.GetAreas();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AreaViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _areaServices.InsertArea(model);

            TempData["succes"] = "El Área se ha creado correctamente";
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            int codigo = id.GetValueOrDefault();

            var model = await _areaServices.GetAreaById(codigo);

            if (model == null)
            {
                TempData["warning"] = "Lo sentimos pero algo salio mal con el Área seleccionada";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(AreaViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);


            await _areaServices.UpdatetArea(model);

            TempData["succes"] = "El Área se ha actualizado correctamente";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            int codigo = id.GetValueOrDefault();

            var model = await _areaServices.GetAreaById(codigo);

            if (model == null)
            {
                TempData["warning"] = "Lo sentimos pero algo salio mal con el Área seleccionada";
                return RedirectToAction("Index");
            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteArea(int? IdArea)
        {
            if (IdArea == null || IdArea == 0)
                return NotFound();


            int codigo = IdArea.GetValueOrDefault();

            await _areaServices.DeletetArea(codigo);

            TempData["succes"] = "El Área se ha eliminado correctamente";
            return RedirectToAction("Index");
        }
    }
}
