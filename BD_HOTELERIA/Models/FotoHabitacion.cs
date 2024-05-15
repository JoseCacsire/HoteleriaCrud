using System;
using System.Collections.Generic;

#nullable disable

namespace BD_HOTELERIA.Models
{
    public partial class FotoHabitacion
    {
        public int IdFotoHabitacion { get; set; }
        public byte[] Foto { get; set; }
        public int IdHabitacion { get; set; }

        public virtual Habitacion IdHabitacionNavigation { get; set; }
    }
}
