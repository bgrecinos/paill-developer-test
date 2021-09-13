#nullable disable

namespace PaillApp.Entities
{
    public partial class EmpleadoHabilidad
    {
        public int IdHabilidad { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreHabilidad { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
