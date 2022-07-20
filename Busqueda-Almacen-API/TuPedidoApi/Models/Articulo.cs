using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistia.Models
{
    public class Articulo
    {
        public int Id { get; set; }

        public int IntervaloId { get; set; }

        public string Nombre { get; set; }

        public string Codigo { get; set; }

        public string UM { get; set; }
        public int Cantidad { get; set; }
        public int? Existencia { get; set; }

        public double PrecioCUP { get; set; }

        public string Utm_mov { get; set; }


        

    }
}
