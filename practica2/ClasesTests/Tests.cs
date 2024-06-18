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
    public class ClienteTests
    {
        [TestMethod()]
        public void ClienteTest1()
        {
            Cliente cliente0 = new Cliente("Christian", "Maldonado", "chris.ariel.maldonado@gmail.com", "+54 9 3493 439701", "San Lorenzo 155");
            Assert.AreEqual(0, cliente0.CodigoCliente);
        }

        [TestMethod()]
        public void ClienteTest2()
        {
            //se comprueba que el codigo autoincremental funciona correctamente
            Cliente cliente1 = new Cliente("Rodrigo", "Perez", "rodriperez@gmail.com", "+54 9 3493 343131", "Lainez 231");
            Cliente cliente2 = new Cliente("Matias", "Maretto", "matiasmaretto@gmail.com", "+54 9 3493 320412", "Leguizamon 432");
            Assert.AreEqual(2, cliente2.CodigoCliente);
        }
        [TestMethod()]
        public void ClienteTest3()
        {
            //se comprueba que el cliente que le corresponde el codigo 2 haya sido añadido a la lista correctamente
            Assert.AreEqual("Matias", Cliente.listaClientes.Find(x => x.CodigoCliente == 2).Nombre);
        }
    }


    [TestClass()]
    public class ProveedorTest
    {

        [TestMethod()]
        public void ProveedorTest1()
        {
            //se comprueba que el proveedor que le corresponde el cuit 30548083156 haya sido añadido a la lista correctamente
            Proveedor proveedor1 = new Proveedor(30548083156, "Coto", "C.I.C.S.A", "info@coto.com.ar", "0810-888-2686", "Paysandú 1842");
            Assert.AreEqual("Coto", Proveedor.listaProveedores.Find(x => x.CUIT == 30548083156).Nombre);
        }

        [TestMethod()]
        public void ProveedorTest2()
        {
            //se comprueba aparezca una excepción en caso de intentar añadir un proveedor cuya CUIT ya se encuentra registrada
            bool Error = false;
            try
            {
                Proveedor proveedor2 = new Proveedor(30548083156, "Coca", "Cola", "info@cocacola.com.ar", "0810-888-2686", "Amancio Alcorta 3570");
            }
            catch (Exception ex)
            {
                Error = true;
            }

            Assert.IsTrue(Error);
        }

        [TestMethod()]
        public void ProveedorTest3()
        {
            //se comprueba que pueda agregar a mi vecino como proveedor
            Proveedor proveedor3 = new Proveedor(30525390086, "Jorge", "No me acuerdo", "jorge@gmail.com", "+54 3493 9 123456", "San Lorenzo 154");

            Assert.AreEqual("San Lorenzo 154", Proveedor.listaProveedores.Find(x => x.CUIT == 30525390086).Direccion);
        }

    }

    [TestClass()]
    public class EmpleadoTest
    {

        [TestMethod()]
        public void EmpleadoTest1()
        {
            //creo empleado al azar
            Empleado empleado1 = new Empleado(00001, TipoEmpleado.Fijo, "Ramon", "Valdes", "donramon@gmail.com", "+54 9 3493 310293", "Rafaela 682");
            Assert.AreEqual("Ramon", Empleado.listaEmpleados.Find(x => x.LegajoEmpleado == 00001).Nombre);
        }

        [TestMethod()]
        public void EmpleadoTest2()
        {
            //se comprueba aparezca una excepción en caso de intentar añadir un empleado cuyo legajo ya se encuentra registrado
            bool Error = false;
            try
            {
                Empleado empleado2 = new Empleado(00001, TipoEmpleado.PorHoras, "Marcos", "Ramirez", "marcosramirez@gmail.com", "+54 9 3493 431234", "Brasil 1403");
            }
            catch (Exception ex)
            {
                Error = true;
            }

            Assert.IsTrue(Error);
        }

        [TestMethod()]
        public void EmpleadoTest3()
        {
            //se comprueba que pueda agregar a mi primo como empleado
            Empleado empleado2 = new Empleado(00002, TipoEmpleado.Pasante, "Santiago", "Ferreyra", "santiferreyra@gmail.com", "+54 9 3493 445902", "Salta 1539");

            Assert.AreEqual("Santiago", Empleado.listaEmpleados.Find(x => x.LegajoEmpleado == 00002).Nombre);
        }
    }
}