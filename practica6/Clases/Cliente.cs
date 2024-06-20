using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        private List<(Libro, DateTime)> LibrosReservados { get; set; }
        public Cliente(int dni, string nombre, string telefono, string email)
        {
            Dni = dni;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            LibrosReservados = new List<(Libro, DateTime)>();
        }
        public void reservarLibro(Libro libro, DateTime fecha)
        {
            try
            {
                if (LibrosReservados.Count >= 3)
                {
                    throw new Exception("El cliente no puede tener más de 3 libros reservados al mismo tiempo.");
                } 
                else if (libro.Reservado == true)
                {
                    throw new Exception("El libro ya se encuentra reservado.");
                }
                else
                {
                    LibrosReservados.Add((libro, fecha));
                    libro.Reservado = true;
                }
            } 
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool comprobarDeudor()
        {
            bool deudor = false;
            try
            {
                foreach(var l in LibrosReservados)
                {
                    if ((DateTime.Now - l.Item2).TotalDays > 30)
                    {
                        deudor = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return deudor;
        }

    }
}
