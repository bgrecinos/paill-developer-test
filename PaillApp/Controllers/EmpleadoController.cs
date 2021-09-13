using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PaillApp.Models;
using PaillApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly IEmpleadoService _empleadoService;
        private readonly IAreaServices _areaServices;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EmpleadoController(IEmpleadoService empleadoService, IAreaServices areaServices, IWebHostEnvironment webHostEnvironment)
        {
            _empleadoService = empleadoService;
            _areaServices = areaServices;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _empleadoService.GetEmpleados();
            return View(result);
        }

        public async Task<IActionResult> Create()
        {
            List<SelectListItem> jefes = GetJefes();

            var areasResult = await _areaServices.GetAreas();
            List<SelectListItem> areas = areasResult.Select(s => new SelectListItem() { Value = s.IdArea.ToString(), Text = s.Nombre, Selected = false }).ToList();

            ViewBag.Jefes = jefes;
            ViewBag.Areas = areas;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmpleadoViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);


            if (model.Imagen != null)
                model.Foto = GetByteArrayFromImage(model.Imagen);

            await _empleadoService.InsertEmpleado(model);

            TempData["succes"] = "El Área se ha creado correctamente";
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            List<SelectListItem> jefes = GetJefes();
            var areasResult = await _areaServices.GetAreas();
            List<SelectListItem> areas = areasResult.Select(s => new SelectListItem() { Value = s.IdArea.ToString(), Text = s.Nombre, Selected = false }).ToList();

            int codigo = id.GetValueOrDefault();
            var model = await _empleadoService.GetEmpleadoById(codigo);
            if (model == null)
            {
                TempData["warning"] = "Lo sentimos pero algo salio mal con el Empleado seleccionada";
                return RedirectToAction("Index");
            }
            if(model.Foto != null)
            {
                string imreBase64Data = Convert.ToBase64String(model.Foto);
                string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);
                ViewBag.ImageData = imgDataURL;
            }

            ViewBag.Jefes = jefes;
            ViewBag.Areas = areas;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(EmpleadoViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (model.Imagen != null)
                model.Foto = GetByteArrayFromImage(model.Imagen);

            await _empleadoService.UpdateEmpleado(model);

            TempData["succes"] = "El Área se ha actualizado correctamente";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            List<SelectListItem> jefes = GetJefes();
            var areasResult = await _areaServices.GetAreas();
            List<SelectListItem> areas = areasResult.Select(s => new SelectListItem() { Value = s.IdArea.ToString(), Text = s.Nombre, Selected = false }).ToList();

            int codigo = id.GetValueOrDefault();
            var model = await _empleadoService.GetEmpleadoById(codigo);
            if (model == null)
            {
                TempData["warning"] = "Lo sentimos pero algo salio mal con el Empleado seleccionada";
                return RedirectToAction("Index");
            }

            ViewBag.Jefes = jefes;
            ViewBag.Areas = areas;
            ViewBag.Edad = GetEdad(model.FechaNacimiento);
            ViewBag.EdadLaboral = GetTiempoLaboral(model.FechaIngreso);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletEmpleado(int? IdEmpleado)
        {
            if (IdEmpleado == null || IdEmpleado == 0)
                return NotFound();

            int codigo = IdEmpleado.GetValueOrDefault();
            await _empleadoService.DeleteEmpleado(codigo);

            TempData["succes"] = "El Área se ha eliminado correctamente";
            return RedirectToAction("Index");
        }


        private List<SelectListItem> GetJefes()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Value = "1", Text = "Jefe TI", Selected = false},
                new SelectListItem() { Value = "2", Text = "Jefe RRHH", Selected = false},
                new SelectListItem() { Value = "3", Text = "Jefe Ventas", Selected = false}
            };

        }

        private byte[] GetByteArrayFromImage(IFormFile file)
        {
            using (var target = new MemoryStream())
            {
                file.CopyTo(target);
                return target.ToArray();
            }
        }

        private int GetEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            if(fechaNacimiento < DateTime.Now.Date)
                if (edad > 0)
                    edad = edad - 1;
            return edad;
        }
        private double GetTiempoLaboral(DateTime fechaIngreso)
        {
            var results = ((DateTime.Now.Year - fechaIngreso.Year) * 12) + DateTime.Now.Month - fechaIngreso.Month;
            return (results / 12);
        }
    }
}
