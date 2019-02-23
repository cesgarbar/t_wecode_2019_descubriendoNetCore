using System;
using System.Collections.Generic;

namespace AnimalesFantasticosDBContext.Models
{
    public partial class Animales
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int? Edad { get; set; }
    }
}
