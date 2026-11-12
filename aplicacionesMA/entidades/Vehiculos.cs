using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacionesMA.entidades
{
   public class Vehiculos
    {
        public int Id { get; set; }
        public string? Placa{ get; set; }
        public string? Modelo{ get; set; }
        public double Precio { get; set; }
        public DateTime? FechaVenta { get; set; }
        public string? Notas { get; set; }
    }
}
