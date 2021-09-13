using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp.Models
{
    public class AreaViewModel
    {
        [Display(Name = "Cod. Área")]
        public int IdArea { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage ="El campo {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(150, ErrorMessage = "El campo {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}
