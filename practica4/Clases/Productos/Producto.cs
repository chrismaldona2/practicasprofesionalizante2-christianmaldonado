using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Productos
{
    public class Producto
    {
        public int Codigo {  get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public Producto(int codigo, string nombre, string marca, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Marca = marca;
            Precio = precio;
        }
    }
}
