using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public Producto(int id, string descripcion, string tipo, double precio, int stock)
        {
            Id = id;
            Descripcion = descripcion;
            Tipo = tipo;
            Precio = precio;
            Stock = stock;
        }
    }
}
