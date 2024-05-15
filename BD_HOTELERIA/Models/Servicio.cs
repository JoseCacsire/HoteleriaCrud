using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BD_HOTELERIA.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            Gastos = new HashSet<Gasto>();
        }
		[Required (ErrorMessage = "Este campo es requerido")]
		public int IdServicio { get; set; }
		[Required]
		public int IdTipoServicio { get; set; }
		[Required]
		public int Eliminado { get; set; }
		[Required (ErrorMessage = "Este campo es requerido")]
		public string Descripcion { get; set; }
		[Required (ErrorMessage = "Este campo es requerido")]
		[Range(minimum: 1, maximum: 1000, ErrorMessage = "El precio debe ser mayor a 0")]
		public decimal Precio { get; set; }

        public virtual TipoServicio IdTipoServicioNavigation { get; set; }
        public virtual ICollection<Gasto> Gastos { get; set; }
    }
}
