﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BD_HOTELERIA.Models
{
    public partial class TipoServicio
    {
        public TipoServicio()
        {
            Servicios = new HashSet<Servicio>();
        }

        public int IdTipoServicio { get; set; }
        public string NombreServicio { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
