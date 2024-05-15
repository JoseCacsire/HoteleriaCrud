using System.ComponentModel.DataAnnotations;

namespace BD_HOTELERIA.Models
{
    public class habitaciones_piso_tipo
    {
		[Key]
        public int idHabitacion { get; set; }
		public int numeroHabitacion { get; set; }
		public string descripcion { get; set; }
		public int piso { get; set; }
		public decimal Horas { get; set; }
		public decimal Dia { get; set; }
		public string estado { get; set; }
	}
}
