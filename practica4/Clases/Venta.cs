using Clases.Productos;
using Clases.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clases
{
    public class Venta
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        private double MontoFinal { get; set; }
        private List<(Producto producto, int cantidad)> ProductosComprados { get; set; }
        public Venta(int id, Cliente cliente, DateTime? fecha = null)
        {
            Id = id;
            Cliente = cliente;
            Fecha = fecha ?? DateTime.Now;
            ProductosComprados = new List<(Producto Producto, int Cantidad)>();
            MontoFinal = 0;
        }
        public void agregarProducto(Producto producto, int cantidad)
        {
            if (producto is ProductoFisico fisico)
            {
                if (cantidad > fisico.Stock)
                {
                    throw new Exception("No hay suficiente stock para concretar la venta.");
                } else
                {
                    fisico.Stock -= cantidad;
                }
            }

            ProductosComprados.Add((producto, cantidad));
            MontoFinal += producto.Precio * cantidad;
        }

        public double verMonto()
        {
            return MontoFinal;
        }
    }
}
