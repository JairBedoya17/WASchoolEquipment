using System;
using System.Collections.Generic;

#nullable disable

namespace WAPizza.Shared.Models
{
    public partial class SchoolEquipment
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public int? Cantidad { get; set; }
        public int Precio { get; set; }
        public bool? Estado { get; set; }
        public string Trabajador { get; set; }
    }
}
