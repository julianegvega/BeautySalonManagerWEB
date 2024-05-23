﻿using System;

namespace BeautySalonManager.Models
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int DuracionEstimada { get; set; }
    }

}

