using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor {  get; set; }
        public string Editorial {  get; set; }
        public bool Reservado { get; set; }
        public Libro(int id, string nombre, string autor, string editorial, bool? reservado = null)
        {
            Id = id;
            Nombre = nombre;
            Autor = autor;
            Editorial = editorial;
            Reservado = reservado ?? false;
        }
    }
}
