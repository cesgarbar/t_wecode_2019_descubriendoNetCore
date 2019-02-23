using System;
using System.Collections.Generic;

namespace AnimalesFantasticosDBContext.Models
{
    public partial class Magos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Edad { get; set; }
    }
}
