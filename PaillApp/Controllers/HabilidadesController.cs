using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PaillApp.Models;
using PaillApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Controllers
{
    public class HabilidadesController : Controller
    {
        private readonly IEmpleadoService _empleadoService;
        private readonly IEmpleadoHabilidadService _empleadoHabilidadService;
        private readonly List<string> _habilidades = new List<string>() { "ASP.NET Core", "C#", "VB", "WCF", "JavaScript", "TypeScript", "Node.js", "Angular", "SQL Server", "PL/SQL", "MicroServices" };

        public HabilidadesController(IEmpleadoService empleadoService, IEmpleadoHabilidadService empleadoHabilidadService)
        {
            _empleadoService = empleadoService;
            _empleadoHabilidadService = empleadoHabilidadService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var results = await _empleadoHabilidadService.GetEmpleadoHabilidades(id);
            return View(results);
        }

        public async Task<IActionResult> Crear()
        {
            var empleadoResult = await _empleadoService.GetEmpleados();
            List<SelectListItem> areas = empleadoResult.Select(s => new SelectListItem() { Value = s.IdEmpleado.ToString(), Text = s.NombreCompleto, Selected = false }).ToList();
            ViewBag.Empleados = areas;
            ViewBag.Habilidades = _habilidades;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(EmpleadoHabilidadViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _empleadoHabilidadService.InsertEmpleadoHabilidad(model);

            TempData["succes"] = "El Habilidades registradas correctamente";

            return RedirectToAction("Index", new { id = model.IdEmpleado });
        }
    }
}
