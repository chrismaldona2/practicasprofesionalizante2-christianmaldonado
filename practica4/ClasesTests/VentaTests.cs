using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Clientes;
using Clases.Productos;

namespace Clases.Tests
{
    [TestClass()]
    public class VentaTests
    {
        ClienteVirtual chris; ClientePersonal messi; ClienteEmpresa mati_sa; ClienteCooperativa icescoop;
        ProductoFisico teclado; ProductoFisico mouse;
        ProductoVirtual juego; ProductoVirtual programa;
        Servicio limpieza; Servicio curso;

        [TestInitialize]
        public void Ejemplos()
        {

            chris = new ClienteVirtual(1, "Christian Maldonado", "Responsable Inscripto", "chris.ariel.maldonado@gmail.com","+54 9 3493 439701", "chrismaldona2");
            messi = new ClientePersonal(2, "Lionel Messi", "Responsable Inscripto", "lionelmessi@gmail.com", "+54 3493 213091", "España 231");
            mati_sa = new ClienteEmpresa(3, 30320651236, "Matias Maretto S.A.", "Monotributista ", "info@matisa.com.ar", "+54 3493 213502");
            icescoop = new ClienteCooperativa(4, 30301345236, "Cooperativa ICES", "Responsable Inscripto ", "coop@ices.com.ar", "+54 3493 123145");

            teclado = new ProductoFisico(1, "Teclado Mecanico", "Corsair", 65000, 10);
            mouse = new ProductoFisico(2, "Mouse", "Razer", 70000, 10);

            juego = new ProductoVirtual(3, "God Of War", "Sony", 50000, 60000);
            programa = new ProductoVirtual(4, "WinRAR", "win.rar GmbH", 5000, 3.2);

            limpieza = new Servicio(5, "Limpieza Profesional a Domicilio", "Edwards Argentina", 10000, new DateTime(2025, 7, 1));
            curso = new Servicio(6, "Curso Programación", "ICES", 150000, new DateTime(2025, 7, 15));
        }


        [TestMethod()]
        public void crearVentaTest1()
        {
            //se comprueba que se crea la venta correctamente y el monto está seteado en 0
            Venta venta1 = new Venta(1, messi);
            Assert.AreEqual(0, venta1.verMonto());
        }
        [TestMethod()]
        public void crearVentaTest2()
        {
            //se crea una venta y se le agrega un juego a los productos comprados
            Venta venta2 = new Venta(2, chris);
            venta2.agregarProducto(juego, 1);
            
            //Se verifica que el monto de la compra incremento dado el juego añadido
            Assert.IsTrue(venta2.verMonto() > 0);
        }

        [TestMethod()]
        public void crearVentaTest3()
        {
            //se crea una venta 
            Venta venta3 = new Venta(3, mati_sa);


            //se comprueba que al exceder la cantidad de stock en una compra, ocurre una excepción
            bool Error = false;

            try
            {
                venta3.agregarProducto(teclado, 20);
            } catch (Exception ex)
            {
                Error = true;
            }

            Assert.IsTrue(Error);
        }

        [TestMethod()]
        public void verMontoTest1()
        {
            //se crea una venta y se le agrega un producto de cada tipo
            //se comprueba que el monto final vaya incrementando correctamente a medida que se agregan productos a la venta

            Venta venta4 = new Venta(4, icescoop);

            
            venta4.agregarProducto(teclado, 10);
            // monto    +650000
            Assert.AreEqual(650000, venta4.verMonto());

            venta4.agregarProducto(programa, 20);
            // monto    +100000
            Assert.AreEqual(750000, venta4.verMonto());

            venta4.agregarProducto(limpieza, 1);
            // monto    +10000
            Assert.AreEqual(760000, venta4.verMonto());
        }

    }
}