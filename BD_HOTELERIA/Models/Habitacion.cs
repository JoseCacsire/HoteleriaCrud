using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BD_HOTELERIA.Models
{
    public partial class Habitacion
    {
        public Habitacion()
        {
            FotoHabitacions = new HashSet<FotoHabitacion>();
            Reservacions = new HashSet<Reservacion>();
        }

        [Required]
        public int IdHabitacion { get; set; }
		[Required (ErrorMessage ="Este campo es requerido")]
		public int NumeroHabitacion { get; set; }
		[Required (ErrorMessage = "Este campo es requerido")]
		[Range (minimum: 1, maximum: 10, ErrorMessage = "Solo existen 10 pisos") ]
		public int Piso { get; set; }
		[Required(ErrorMessage = "Este campo es requerido")]
		public string Descripcion { get; set; }
		[Required (ErrorMessage = "Este campo es requerido")]
		[Range (minimum:1,maximum:1000, ErrorMessage = "El precio debe ser mayor a 0")]
		public decimal Precio8Horas { get; set; }
		[Required (ErrorMessage = "Este campo es requerido")]
		[Range (minimum: 1, maximum: 10000, ErrorMessage = "El precio debe ser mayor a 0")]
		public decimal PrecioDia { get; set; }
		[Required]
		public int Eliminado { get; set; }
		[Required]
		public string Estado { get; set; }
		[Required]
		public int IdTipoHabitacion { get; set; }

        public virtual TipoHabitacion IdTipoHabitacionNavigation { get; set; }
        public virtual ICollection<FotoHabitacion> FotoHabitacions { get; set; }
        public virtual ICollection<Reservacion> Reservacions { get; set; }
    }
}
