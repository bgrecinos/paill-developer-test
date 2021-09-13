using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Models
{
    public class EmpleadoHabilidadViewModel
    {        
        [Display(Name = "Cod. Habilidad")]
        public int IdHabilidad { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Empleado")]
        public string IdEmpleado { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(150, ErrorMessage = "El campo {0} debe tener un máximo {1} caracteres")]
        [Display(Name = "Habilidad")]
        public string NombreHabilidad { get; set; }
    }
}
