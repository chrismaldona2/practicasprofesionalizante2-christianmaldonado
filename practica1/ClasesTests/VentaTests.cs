using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Tests
{
    [TestClass()]
    public class VentaTests
    {
        Producto remera; Producto zapatilla; Producto reloj;
        Cliente chris; Cliente messi; Cliente mati;


        [TestInitialize]
        public void Ejemplos()
        {
            // productos de ejemplo
            remera = new Producto(1, "Remera", "Indumentaria", 15000, 10);
            zapatilla = new Producto(2, "Zapatillas Nike", "Calzado", 75000, 4);
            reloj = new Producto(3, "Reloj Rolex", "Relojes", 3000000, 3);

            // clientes de ejemplo
            chris = new Cliente(45492726, "Christian Maldonado");
            messi = new Cliente(33016244, "Lionel Messi");
            mati = new Cliente(32065123, "Matias Maretto");
        }
        [TestMethod()]
        public void agregarProductoAVentaTest1()
        {
            Venta venta = new Venta(1, chris);
            venta.agregarProducto(remera, 2);

            //comprueba que se agrego correctamente la remera
            Assert.AreEqual("Remera", venta.verDetalleVenta()[0].Producto.Descripcion);
        }

        [TestMethod()]
        public void agregarProductoAVentaTest2()
        {
            Venta venta = new Venta(2, messi);
            Assert.AreEqual(0, venta.verMonto());


            venta.agregarProducto(reloj, 2);

            //comprueba que se actualizo el monto de la venta
            Assert.AreEqual(6000000, venta.verMonto());
        }

        [TestMethod()]
        public void agregarProductoAVentaTest3()
        {
            //se comprueba el stock del producto

            Venta venta = new Venta(3, mati);
            Assert.AreEqual(4, zapatilla.Stock);


            venta.agregarProducto(zapatilla, 1);

            //comprueba que se actualizo el stock del producto
            Assert.AreEqual(3, zapatilla.Stock);
        }

        [TestMethod()]
        public void verMontoTest1()
        {
            //se comprueba que el monto vaya incrementando correctamente
            Venta venta = new Venta(4, messi, new DateTime(2025, 4, 29));

            //se compra un reloj  +3000000
            venta.agregarProducto(reloj, 1);
            Assert.AreEqual(3000000, venta.verMonto());

            //se compra tres remeras  +45000
            venta.agregarProducto(remera, 3);
            Assert.AreEqual(3045000, venta.verMonto());

            //se compra dos zapatillas  +150000
            venta.agregarProducto(zapatilla, 2);
            Assert.AreEqual(3195000, venta.verMonto());
            
        }

        [TestMethod()]
        public void verDetalleTest1()
        {
            //se comprueba que el detalle de la compra se devuelva correctamente
            Venta venta = new Venta(4, messi, new DateTime(2025, 4, 29));

            //compra 3 productos distintos
            venta.agregarProducto(reloj, 1);
            venta.agregarProducto(remera, 3);
            venta.agregarProducto(zapatilla, 2);

            Assert.AreEqual(3, venta.verDetalleVenta().Count);
        }


        [TestMethod()]
        public void verDetalleTest2()
        {
            //se comprueba que el detalle de la compra se devuelva correctamente
            Venta venta = new Venta(4, messi, new DateTime(2025, 4, 29));

            //compra 3 productos distintos
            venta.agregarProducto(reloj, 1);
            venta.agregarProducto(remera, 3);
            venta.agregarProducto(zapatilla, 2);


            //el tercer producto comprado son unas zapatillas nike
            Assert.AreEqual("Zapatillas Nike", venta.verDetalleVenta()[2].Producto.Descripcion);

            //se compraron 2
            Assert.AreEqual(2, venta.verDetalleVenta()[2].Cantidad);
        }
    }
}