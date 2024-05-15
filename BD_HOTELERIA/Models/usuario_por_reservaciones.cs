using System;
using System.ComponentModel.DataAnnotations;

namespace BD_HOTELERIA.Models
{
	public class usuario_por_reservaciones
	{
		[Key]
		public int idReservacion { get; set; }
		public int idHabitacion { get; set; }
		public int numeroHabitacion { get; set; }
		public int piso { get; set; }
		public decimal precio { get; set; }
		public DateTime fechaEntrada { get; set; }
		public DateTime fechaSalida { get; set; }
	}
}
