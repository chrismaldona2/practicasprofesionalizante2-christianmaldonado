using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Productos
{
    public class Servicio : Producto
    {
        public DateTime Fecha { get; set; }
        public Servicio(int codigo, string nombre, string marca, double precio, DateTime fecha) : base(codigo, nombre, marca, precio)
        {
            Fecha = fecha;
        }
    }
}
