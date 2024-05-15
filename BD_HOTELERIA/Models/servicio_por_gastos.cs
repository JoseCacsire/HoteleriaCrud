using System;
using System.ComponentModel.DataAnnotations;

namespace BD_HOTELERIA.Models
{
	public class servicio_por_gastos
	{
		[Key]
		public string nombre { get; set; }
		public int idUsuario { get; set; }
		public string apellidoPadre { get; set; }
		public int numeroHabitacion { get; set; }
		public int piso { get; set; }
		public DateTime fecha { get; set; }
		public decimal total { get; set; }
	}
}
