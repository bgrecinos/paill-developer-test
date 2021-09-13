using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Models
{
    public class EmpleadoViewModel
    {
        [Display(Name = "Cod. Empleado")]
        public int IdEmpleado { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(150, ErrorMessage = "El campo {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(15, ErrorMessage = "El campo {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 10)]
        [Display(Name = "Cedula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(200, ErrorMessage = "El campo {0} un máximo {1} caracteres")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Correo")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Date, ErrorMessage = "El campo {0} no tiene un formato de fecha valido")]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Date, ErrorMessage = "El campo {0} no tiene un formato de fecha valido")]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Cod. Jefe")]
        public string IdJefe { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Cod. Area")]
        public string IdArea { get; set; }

        [Display(Name = "Foto")]
        public byte[] Foto { get; set; }

        [Display(Name = "Iamgen")]
        public IFormFile Imagen { get; set; }       
    }
}
