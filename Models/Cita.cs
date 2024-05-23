using System;

namespace BeautySalonManager.Models
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdServicio { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
    }
}
