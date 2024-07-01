using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Pago
    {
        public int Id { get; set; }
        public int DniCliente { get; set; }
        public int IdMembresia { get; set; }
        public DateTime FechaPago { get; set; }
        public double Monto { get; set; }

    }
}
