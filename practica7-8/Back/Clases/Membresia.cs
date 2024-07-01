using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Membresia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int CantidadMeses { get; set; }
        public double Monto { get; set; }
        public override string ToString()
        {
            return $"{Descripcion} - {CantidadMeses} Meses";
        }
    }
}
