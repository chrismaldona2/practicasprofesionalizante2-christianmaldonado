using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Venta
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        private List<(Producto Producto, int Cantidad)> Productos { get; set; }
        private double Monto { get; set; }
        public Venta(int id, Cliente cliente, DateTime? fecha = null)
        {
            Id = id;
            Cliente = cliente;
            Fecha = fecha ?? DateTime.Now;
            Productos = new List<(Producto Producto, int Cantidad)>();
            Monto = 0;
        }
        public void agregarProducto(Producto producto, int cantidad)
        {
            if (producto.Stock >= cantidad)
            {
                Productos.Add((producto, cantidad));
                Monto += producto.Precio * cantidad;
                producto.Stock -= cantidad;
            }
        }
        public List<(Producto Producto, int Cantidad)> verDetalleVenta()
        {
            return Productos;
        }
        public double verMonto()
        {
            return Monto;
        }
    }
}
