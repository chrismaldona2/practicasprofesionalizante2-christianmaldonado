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
    public class Tests
    {
        Cliente chris = new Cliente(45492726, "Christian Maldonado", "+54 3493 439701", "chris.ariel.maldonado@gmail.com");
        Cliente mati = new Cliente(34950413, "Matias Maretto", "+54 3493 419203", "matimaretto@gmail.com");
        Cliente messi = new Cliente(33016244, "Lionel Messi", "+54 3493 340192", "messi10@gmail.com");
        Libro libro1 = new Libro(1, "El Principito", "Antoine de Saint-Exupéry", "El Ateneo");
        Libro libro2 = new Libro(2, "Patrones de Diseño .NET", "Matias Maretto", "Santillana");
        Libro libro3 = new Libro(3, "El mito de Sísifo", "Albert Camus", "Editorial Losada");
        Libro libro4 = new Libro(4, "La metamorfosis", "Franz Kafka", "PenguinLibros");
        List<Cliente> listaClientes = new List<Cliente>();

        [TestInitialize()]
        public void setup()
        {
            listaClientes.Add(chris);
            listaClientes.Add(mati);
            listaClientes.Add(messi);
        }

        [TestMethod()]
        public void reservarLibroTest1()
        {
            //cliente chris reserva un libro
            chris.reservarLibro(libro2, DateTime.Now);

            //se comprueba que el libro quede reservado
            Assert.IsTrue(libro2.Reservado);
        }

        [TestMethod()]
        public void reservarLibroTest2()
        {
            //cliente chris reserva un libro
            chris.reservarLibro(libro2, DateTime.Now);

            //cliente mati intenta reservar el mismo libro
            bool error = false;
            try
            {
                mati.reservarLibro(libro2, DateTime.Now);
            } catch (Exception ex)
            {
                error = true;
            }

            //ocurre un error dado que el libro2 ya lo reservo chris anteriormente
            Assert.IsTrue(error);
        }

        [TestMethod()]
        public void reservarLibroTest3()
        {
            //messi reserva 3 libros
            messi.reservarLibro(libro1, DateTime.Now);
            messi.reservarLibro(libro2, DateTime.Now);
            messi.reservarLibro(libro3, DateTime.Now);


            //intenta reservar un cuarto libro
            bool error = false;
            try
            {
                messi.reservarLibro(libro4, DateTime.Now);
            } catch (Exception ex)
            {
                error = true;
            }

            //aparece una excepción dado que messi supero su limite de 3 libros reservados al mismo tiempo
            Assert.IsTrue(error);
        }

        [TestMethod()]
        public void comprobarDeudorTest1()
        {
            //chris reservo un libro el dia 01/01/2024
            chris.reservarLibro(libro2, new DateTime(2024, 01, 01));

            //se comprueba que efectivamente chris debe un libro hace mas de 30 días
            Assert.IsTrue(chris.comprobarDeudor());
        }

        [TestMethod()]
        public void comprobarDeudorTest2()
        {
            //mati reservo un libro hoy
            mati.reservarLibro(libro2, DateTime.Now);
            Assert.IsFalse(mati.comprobarDeudor());

            //mati viajo al pasado y reservo un libro
            mati.reservarLibro(libro1, new DateTime(2024, 01, 01));
            //hoy se considera deudor
            Assert.IsTrue(mati.comprobarDeudor());
        }

        [TestMethod()]
        public void comprobarDeudorTest3()
        {
            List<Cliente> clientesDeudores = new List<Cliente>();

            chris.reservarLibro(libro2, DateTime.Now);
            mati.reservarLibro(libro3, DateTime.Now);
            messi.reservarLibro(libro4, new DateTime(2024, 01, 01));

            //se comprueba los clientes que deben libros hace mas de 30 días y se los agrega a una lista de deudores
            foreach (var c in listaClientes)
            {
                if (c.comprobarDeudor() == true)
                {
                    clientesDeudores.Add(c);
                }
            }

            //messi entra en la lista y chris no
            Assert.IsTrue(clientesDeudores.Contains(messi));
            Assert.IsFalse(clientesDeudores.Contains(chris));
        }
    }
}