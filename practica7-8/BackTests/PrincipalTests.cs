using Microsoft.VisualStudio.TestTools.UnitTesting;
using Back;
using Back.Clases;
using System;
using WebApplication1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http.Json;

namespace Back.Tests
{
    [TestClass()]
    public class PrincipalTests
    {
        private ApplicationDbContext _context;
        private Principal _principal;

        [TestInitialize]
        public void Setup()
        {
            //se crea usa como bd una creada en memoria para no modificar la original

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("GimnasioBD")
                .Options;

            _context = new ApplicationDbContext(options);
            _principal = new Principal(_context);
        }




        // TESTS PARA METODOS RELACIONADOS CON EL CLIENTE

        //tests para el metodo de busqueda de cliente mediante dni
        [TestMethod()]
        public void returnClienteByDNITest1()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(45492726, "Christian Maldonado", "+54 3493 439701", 1);
            var cliente = _principal.returnClienteByDNI(45492726);

            //verifica que los datos del cliente se recuperen correctamente
            Assert.AreEqual(1, cliente.Id);
            Assert.AreEqual(45492726, cliente.Dni);
            Assert.AreEqual("Christian Maldonado", cliente.Nombre);
            Assert.AreEqual("+54 3493 439701", cliente.Telefono);

            DateTime fechaComprobar = DateTime.Now.AddMonths(1);
            Assert.AreEqual(fechaComprobar.Date, cliente.VencimientoMembresia.Date);
        }

        [TestMethod()]
        public void returnClienteByDNITest2()
        {
            // verifica que se lance una excepción al buscar un cliente no registrado
            var error = Assert.ThrowsException<Exception>(() => _principal.returnClienteByDNI(43123946));
            // verifica el mensaje de la excepción
            Assert.AreEqual("Cliente no encontrado.", error.Message);
        }

        [TestMethod()]
        public void returnClienteByDNITest3()
        {
            //verifica que se lance una excepcion al ingresar un dni invalido
            Assert.ThrowsException<Exception>(() => _principal.returnClienteByDNI(1234567890));
        }




        //tests para el metodo que crea clientes
        [TestMethod()]
        public void registrarClienteTest1()
        {
            //verifica que se lance una excepcion al ingresar un dni invalido
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            Assert.ThrowsException<Exception>(() => _principal.registrarCliente(1234567890, "Lionel Messi", "+54 3493 415282", 1));
        }
        [TestMethod()]
        public void registrarClienteTest2()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);

            //si se desea registrar un cliente con un dni registrado se lanza una excepción
            Assert.ThrowsException<Exception>(() => _principal.registrarCliente(43123946, "Alexis Mac Allister", "+54 3493 390346", 1));
        }
        [TestMethod()]
        public void registrarClienteTest3()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);
            _principal.registrarCliente(45492726, "Christian Maldonado", "+54 3493 439701", 1);
            _principal.registrarCliente(41039287, "Alexis Mac Allister", "+54 3493 390346", 1);
            var listaClientes = _principal.returnListaClientes();


            //a cada cliente registrado se le asigna un id
            Assert.AreEqual("Lionel Messi", listaClientes.Find(x => x.Id == 1).Nombre);
            Assert.AreEqual("Christian Maldonado", listaClientes.Find(x => x.Id == 2).Nombre);
            Assert.AreEqual("Alexis Mac Allister", listaClientes.Find(x => x.Id == 3).Nombre);


            //los id una vez han sido usados no puede volver a utilizarse, aunque el cliente con tal id haya sido eliminado
            _principal.eliminarCliente(3);
            _principal.registrarCliente(41504712, "Julián Álvarez", "+54 3493 420366", 1);
            listaClientes = _principal.returnListaClientes();


            Assert.AreEqual(null, listaClientes.Find(x => x.Id == 3));
            Assert.AreEqual("Julián Álvarez", listaClientes.Find(x => x.Id == 4).Nombre);
        }

        [TestMethod()]
        public void registrarClienteTest4()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            //verifica que se lance una excepcion al ingresar un dejar un campo nulo o vacio
            Assert.ThrowsException<Exception>(() => _principal.registrarCliente(43123946, null, "      ", 1));
        }




        //tests para el metodo que modifica clientes
        [TestMethod()]
        public void modificarClienteTest1()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);


            var cliente = _principal.returnClienteByDNI(43123946);
            Assert.AreEqual("Lionel Messi", cliente.Nombre);

            // se modifica el nombre del cliente
            _principal.modificarCliente(1, "Lionel Andrés Messi Cuccittini");

            // se verifica que el nombre del cliente se modifico correctamente
            cliente = _principal.returnClienteByDNI(43123946);
            Assert.AreEqual("Lionel Andrés Messi Cuccittini", cliente.Nombre);
        }

        [TestMethod()]
        public void modificarClienteTest2()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(41504712, "Julián Álvarez", "+54 3493 420366", 1);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);
            _principal.registrarCliente(41039287, "Alexis Mac Allister", "+54 3493 390346", 1);
            _principal.registrarCliente(42091651, "Cristian Romero", "+54 3493 390346", 1);

            // alexis se le asigna el id 3
            Assert.AreEqual(3, _principal.returnListaClientes().Find(c => c.Nombre == "Alexis Mac Allister").Id);


            // modifico el numero de telefono de alexis cuyo id de cliente es 3
            _principal.modificarCliente(3, null, "+54 3493 439102");

            // se verifica que el telefono del cliente se modifico correctamente
            Assert.AreEqual("+54 3493 439102", _principal.returnListaClientes().Find(c => c.Id == 3).Telefono);
        }

        [TestMethod()]
        public void modificarClienteTest3()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(41504712, "Julián Álvarez", "+54 3493 420366", 1);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);

            _principal.modificarCliente(1);
            _principal.modificarCliente(2, "Lionel Andrés Messi Cuccittini");

            // se comprueba que los campos de no especificados no sean modificados
            var julian = _principal.returnListaClientes().Find(c => c.Id == 1);
            var messi = _principal.returnListaClientes().Find(c => c.Id == 2);

            Assert.AreEqual("Julián Álvarez", julian.Nombre);
            Assert.AreEqual("+54 3493 420366", julian.Telefono);
            Assert.AreEqual("+54 3493 415282", messi.Telefono);

            // y que el nombre de messi si lo hizo dado que sí se especifico su modificacion
            Assert.AreEqual("Lionel Andrés Messi Cuccittini", messi.Nombre);
        }




        //tests para el metodo que elimina clientes
        [TestMethod()]
        public void eliminarClienteTest1()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(41504712, "Julián Álvarez", "+54 3493 420366", 1);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);
            _principal.registrarCliente(41039287, "Alexis Mac Allister", "+54 3493 390346", 1);
            _principal.registrarCliente(42091651, "Cristian Romero", "+54 3493 390346", 1);
            Assert.AreEqual(4, _principal.returnListaClientes().Count);


            _principal.eliminarCliente(1);
            // eliminado el cliente con id 1, la cantidad de clientes en la lista se reduce
            Assert.AreEqual(3, _principal.returnListaClientes().Count);
        }

        [TestMethod()]
        public void eliminarClienteTest2()
        {
            // al intentar eliminar un cliente inexistente ocurre una excepción
            Assert.ThrowsException<Exception>(() => _principal.eliminarCliente(1));
        }

        [TestMethod()]
        public void eliminarClienteTest3()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(41504712, "Julián Álvarez", "+54 3493 420366", 1);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);

            _principal.eliminarCliente(1); // se elimina el cliente con id 1

            // al intentar buscar un cliente eliminado mediante su dni, ocurre una excepcion
            Assert.ThrowsException<Exception>(() => _principal.returnClienteByDNI(41504712));

            // tampoco se lo puede encontrar al buscarlo en la lista de clientes
            var listaClientes = _principal.returnListaClientes();
            Assert.AreEqual(null, listaClientes.Find(c => c.Id == 1));
            Assert.IsTrue(listaClientes.Find(c => c.Id ==2).Nombre == "Lionel Messi");
        }




        //tests para el metodo que recupera la lista de clientes
        [TestMethod()]
        public void returnListaClientesTest1()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(44153916, "Jose Ramirez", "+54 3493 392012", 1);
            var listaClientes = _principal.returnListaClientes();

            //se comprueba que el cliente se añadio a la lista correctamente
            Assert.IsTrue(listaClientes.Count == 1);
        }

        [TestMethod()]
        public void returnListaClientesTest2()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);
            _principal.registrarCliente(45492726, "Christian Maldonado", "+54 3493 439701", 1);
            int cuentaInicial = _principal.returnListaClientes().Count;

            _principal.eliminarCliente(1);
            int cuentaFinal = _principal.returnListaClientes().Count;

            //se comprueba que eliminado un cliente, la cantidad de clientes en la lista se reduce
            Assert.IsTrue(cuentaFinal < cuentaInicial);
        }

        [TestMethod()]
        public void returnListaClientesTest3()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);
            _principal.registrarCliente(45492726, "Christian Maldonado", "+54 3493 439701", 1);
            _principal.registrarCliente(41039287, "Alexis Mac Allister", "+54 3493 390346", 1);
            var listaClientes = _principal.returnListaClientes();

            //se comprueba que los datos de los clientes se encuentren correctamente registrados
            Assert.AreEqual("Lionel Messi", listaClientes[0].Nombre);
            Assert.AreEqual("Christian Maldonado", listaClientes[1].Nombre);
            Assert.AreEqual("Alexis Mac Allister", listaClientes[2].Nombre);
        }




        // TESTS PARA METODOS RELACIONADOS CON LOS ADMINISTRADORES

        //tests para el metodo de registro de admin
        [TestMethod()]
        public void registrarAdminTest1()
        {
            // crear un admin con un nombre de usuario ya usado lanza una excepcion
            _principal.registrarAdmin("Christian", "chrismaldona2", "contraseña123");
            Assert.ThrowsException<Exception>(() => _principal.registrarAdmin("Administrador", "chrismaldona2", "admin"));
        }

        [TestMethod()]
        public void registrarAdminTest2()
        {
            _principal.registrarAdmin("Administrador", "admin", "admin");
            _principal.registrarAdmin("Christian", "chrismaldona2", "contraseña123");

            //verifica que los admins hayan sido agregados correctamente a su respectiva tabla
            int cantAdmins = _context.Administradores.Count();
            Assert.AreEqual(2, cantAdmins);
        }

        [TestMethod()]
        public void registrarAdminTest3()
        {
            // verifica que se deban completar todos los campos correctamente para poder registrar al administrador con exito
            Assert.ThrowsException<Exception>(() => _principal.registrarAdmin("Administrador", "admin", "     "));
            Assert.ThrowsException<Exception>(() => _principal.registrarAdmin("Administrador", null, "admin"));
            Assert.ThrowsException<Exception>(() => _principal.registrarAdmin(null, null, "admin"));
        }




        //tests para el metodo que autentica al admin
        [TestMethod()]
        public void autenticacionAdminTest1()
        {
            _principal.registrarAdmin("Administrador", "admin", "admin");
            var adminAuth = _principal.autenticacionAdmin("admin", "admin");

            // se verifica que el admin haya sido autenticado con exito
            Assert.IsTrue(adminAuth != null);
        }

        [TestMethod()]
        public void autenticacionAdminTest2()
        {
            _principal.registrarAdmin("Administrador", "admin", "admin");

            // verifica que se lance una excepción al intentar ingresar con datos incorrectos
            Assert.ThrowsException<Exception>(() => _principal.autenticacionAdmin("admin", "adminn"));
        }

        [TestMethod()]
        public void autenticacionAdminTest3()
        {
            _principal.registrarAdmin("Administrador", "admin", "admin");

            // verifica que se deban completar todos los campos correctamente para poder ingresar con exito
            Assert.ThrowsException<Exception>(() => _principal.autenticacionAdmin("admin", "  "));
            Assert.ThrowsException<Exception>(() => _principal.autenticacionAdmin(null, "admin"));
            Assert.IsTrue(_principal.autenticacionAdmin("admin", "admin") != null);
        }




        // TESTS PARA METODOS RELACIONADOS CON LAS MEMBRESIAS

        //tests para el metodo de alta de membresia
        [TestMethod()]
        public void añadirTipoMembresiaTest1()
        {
            // verifica que se deban completar todos los campos correctamente para poder agregar el tipo de membresia
            Assert.ThrowsException<Exception>(() => _principal.añadirTipoMembresia(null, 1, 12000));
            Assert.ThrowsException<Exception>(() => _principal.añadirTipoMembresia("     ", 1, 12000));
        }

        [TestMethod()]
        public void añadirTipoMembresiaTest2()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.añadirTipoMembresia("Trimestral", 3, 24000);
            _principal.añadirTipoMembresia("Semestral ", 6, 6000);
            _principal.añadirTipoMembresia("Anual", 12, 110000);

            //se verifica que las membresian se añadan correctamente a su respectiva tabla
            Assert.AreEqual(4, _context.Membresias.Count());
        }

        [TestMethod()]
        public void añadirTipoMembresiaTest3()
        {
            // verifica que se lance una excepcion si el precio de la membresia es un número menor a 0
            Assert.ThrowsException<Exception>(() => _principal.añadirTipoMembresia("Mensual", 1, -12000));


            // verifica que se lance una excepcion si la cantidad de meses de la membresia no es mayor a 0
            Assert.ThrowsException<Exception>(() => _principal.añadirTipoMembresia("Mensual", 0, 12000));
            Assert.ThrowsException<Exception>(() => _principal.añadirTipoMembresia("Mensual", -1, 12000));
        }




        //tests para el metodo de modificacion de membresia
        [TestMethod()]
        public void modificarMembresiaTest1()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000); //id = 1
            _principal.modificarMembresia(1, null, null, 16000);

            var membresia = _context.Membresias.Find(1);

            // se comprueba que los campos de no especificados no sean modificados
            Assert.AreEqual("Mensual", membresia.Descripcion);
            Assert.AreEqual(1, membresia.CantidadMeses);

            // y que el campo que si fue modificado si haya cambiado
            Assert.AreEqual(16000, membresia.Monto);
        }

        [TestMethod()]
        public void modificarMembresiaTest2()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000); //id = 1

            // verifica que se lance una excepcion si el precio nuevo de la membresia es un número menor a 0
            Assert.ThrowsException<Exception>(() => _principal.modificarMembresia(1, null, null, -16000));


            // verifica que se lance una excepcion si la nueva cantidad de meses de la membresia no es mayor a 0
            Assert.ThrowsException<Exception>(() => _principal.modificarMembresia(1, null, -1, null));
        }

        [TestMethod()]
        public void modificarMembresiaTest3()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.añadirTipoMembresia("Trimestral", 3, 24000);
            _principal.añadirTipoMembresia("Semestral ", 6, 60000);
            _principal.añadirTipoMembresia("Anual", 12, 110000);


            // se modifican todas las membresias aumentando el precio en un 10%
            foreach (var m in _context.Membresias)
            {
                _principal.modificarMembresia(m.Id, null, null, m.Monto + (m.Monto * 0.1));
            }

            // se verifica que los precios aumentaron correctamente
            Assert.AreEqual(13200, _context.Membresias.Find(1).Monto);
            Assert.AreEqual(26400, _context.Membresias.Find(2).Monto);
            Assert.AreEqual(66000, _context.Membresias.Find(3).Monto);
            Assert.AreEqual(121000, _context.Membresias.Find(4).Monto);
        }

        //tests para el metodo de eliminacion de membresia
        [TestMethod()]
        public void eliminarMembresiaTest1()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.añadirTipoMembresia("Trimestral", 3, 24000);
            _principal.añadirTipoMembresia("Semestral ", 6, 60000);
            int cuentaInicial = _context.Membresias.Count();
            Assert.AreEqual(3, cuentaInicial);


            _principal.eliminarMembresia(1);
            int cuentaFinal = _context.Membresias.Count();
            Assert.AreEqual(2, cuentaFinal);


            // al eliminar una membresia, la cantidad de membresias en la tabla correspondiente se reduce
            Assert.IsTrue(cuentaFinal < cuentaInicial);
        }

        [TestMethod()]
        public void eliminarMembresiaTest2()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.añadirTipoMembresia("Trimestral", 3, 24000);
            _principal.añadirTipoMembresia("Semestral ", 6, 60000);

            //verifica que existe una membresia con la descripcion "Trimestral"
            Assert.IsTrue(_context.Membresias.FirstOrDefault(x => x.Descripcion == "Trimestral") != null);


            //al eliminar la membresia con id 2 cuya descripcion es "Trimestral", esta deja de ser encontrada en la lista
            _principal.eliminarMembresia(2);
            Assert.IsFalse(_context.Membresias.FirstOrDefault(x => x.Descripcion == "Trimestral") != null);
        }

        [TestMethod()]
        public void eliminarMembresiaTest3()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.añadirTipoMembresia("Trimestral", 3, 24000);

            // al intentar eliminar una membresia inexistente ocurre una excepcion
            Assert.ThrowsException<Exception>(() => _principal.eliminarMembresia(3));

        }


        //tests para el metodo que retorna la lista de membresias

        [TestMethod()]
        public void returnListaMembresiaTest1()
        {
            // a medida que se añaden membresias, las mismas de van agregando a la lista correctamente
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.añadirTipoMembresia("Trimestral", 3, 24000);

            Assert.AreEqual(2, _principal.returnListaMembresia().Count);

            _principal.añadirTipoMembresia("Semestral ", 6, 60000);
            _principal.añadirTipoMembresia("Anual", 12, 110000);

            Assert.AreEqual(4, _principal.returnListaMembresia().Count);
        }

        [TestMethod()]
        public void returnListaMembresiaTest2()
        {
            
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.añadirTipoMembresia("Trimestral", 3, 24000);
            _principal.añadirTipoMembresia("Semestral ", 6, 60000);
            _principal.añadirTipoMembresia("Anual", 12, 110000);
            Assert.AreEqual(4, _principal.returnListaMembresia().Count);

            // a medida que se eliminan membresias, las mismas se van quitando de la lista correctamente
            _principal.eliminarMembresia(2);
            _principal.eliminarMembresia(3);
            Assert.AreEqual(2, _principal.returnListaMembresia().Count);
        }


        [TestMethod()]
        public void returnListaMembresiaTest3()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.añadirTipoMembresia("Trimestral", 3, 24000);
            Assert.AreEqual("Mensual", _principal.returnListaMembresia()[0].Descripcion);
            Assert.AreEqual(24000, _principal.returnListaMembresia()[1].Monto);

            //a medida que modifico membresias, los datos en la lista se van actualizando

            _principal.modificarMembresia(1, "Mensual Premium");
            _principal.modificarMembresia(2, null, null, 26000);
            Assert.AreEqual("Mensual Premium", _principal.returnListaMembresia()[0].Descripcion);
            Assert.AreEqual(26000, _principal.returnListaMembresia()[1].Monto);
        }






        // TESTS PARA METODOS RELACIONADOS CON LOS PAGOS

        [TestMethod()]
        public void registrarPagoTest1()
        {
            _principal.añadirTipoMembresia("Anual", 12, 110000);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);

            //el metodo registrar cliente tiene un registrarPago() incorporado
            //cada vez que se registra un cliente se presupone que pago
            Assert.AreEqual(1, _principal.returnListaPagosCliente(43123946).Count);
        }

        [TestMethod()]
        public void registrarPagoTest2()
        {
            _principal.añadirTipoMembresia("Anual", 12, 110000);
            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);

            //el metodo registrar cliente tiene un registrarPago() incorporado
            //cada vez que se registra un cliente se presupone que pago

            //si decide renovar su membresia se registra otro pago
            _principal.registrarPago(43123946, 1);
            Assert.AreEqual(2, _principal.returnListaPagosCliente(43123946).Count);
        }

        [TestMethod()]
        public void registrarPagoTest3()
        {
            _principal.añadirTipoMembresia("Anual", 12, 110000);
            var membresiaAnual = _context.Membresias.Find(1);


            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", membresiaAnual.Id);

            //el metodo registrar cliente tiene un registrarPago() incorporado
            //cada vez que se registra un cliente se presupone que pago
            //dependiendo de la membresia seleccionada se le determina una fecha de vencimiento de la misma
            Assert.AreEqual(1, _principal.returnListaPagosCliente(43123946).Count);

            DateTime fechaMesesDesp = DateTime.Now.Date.AddMonths(membresiaAnual.CantidadMeses);
            Assert.AreEqual(fechaMesesDesp.Date, _principal.returnClienteByDNI(43123946).VencimientoMembresia.Date);

            //si vuelvo a renovar la membresia se actualiza la fecha de vencimiento
            _principal.registrarPago(43123946, 1);
            fechaMesesDesp = fechaMesesDesp.AddMonths(membresiaAnual.CantidadMeses);
            Assert.AreEqual(fechaMesesDesp.Date, _principal.returnClienteByDNI(43123946).VencimientoMembresia.Date);


        }



        //tests para el metodo que autentica al admin
        [TestMethod()]
        public void returnListaPagosClienteTest1()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.añadirTipoMembresia("Trimestral", 3, 24000);

            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);
            _principal.registrarCliente(41039287, "Alexis Mac Allister", "+54 3493 390346", 2);

            //cada uno de los clientes registrados por primera vez tendra un pago realizado x su inscripción
            Assert.AreEqual(1, _principal.returnListaPagosCliente(43123946).Count);
            Assert.AreEqual(1, _principal.returnListaPagosCliente(41039287).Count);
        }

        [TestMethod()]
        public void returnListaPagosClienteTest2()
        {
            _principal.añadirTipoMembresia("Mensual", 1, 12000);
            _principal.añadirTipoMembresia("Trimestral", 3, 24000);

            _principal.registrarCliente(43123946, "Lionel Messi", "+54 3493 415282", 1);
            _principal.registrarCliente(41039287, "Alexis Mac Allister", "+54 3493 390346", 2);

            // cada uno de los clientes registrados por primera vez tendra un pago realizado x su inscripción
            Assert.AreEqual(1, _principal.returnListaPagosCliente(43123946).Count);
            Assert.AreEqual(1, _principal.returnListaPagosCliente(41039287).Count);

            // si uno de los clientes renueva su membresia, su lista de pagos es actualizada
            _principal.registrarPago(41039287, 2);
            Assert.AreEqual(1, _principal.returnListaPagosCliente(43123946).Count);
            Assert.AreEqual(2, _principal.returnListaPagosCliente(41039287).Count);
        }

        [TestMethod()]
        public void returnListaPagosClienteTest3()
        {
            // no es posible obtener la lista de pagos de un cliente inexistente
            Assert.ThrowsException<Exception>(() => _principal.returnListaPagosCliente(12345678));
        }







        /*

        NO FUNCIONA
        
        VERIFIQUE QUE SI EJECUTO 6 VECES ESTE UNIT TEST, SI EJECUTO LA API DESDE LA PAGINA DE SWAGGER,
        EL ULTIMO NUEVO ADMIN APARECERA CON ID 7, ASÍ QUE ESTO SE ESTA EJECUTANDO CORRECTAMENTE PERO NO
        SON USAN EL MISMO DBCONTEXT

        AUNQUE LA API USE DE EL MISMO "UseInMemoryDatabase("GimnasioBD")"
        PARECIERAN NO SER LAS MISMAS FUENTES
        ESPERO PODER SOLUCIONARLO PROXIMAMENTE


        [TestMethod()]
        public async Task registrarAdminConWebServiceTest1()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5100");

            Administrador adminNuevo = new Administrador
            {
                Nombre = "admin",
                Usuario = "adminxd",
                Contraseña = "admin"
            };

            HttpResponseMessage response = await client.PostAsJsonAsync("api/admins", adminNuevo);
            response.EnsureSuccessStatusCode();


            Assert.AreEqual(1, _context.Administradores.ToList()[0].Id) ;
        }
        */





        [TestCleanup]
        public void Cleanup()
        {
            //se elimina la bd creada en memoria para no interferir con futuros tests
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}