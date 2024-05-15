using System;
using System.Collections.Generic;

#nullable disable

namespace BD_HOTELERIA.Models
{
    public partial class Rol
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
