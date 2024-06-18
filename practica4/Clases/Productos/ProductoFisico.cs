using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Productos
{
    public class ProductoFisico : Producto
    {
        public int Stock {  get; set; }
        public ProductoFisico(int codigo, string nombre, string marca, double precio, int stock) : base(codigo, nombre, marca, precio)
        {
            Stock = stock;
        }
    }
}
