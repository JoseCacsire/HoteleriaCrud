using System;
using System.ComponentModel.DataAnnotations;

namespace BD_HOTELERIA.Models
{
    public class reservaciones_caras
    {
		[Key]
        public int idReservacion { get; set; }
		public DateTime fechaEntrada { get; set; }
		public DateTime fechaSalida { get; set; }
		public decimal precio { get; set; }
		public int numeroHabitacion { get; set; }
		public string Cliente { get; set; }
	}
}
