using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Productos
{
    public class ProductoVirtual : Producto
    {
        public double PesoMB { get; set; }
        public ProductoVirtual(int codigo, string nombre, string marca, double precio, double pesomb) : base(codigo, nombre, marca, precio)
        {
            PesoMB = pesomb;
        }
    }
}
